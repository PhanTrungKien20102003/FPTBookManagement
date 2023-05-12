using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public interface IBookRepository
	{
		IQueryable<Book> Books { get; }

		void SaveItem(Book b);
		void CreateItem(Book b);
		void DeleteItem(Book b);
		
	}
}
