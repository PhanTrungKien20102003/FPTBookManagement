using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FPTBookManagement.Data
{
	public static class IdentitySeedData
	{
		private const string adminUser = "Admin";
		private	const string adminPassword = "Password123@";

		public static async void EnsurePopulated(IApplicationBuilder app)
		{
			AppIdentityDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AppIdentityDbContext>();
			if (context.Database.GetPendingMigrations().Any())
			{
				context.Database.Migrate();
			}

			UserManager<IdentityUser> userManager = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

			IdentityUser user = await userManager.FindByNameAsync(adminUser); 
			if (user == null)
			{
				user = new IdentityUser("Admin");
				user.Email = "admin@admin.com";
				user.PhoneNumber = "09111111111";
				await userManager.CreateAsync(user, adminPassword);
			}
		}
	}
}
