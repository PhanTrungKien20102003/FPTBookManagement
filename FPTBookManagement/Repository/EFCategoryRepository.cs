using FPTBookManagement.Data;
using FPTBookManagement.Models;

namespace FPTBookManagement.Repository
{
	public class EFCategoryRepository : ICategoryRepository
	{
		private FPTBookDBContext context;
		public EFCategoryRepository(FPTBookDBContext context)
		{
			this.context = context;
		}
		public IQueryable<Category> Categories => context.Categories;

		public void CreateItem(Category b)
		{
			context.Categories.Add(b);
			context.SaveChanges();
		}

		public void DeleteItem(Category b)
		{
			context.Categories.Remove(b);
			context.SaveChanges();
		}

		public void SaveItem(Category b)
		{
			context.SaveChanges();
		}
	}
}
