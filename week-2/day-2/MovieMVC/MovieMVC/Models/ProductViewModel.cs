using System;
namespace MovieMVC.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }

    }
    public class productsException : Exception
    {
        public override string Message
        {
            get
            {
                return "not a valid product details...";
            }
        }
    }
}