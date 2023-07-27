using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using TaskManagement.Data;
using TaskManagement.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace TaskManagement.Controllers
{
    [Route("api/Auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly TaskContext _context;
        private readonly IUserService _userService;
        private readonly  IConfiguration _configuration ;
        public User user = new User();
        public AuthController(IConfiguration configuration, TaskContext context , IUserService userService)
        {
            _configuration = configuration;
            _context = context;
            _userService = userService;
        }

        [HttpGet("GetMe"),Authorize]
         public ActionResult<string> GetMe()
        {
            var userName = _userService.GetMe();
            //var userName = User.Identity.Name;
            return Ok(userName);
        }
        [HttpPost("Register")]
        public async Task<IActionResult> Register(UserDTO request)
        {
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
            user.Name = request.Name;
            user.Email = request.Email;
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;
            _context.User.Add(user);
            await _context.SaveChangesAsync();

            return Ok("User Created And Added To DB Successfully");

        }
        [HttpPost("Login")]
        public async Task<ActionResult<string>> Login(UserDTO request)
        {
            var user =  _context.User.FirstOrDefault(s => s.Name == request.Name);
            if (user == null)
            {
                return BadRequest("User Not Found");
            }
            if(!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Wrong Password");
            }
            string token = CreateToken(user, _configuration);
            return Ok(token);
        }
        public static string CreateToken(User user, IConfiguration configuration)
        {
            List<Claim> claims = new List<Claim> { 
                new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Role, "Admin")
            };
            ;
            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(configuration.GetSection("Appsettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires:DateTime.Now.AddDays(2),
                signingCredentials:creds 
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);
            return jwt;
        }
        private static void CreatePasswordHash(string password,out byte[] passwordHash, out byte[] passwordSalt)
        {
            using( var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private static bool VerifyPasswordHash(string password,byte[] passwordHash, byte[] PasswordSalt)
        {
            using(var hmac = new HMACSHA512(PasswordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
    }
}
