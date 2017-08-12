using System.CodeDom;
using LeftRightGo.Data;
using LeftRightGo.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeftRightGo.Controllers
{
    [Route("[controller]")]
    public class RoomController : Controller
    {
        private ApplicationDbContext _db;

        public RoomController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Route("{id:int}")]
        public IActionResult Index(int id)
        {
            var model = new RoomViewModel
            {
                //Reaction = $"Hello, {name}",
                Name = id.ToString(),
                Question = "How are you??"
            };

            return View(model);
        }

        [Route("test")]
        public IActionResult Test()
        {
            _db.Rooms.Add(new Room
            {
                Id = "1",
                Name = "First"
            });
            _db.SaveChanges();

            return Ok();
        }
    }
}