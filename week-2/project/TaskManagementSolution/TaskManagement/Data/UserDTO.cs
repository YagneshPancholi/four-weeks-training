using System.Reflection.Metadata.Ecma335;
using TaskManagement.Models;

namespace TaskManagement.Data
{
    public class UserDTO
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; }
        public string Password { get; set; } = string.Empty;
    }
}
