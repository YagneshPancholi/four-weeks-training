using Microsoft.EntityFrameworkCore;

namespace WebApplicationWithEF.Models
{
	public class ProductContext: DbContext
	{
		public ProductContext(DbContextOptions<ProductContext> options)
		   : base(options)
		{

		}
		public DbSet<Product> Products { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Customer>().ToTable("Customer");
        }

    }
}
