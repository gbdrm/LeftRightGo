using Microsoft.AspNetCore.Mvc;

namespace LeftRightGo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SetName(string name)
        {
            return RedirectToAction("Index", "Room", new { id = 1 });
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
