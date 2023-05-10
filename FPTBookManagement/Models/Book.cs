using System.ComponentModel.DataAnnotations.Schema;
namespace FPTBookManagement.Models
{
	public class Book
	{
		public long? Id { get; set; }
		public string Title { get; set; } =string.Empty;

		[Column(TypeName = "decimal(8,2)")]
		public int Price { get; set; }
		public string Category { get; set; } = string.Empty;
		public string Author { get; set; } = string.Empty;
		public string Puslisher { get; set; } = string.Empty;
	}
}
