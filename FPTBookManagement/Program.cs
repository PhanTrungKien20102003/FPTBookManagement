using Microsoft.EntityFrameworkCore;
using FPTBookManagement.Models;
using FPTBookManagement.Repository;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FPTBookDBContext>(opts => {
    opts.UseSqlServer(
        builder.Configuration["ConnectionStrings:FPTBookConnection"]);
});
builder.Services.AddScoped<IBookRepository, EFBookRepository>();
builder.Services.AddScoped<IPersonRepository, EFPersonRepository>();

builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllerRoute("catpage",
    "{category}/Page{productPage:int}",
    new { Controller = "Home", Action = "Index" });

app.MapControllerRoute("page", "Page{productPage:int}",
    new { Controller = "Home", Action = "Index", productPage = 1 });

app.MapControllerRoute("category", "{category}",
    new { Controller = "Home", Action = "Index", productPage = 1 });

app.MapControllerRoute("pagination", "Products/Page{productPage}",
    new { Controller = "Home", action = "Index", productPage = 1 });

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

SeedData.EnsurePopulated(app);

app.Run();
