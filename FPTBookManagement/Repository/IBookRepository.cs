using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public interface IBookRepository
	{
		IQueryable<Book> Books { get; }
	}
}
