using FPTBookManagement.Models;
using FPTBookManagement.Models.ViewModels;
using FPTBookManagement.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FPTBookManagement.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository BookRepository;
        public int PageSize = 4;
        public HomeController(IBookRepository bookRepository)
        {
            this.BookRepository = bookRepository;
        }
        public ViewResult Index(string? category,int productPage = 1)
            => View(new ProductsListViewModel
            {
                Books = BookRepository.Books
                    .Where(p=> category == null || p.Category == category)
                    .OrderBy(b => b.Id)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                
                PagingInfo = new PagingInfo {
                    CurrentPage= productPage,
                    ItemsPerPage=PageSize,
                    TotalItems = category == null ? BookRepository.Books.Count() : BookRepository.Books.Where(e=>e.Category== category).Count()
                },

                CurrentCategory= category
                
            });
        
		public ViewResult AboutView()
		{
			return View();
		}



	}
}