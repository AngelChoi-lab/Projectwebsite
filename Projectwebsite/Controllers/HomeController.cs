using Microsoft.AspNetCore.Mvc;

namespace ProjectWebsite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Video()
        {
            return View();
        }

        public IActionResult Members()
        {
            return View();
        }

        public IActionResult Background()
        {
            return View();
        }

    }
}
