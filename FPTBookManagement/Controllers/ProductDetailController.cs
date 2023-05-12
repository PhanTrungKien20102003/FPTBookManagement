using FPTBookManagement.Models;
using FPTBookManagement.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FPTBookManagement.Controllers
{
	public class ProductDetailController : Controller
	{
		public IBookRepository repository;
		public ProductDetailController(IBookRepository repository)
		{
			this.repository = repository;
		}

		public IActionResult Index(long id)=> View(repository.Books.Where(b => b.Id == id).FirstOrDefault());
					
		
	}
}
