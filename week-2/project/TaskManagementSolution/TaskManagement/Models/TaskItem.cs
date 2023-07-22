using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Models
{
   
    public class TaskItem
    {
        [Key]
        public int TaskId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public Status Status { get; set; }
        
        [Required]
        public Priority Priority { get; set; }

        [Required]
        public DateTime DueDate { get; set; }
      
    }
    public enum Status
    {
        Todo, InProgress, Done
    }
    public enum Priority
    {
        High, Medium, Low
    }

}
