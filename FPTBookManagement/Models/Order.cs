﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations;

namespace FPTBookManagement.Models
{
    public class Order
    {
		[BindNever]
		public int OrderId { get; set; }
		[BindNever]
		public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();

		[Required(ErrorMessage = "Please enter Name")]
		public string? Name { get; set; }

		[Required(ErrorMessage = "Please enter the first address line")]
		public string? Line1 { get; set; }
		public string? Line2 { get; set; }
		public string? Line3 { get; set; }

		[Required(ErrorMessage = "Please enter city Name")]
		public string? City { get; set; }

		[Required(ErrorMessage = "Please enter state Name")]
		public string? State { get; set; }

		public string? Zip { get; set; }

		[Required(ErrorMessage = "Please enter country Name")]
		public string? Country { get; set; }

		public bool GiftWrap { get; set; }

		[BindNever]
		public bool Shipped { get; set; }
	}
}
