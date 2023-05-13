using FPTBookManagement.Data;
using FPTBookManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace FPTBookManagement.Repository
{
    public class EFOrderRepository : IOrderRepository
	{
		private FPTBookDBContext context;
		public EFOrderRepository(FPTBookDBContext context)
		{
			this.context = context;
		}

		public IQueryable<Order> Orders => context.Orders.Include(o => o.Lines).ThenInclude(l => l.Book);

		public void SaveOrder(Order order)
		{
			context.AttachRange(order.Lines.Select(l => l.Book));
			if(order.OrderId == 0) {
				context.Orders.Add(order);
				
			}
			context.SaveChanges();
		}
	}

}