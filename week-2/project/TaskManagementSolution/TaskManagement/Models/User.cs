using System.ComponentModel.DataAnnotations;
namespace TaskManagement.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }    
        

        public List<TaskItem> Tasks { get; set; }
    }
}
