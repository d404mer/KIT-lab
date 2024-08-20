using HorseClub.DTO;
using HorseClub.Models;
using HorseClub.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace HorseClub.Controllers
{
    public class EventsController : Controller
    {
        private readonly PpHorseClubDbContext db;
        public EventsController(PpHorseClubDbContext context)
        {
            db = context;
        }

        public IActionResult EventsView(int userId)
        {
            List<Event> events = db.Events.ToList();

              TempData["userId"] = userId;
            //ViewData["userId"] = userId;
            return View(events);
        }

        [HttpPost]
        public IActionResult EventsView(int userId, int eventId,EventRegisterModel currEvent)
        {
            TempData["userId"] = userId;

            List<Event> events = db.Events.ToList();

            ViewData["userId"] = userId;
            ViewData["eventId"] = eventId;
            currEvent.CURR_EVENT_ID = eventId;
            currEvent.CURR_USER_ID = userId;

            ReposImpl repo = new ReposImpl(db);

            User user = repo.GetUserById(userId);

            if (user != null)
            {
                return RedirectToAction("SuccView", "Succ", new { userId = currEvent.CURR_USER_ID, eventId = currEvent.CURR_EVENT_ID });
            }
            else
            {
               
                TempData["ErrorMessage"] = "User not found";
                return View(events);
                
            }

        }

        [HttpPost]
        public IActionResult ToCard()
        {

            if (TempData["userId"] is int userId)
            {
                ViewData["userId"] = userId;
                ReposImpl repo = new ReposImpl(db);

                User UserToUpdate = repo.GetUserById(userId);


                return RedirectToAction("Index", "Card", new { userId = UserToUpdate.USER_ID });

            }

            return View();
        }


    }
}
