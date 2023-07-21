using BookStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Data
{
    public class BookContext :DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) 
            : base(options) 
        { 
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}
