using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public interface ICustomerRepository
	{
		IQueryable<Customer> Customer { get; }

        void SaveItem(Customer c);
        void CreateItem(Customer c);
        void DeleteItem(Customer c);
    }
}
