namespace ProductMVCWithEF
{
    using Microsoft.EntityFrameworkCore;
    using ProductMVCWithEF.Models;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore.Design;

    public class ECommerceDbContext : DbContext
    {
        public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
       

        public async Task<int> AddProduct(Product product)
        {
            await Products.AddAsync(product);
            await SaveChangesAsync();
            return product.ProductId;
        }

        public async Task<Product> GetProductById(int productId)
        {
            return await Products.FindAsync(productId);
        }
        public async Task<bool> UpdateProduct(Product updatedProduct)
        {
            var existingProduct = await Products.FindAsync(updatedProduct.ProductId);

            if (existingProduct == null)
                return false;

            existingProduct.Name = updatedProduct.Name;
            existingProduct.Price = updatedProduct.Price;
            existingProduct.CategoryId = updatedProduct.CategoryId;

            await SaveChangesAsync();
            return true;
        }
        public async Task<bool> DeleteProduct(int productId)
        {
            var product = await Products.FindAsync(productId);

            if (product == null)
                return false;

            Products.Remove(product);
            await SaveChangesAsync();
            return true;
        }


    }

}
