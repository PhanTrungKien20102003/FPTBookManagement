using Microsoft.AspNetCore.Mvc;
using FPTBookManagement.Models;
using FPTBookManagement.Repository;

namespace FPTBookManagement.Controllers
{
	public class OwnerController : Controller
	{
		private ICategoryRepository repository;
		public OwnerController(ICategoryRepository repository)
		{
			this.repository = repository;
		}


		public ViewResult AddCategory()
		{
			return View(new Category());
		}

		[HttpPost]
		public IActionResult AddCategory(Category category) {
			if(ModelState.IsValid)
			{
				repository.CreateItem(category);
				return RedirectToPage("/CompleteAddNewCategory", new { categoryName = category.CategoryName});
			}
			else
			{
				return View();
			}
		}
	}
}
