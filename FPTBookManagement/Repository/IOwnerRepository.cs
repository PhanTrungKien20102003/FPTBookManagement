using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
    public interface IOwnerRepository
    {
        IQueryable<Owner> Owner { get; }

        void SaveItem(Owner o);
        void CreateItem(Owner o);
        void DeleteItem(Owner o);
    }
}
