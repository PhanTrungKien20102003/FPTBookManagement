using FPTBookManagement.Models;
using FPTBookManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FPTBookManagement.Controllers
{
	public class OrderController : Controller
	{
		private IOrderRepository repository;
		private Cart Cart;

		public OrderController(IOrderRepository repository, Cart cart)
		{
			this.repository = repository;
			this.Cart = cart;
		}

		public ViewResult Checkout() => View(new Order());

		[HttpPost]
		public IActionResult Checkout(Order order)
		{
			if (Cart.Lines.Count() == 0)
			{
				ModelState.AddModelError("", "Sorry, Your cart is empty");
			}
			if (ModelState.IsValid)
			{
				order.Lines = Cart.Lines.ToArray();
				repository.SaveOrder(order);
				Cart.Clear();
				return RedirectToPage("/Completed", new { orderId = order.OrderId });
			}
			else
			{
				return View();
			}
		}
	}
}
