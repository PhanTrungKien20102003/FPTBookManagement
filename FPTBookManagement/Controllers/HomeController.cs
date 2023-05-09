using FPTBookManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FPTBookManagement.Controllers
{
    public class HomeController : Controller
    {
       public IActionResult Index() => View(); 
    }
}