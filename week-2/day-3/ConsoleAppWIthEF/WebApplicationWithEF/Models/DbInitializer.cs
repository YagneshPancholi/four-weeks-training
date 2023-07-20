using WebApplicationWithEF.Models;
    public  static class DbInitializer
    {

    public static void Initialize(ProductContext context)
    {
        // Look for any students.
        if (context.Products.Any())
        {
            return;   // DB has been seeded
        }
        var products = new Product[]
        {
            //new Product{ ProductId=, }
        };
        context.Products.AddRange(products);
        context.SaveChanges();

        var categories = new Category[]
        {

        };
        context.Categories.AddRange(categories);
        context.SaveChanges();

        var customers = new Customer[]
        {

        };
        context.Customers.AddRange(customers);
        context.SaveChanges();
    }
    }

