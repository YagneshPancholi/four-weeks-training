using System.Security.Claims;

namespace TaskManagement.Services.UserServices
{
    public class UserServiceImpl : IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UserServiceImpl(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public string GetMe()
        {
            var result = string.Empty;
            if(_httpContextAccessor.HttpContext != null)
            {
                result = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
            }
            return result;
        }
    }
}
