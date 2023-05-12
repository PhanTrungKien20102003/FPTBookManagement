using System.ComponentModel.DataAnnotations;

namespace FPTBookManagement.Models
{
	public class Category
	{
		public long Id { get; set; }
		[Required]
		public string CategoryName { get; set; }

	}
}
