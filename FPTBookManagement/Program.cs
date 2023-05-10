using Microsoft.EntityFrameworkCore;
using FPTBookManagement.Models;
using FPTBookManagement.Repository;
using SportsStore.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<FPTBookDBContext>(opts => {
    opts.UseSqlServer(
        builder.Configuration["ConnectionStrings: FPTBookConnection"]);
});
builder.Services.AddScoped<IBookRepository, EFBookRepository>();
builder.Services.AddScoped<IPersonRepository, EFPersonRepository>();

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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

SeedData.EnsurePopulated(app);

app.Run();
