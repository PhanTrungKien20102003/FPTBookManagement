using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public class EFPersonRepository
	{
		private FPTBookDBContext context;
		public EFPersonRepository(FPTBookDBContext context)
		{
			this.context = context;
		}

		public IQueryable<Person> Persons => context.Persons;
	}
}
