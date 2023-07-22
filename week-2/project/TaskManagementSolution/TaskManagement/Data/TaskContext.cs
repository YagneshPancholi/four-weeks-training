using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Models;

namespace TaskManagement.Data
{
    public class TaskContext : DbContext
    {
        public TaskContext(DbContextOptions<TaskContext> options) 
            : base(options)
        {
        }
       
        public DbSet<TaskItem> Tasks { get; set; }
       
        public DbSet<TaskManagement.Models.User> User { get; set; } = default!;


    }
}
