using FPTBookManagement.Models;
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
        public ViewResult Index(int productPage = 1) 
            => View(BookRepository.Books
                .OrderBy(b => b.Id)
                .Skip((productPage - 1 ) * PageSize)
                .Take(PageSize));
    }
}