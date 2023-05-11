using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public class EFOrderRepository : IOrderRepository
	{
		private FPTBookDBContext context;
		public EFOrderRepository(FPTBookDBContext context)
		{
			this.context = context;
		}

		public IQueryable<Order> Orders => context.Orders;
	}

}