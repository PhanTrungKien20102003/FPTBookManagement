using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public class IOrderRepository
	{
		IQueryable<Cart> Carts { get; set; }
	}
}
