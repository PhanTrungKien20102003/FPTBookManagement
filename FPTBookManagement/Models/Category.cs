using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace FPTBookManagement.Models
{
	public class Category
	{
		[BindNever]
		public long? Id { get; set; }
		[Required]
		public string CategoryName { get; set; }

		[BindNever]
		public bool Approved { get; set; }

		

	}
}
