using FPTBookManagement.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FPTBookManagement.Controllers
{
	public class AccountController : Controller
	{
		private UserManager<IdentityUser> userManager;
		private SignInManager<IdentityUser> signInManager;

		public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
		{
			this.userManager = userManager;
			this.signInManager = signInManager;
		}

		public ViewResult Login(string returnUrl)
		{
			return View(new LoginViewModel
			{
				ReturnUrl = returnUrl
			});
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Login(LoginViewModel loginVM) {
			if (ModelState.IsValid)
			{
				IdentityUser user = await userManager.FindByNameAsync(loginVM.Name);
				if (user != null) {
					await signInManager.SignOutAsync();
					if((await signInManager.PasswordSignInAsync(user, loginVM.Password, false, false)).Succeeded)
					{
						return Redirect(loginVM?.ReturnUrl ?? "/Admin");
					}
				}
				ModelState.AddModelError("", "Invalid Username or Password");
			}
			return View(loginVM);
		}

		[Authorize]
		public async Task<RedirectResult> Logout(string returnUrl = "/")
		{
			await signInManager.SignOutAsync();
			return Redirect(returnUrl);
		}

		
	}
}
