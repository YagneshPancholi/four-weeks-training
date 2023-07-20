using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationWithEF.Models
{
	public class Product
	{
		[Key]
		public int ProductId { get; set; }
		[Required]
		[MaxLength(50)]
		public string ProductName { get; set; }
		[Required]
		public decimal ProductPrice { get; set; }	
		public int CategoryId { get; set; }
		

	}
}
