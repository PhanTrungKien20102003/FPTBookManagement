using FPTBookManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace FPTBookManagement.Models
{
	public class SeedData
	{
		public static void EnsurePopulated(IApplicationBuilder app)
		{
			FPTBookDBContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<FPTBookDBContext>();

			if (context.Database.GetPendingMigrations().Any())
			{
				context.Database.Migrate();
			}

			if (!context.Books.Any())
			{
				context.Books.AddRange(
					new Book
					{
						Title = "A",
						Price = 275,
						Category = "A",
						Author = "Mr.A",
						Puslisher = "Company A"
												
					},
					new Book
					{
						Title = "B",
						Price = 235,
						Category = "B",
						Author = "Mr.B",
						Puslisher = "Company B"

					}, 
					new Book
					{
						Title = "C",
						Price = 175,
						Category = "C",
						Author = "Mr.C",
						Puslisher = "Company C"

					},
					new Book
					{
						Title = "D",
						Price = 111,
						Category = "D",
						Author = "Mr.D",
						Puslisher = "Company D"

					},
					new Book
					{
						Title = "E",
						Price = 222,
						Category = "E",
						Author = "Mr.E",
						Puslisher = "Company E"

					},
					new Book
					{
						Title = "F",
						Price = 333,
						Category = "F",
						Author = "Mr.F",
						Puslisher = "Company F"

					}

				);
				context.SaveChanges();
			}
		}
	}
}

