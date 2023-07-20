namespace ProductMVCWithEF.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
       
        public int CategoryId { get; set; }
		

		public Product()
		{
		}
	}
   
    public class productsException : Exception
    {
        public override string Message
        {
            get
            {
                return "product Name can not be NULL...";
            }
        }
    }
}
