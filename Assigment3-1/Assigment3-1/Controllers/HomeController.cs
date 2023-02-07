using Assigment3_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assigment3_1.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }
          
        public IActionResult About()
        {
            return View();
        }
    }
}