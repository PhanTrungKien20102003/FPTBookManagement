using FPTBookManagement.Infrastructure;
using FPTBookManagement.Models;
using FPTBookManagement.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace FPTBookManagement.Pages
{
    public class CartModel : PageModel
    {
	
		private IBookRepository bookRepository;

		public CartModel(IBookRepository bookRepository, Cart cartService)
		{
			this.bookRepository = bookRepository;
			this.Cart = cartService;
			
		}
		public Cart Cart { get; set; }
		public string ReturnUrl { get; set; } = "/";
		public void OnGet(string returnUrl)
		{
			ReturnUrl = returnUrl ?? "/";
		
		}

		public IActionResult OnPost(long Id, string returnUrl)
		{
			Book? book = bookRepository.Books.FirstOrDefault(p => p.Id == Id);
			if (book != null)
			{
				Cart.AddItem(book, 1);	
			}
			return RedirectToPage(new { returnUrl = returnUrl });
		}

		public IActionResult OnPostRemove(long bookId, string returnUrl)
		{
			Cart.RemoveLine(Cart.Lines.First(cl => cl.Book.Id== bookId).Book);
			return RedirectToPage(new { returnUrl = returnUrl });
		}
	}
}
