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
	}
}
