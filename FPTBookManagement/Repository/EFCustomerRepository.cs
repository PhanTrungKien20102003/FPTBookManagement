using FPTBookManagement.Data;
using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
    public class EFCustomerRepository: ICustomerRepository
	{
		private FPTBookDBContext context;
		public EFCustomerRepository(FPTBookDBContext context)
		{
			this.context = context;
		}

        public IQueryable<Customer> Customers => context.Customers;
        public void CreateItem(Customer c)
        {
            context.Add(c);
            context.SaveChanges();
        }

        public void DeleteItem(Customer c)
        {
            context.Remove(c);
            context.SaveChanges();
        }

        public void SaveItem(Customer c)
        {
            context.SaveChanges();
        }
    }
}
