using FPTBookManagement.Data;
using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
    public class EFOwnerRepository : IOwnerRepository
    {
        private FPTBookDBContext context;
        public EFOwnerRepository(FPTBookDBContext context)
        {
            this.context = context;
        }

        public IQueryable<Owner> Owners => context.Owners;
        public void CreateItem(Owner o)
        {
            context.Add(o);
            context.SaveChanges();
        }

        public void DeleteItem(Owner o)
        {
            context.Remove(o);
            context.SaveChanges();
        }

        public void SaveItem(Owner o)
        {
            context.SaveChanges();
        }
    }
}
