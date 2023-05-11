using FPTBookManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace FPTBookManagement.Components
{
	public class CartSummaryViewComponent : ViewComponent
	{
		private Cart cart;
		public CartSummaryViewComponent(Cart cartService)
		{
			this.cart = cartService;
		}

		public IViewComponentResult Invoke()
		{
			return View(cart);
		}
	}
}
