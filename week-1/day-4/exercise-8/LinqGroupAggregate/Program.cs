namespace LinqGroupAggregate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of Product objects
            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1200.00M },
            new Product { Name = "Smartphone", Category = "Electronics", Price = 800.00M },
            new Product { Name = "Headphones", Category = "Electronics", Price = 200.00M },
            new Product { Name = "Shirt", Category = "Clothing", Price = 30.00M },
            new Product { Name = "Jeans", Category = "Clothing", Price = 60.00M },
            new Product { Name = "Sneakers", Category = "Footwear", Price = 100.00M }
        };

            // 1. Group products by category
            Console.WriteLine("Group products by category:");
            var groupedByCategory = products.GroupBy(x => x.Category).ToList();
            foreach (IGrouping<string, Product> productGroup in groupedByCategory)
            {
                Console.WriteLine(productGroup.Key + " : " + productGroup.Count());
                foreach (var p in productGroup)
                {
                    Console.WriteLine("Name :" + p.Name + ", Price :" + p.Price);
                }
                Console.WriteLine("total price of products in each category : " + productGroup.Sum(s => s.Price));
                
                Console.WriteLine("The Most expensive Product : ");
                var mostexpeprod = productGroup.MaxBy(p => p.Price);
                Console.WriteLine("Name :" + mostexpeprod.Name +", Category : "+ mostexpeprod .Category+ ", Price :" + mostexpeprod.Price);
            }

            // 2. Count the number of products in each category
            // 3. Calculate the total price of products in each category
            // 4. Find the most expensive product in each category
            Console.ReadLine();
        }
    }
}