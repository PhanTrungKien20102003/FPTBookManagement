using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
    public interface IOwnerRepository
    {
        IQueryable<Owner> Owners { get; }

        void SaveItem(Owner o);
        void CreateItem(Owner o);
        void DeleteItem(Owner o);
    }
}
