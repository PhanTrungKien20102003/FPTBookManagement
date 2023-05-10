using FPTBookManagement.Models;

namespace FPTBookManagement.Views
{
    public interface IPersonRepository
    {
        IQueryable<Person> Persons { get; }
    }
}
