using FPTBookManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace FPTBookManagement.Data
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
                        Category = "Cat1",
                        Author = "Mr.A",
                        Publisher = "Company A"

                    },
                    new Book
                    {
                        Title = "B",
                        Price = 235,
                        Category = "Cat2",
                        Author = "Mr.B",
                        Publisher = "Company B"

                    },
                    new Book
                    {
                        Title = "C",
                        Price = 175,
                        Category = "Cat3",
                        Author = "Mr.C",
                        Publisher = "Company C"

                    },
                    new Book
                    {
                        Title = "D",
                        Price = 111,
                        Category = "Cat4",
                        Author = "Mr.D",
                        Publisher = "Company D"

                    },
                    new Book
                    {
                        Title = "E",
                        Price = 222,
                        Category = "Cat1",
                        Author = "Mr.E",
                        Publisher = "Company E"

                    },
                    new Book
                    {
                        Title = "F",
                        Price = 333,
                        Category = "Cat2",
                        Author = "Mr.F",
                        Publisher = "Company F"

                    }

                );
                context.SaveChanges();
            }
            if (context.Categories.Any())
            {
                context.Categories.AddRange(
                    new Category
                    {
                        CategoryName = "Cat1"
                    },
                    new Category
                    {
                        CategoryName = "Cat2"
                    },
                    new Category
                    {
                        CategoryName = "Cat3"
                    },
                    new Category
                    {
                        CategoryName = "Cat4"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}

