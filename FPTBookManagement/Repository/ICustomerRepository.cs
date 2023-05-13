using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public interface ICustomerRepository
	{
		IQueryable<Customer> Customers { get; }
        void SaveItem(Customer c);
        void CreateItem(Customer c);
        void DeleteItem(Customer c);
    }
}
