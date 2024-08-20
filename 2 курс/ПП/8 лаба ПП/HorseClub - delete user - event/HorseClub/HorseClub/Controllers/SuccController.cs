using HorseClub.Models;
using HorseClub.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HorseClub.Controllers
{
    public class SuccController : Controller
    {
        private readonly PpHorseClubDbContext PpHorseClubDbContext;
        public SuccController(PpHorseClubDbContext context)
        {
            PpHorseClubDbContext = context;
        }
        public IActionResult Index(int userId)
        {
            ReposImpl repo = new ReposImpl(PpHorseClubDbContext);
            User user = repo.GetUserById(userId);


            var value1 = (int)TempData["userId"];
            var value2 = (int)TempData["eventId"];
            var username = repo.GetUserById(value1);
            var eventname = repo.GetEventById(value2);
            ViewData["Name"] = username;
            ViewData["EventName"] = eventname;
            ViewData["Message"] = "Привет, мир! Это сообщение передано через ViewData.";
            ViewBag.Message = "Hello from SuccController!";
            return View();

        }


    }
}
