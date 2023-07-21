using System.ComponentModel.DataAnnotations;

namespace BookStoreApp.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(100)]
        public string Genre { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public Author Author { get; set; }
    }
}
