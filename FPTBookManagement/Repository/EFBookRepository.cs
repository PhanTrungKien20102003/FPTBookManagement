using FPTBookManagement.Data;
using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
    public class EFBookRepository : IBookRepository
	{
		private FPTBookDBContext context;
		public EFBookRepository(FPTBookDBContext context)
		{
			this.context = context;
		}

		public IQueryable<Book> Books => context.Books;

		public void CreateItem(Book b)
		{
			context.Add(b);
			context.SaveChanges();
		}

		public void DeleteItem(Book b)
		{
			context.Remove(b);
			context.SaveChanges();
		}

		public void SaveItem(Book b)
		{
			context.SaveChanges();
		}
	}
}
