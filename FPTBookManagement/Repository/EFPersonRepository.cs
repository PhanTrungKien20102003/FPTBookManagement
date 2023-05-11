using FPTBookManagement.Data;
using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
    public class EFPersonRepository: IPersonRepository
	{
		private FPTBookDBContext context;
		public EFPersonRepository(FPTBookDBContext context)
		{
			this.context = context;
		}

		public IQueryable<Person> Person => context.Persons;
	}
}
