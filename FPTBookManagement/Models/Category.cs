using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FPTBookManagement.Models
{
	public class Category
	{
		public long? Id { get; set; }
		[Required]
		public string CategoryName { get; set; }

	}
}
