using LeftRightGo.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeftRightGo.Controllers
{
    [Route("[controller]")]
    public class RoomController : Controller
    {
        [Route("{id:int}")]
        public IActionResult Index(int id)
        {
            var model = new RoomViewModel
            {
                Name = id.ToString()
            };

            return View(model);
        }
    }
}