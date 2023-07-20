using System.ComponentModel.DataAnnotations;

namespace WebApplicationWithEF.Models
{
	public enum CategoryName
	{
		Electric, Kitchen, SelfImprovement, Food, Funrniture
	}
	public class Category
	{
		[Key]
		public int CategoryId { get; set; }
		public CategoryName CategoryName { get; set; }
		
	}
}
