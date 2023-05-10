using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public interface IPersonRepository
	{
		IQueryable<Person> Person { get; }
	}
}
