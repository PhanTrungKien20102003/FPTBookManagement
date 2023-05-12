using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public interface ICategoryRepository
	{
		IQueryable<Category> Categories { get; }

		void SaveItem(Category b);
		void CreateItem(Category b);
		void DeleteItem(Category b);

	}
}
