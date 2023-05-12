using FPTBookManagement.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FPTBookManagement.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private ICategoryRepository repository;

        public NavigationMenuViewComponent(ICategoryRepository repository)
        {
            this.repository = repository;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Categories.Select(p => p.CategoryName).Distinct().OrderBy(p => p));
        }
    }
}
