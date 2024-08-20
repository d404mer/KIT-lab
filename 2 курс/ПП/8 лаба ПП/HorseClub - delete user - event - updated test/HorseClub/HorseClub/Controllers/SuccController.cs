using HorseClub.Models;
using HorseClub.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HorseClub.Controllers
{
    public class SuccController : Controller
    {
        private readonly PpHorseClubDbContext db;
        public SuccController(PpHorseClubDbContext context)
        {
            db = context;
        }
        public IActionResult SuccView(int userId, int eventId)
        {

            TempData["userId"] = userId;

            ReposImpl repo = new ReposImpl(db);

            var currEvent = repo.GetEventById(eventId);
            var currUser = repo.GetUserById(userId);

            if (currEvent != null && currUser != null)
            {
                EVENTPLUSUSER eventToAdd = new EVENTPLUSUSER();
                eventToAdd.CURR_USER_ID = currUser.USER_ID;
                eventToAdd.CURR_EVENT_ID = currEvent.EVENTS_ID;
                if (eventToAdd.CURR_EVENT_ID != 0   && eventToAdd.CURR_USER_ID != null)
                {
                        repo.AddList(eventToAdd);
                        var eventname = currEvent.EVENTS_name;
                        var username = currUser.USER_name;
                        ViewData["Name"] = username;
                        ViewData["EventName"] = eventname;

                        return View();
                }
            }

            return RedirectToAction("ErrorView");

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
