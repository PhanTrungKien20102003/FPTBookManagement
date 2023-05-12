using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace FPTBookManagement.Models
{
	public class Book
	{
		public long? Id { get; set; }

		[Required(ErrorMessage ="Please enter the Book Titile")]
		public string Title { get; set; } =string.Empty;

		
		[Column(TypeName = "decimal(8,2)")]
		public int Price { get; set; }

		[Required(ErrorMessage = "Please Choose the Book Category")]
		public string Category { get; set; } = string.Empty;
		[Required(ErrorMessage = "Please enter the Book Author Name")]
		public string Author { get; set; } = string.Empty;
		[Required(ErrorMessage = "Please enter the Book PushlisherName")]
		public string Puslisher { get; set; } = string.Empty;
	}
}
