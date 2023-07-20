using System.ComponentModel.DataAnnotations;

namespace WebApplicationWithEF.Models
{
	public class Customer
	{
		[Key]
		public int CustomerId { get; set; }
		public string CustomerName { get; set; }

	}
}
