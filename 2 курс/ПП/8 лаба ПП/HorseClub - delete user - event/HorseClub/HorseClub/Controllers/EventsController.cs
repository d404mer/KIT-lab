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
            ViewData["userId"] = userId;
            return View(events);
        }

        [HttpPost]
        public IActionResult EventsView(int userId, EventRegisterModel model)
        {
            ViewData["userId"] = userId;

            int eventId = GetCurrentEventId(model);
            TempData["userId"] = userId;
            TempData["eventId"] = eventId;

            

            ReposImpl repo = new ReposImpl(db);

            User user = new User();
            user.USER_ID = 39;
            if (user != null)
            {
                List userEvent = new List
                {
                    FK_USER_ID = user.USER_ID,
                    FK_EVENT_ID = eventId
                };

                db.EVENTPLUSUSER.Add(userEvent);



                TempData["ErrorMessage"] = "Вы успешно зарегистрировались на мероприятие!";
            }
            else
            {
                // Можете добавить обработку случая, когда пользователь не авторизован
                TempData["ErrorMessage"] = "Для записи на мероприятие необходимо войти в систему.";
            }



            //return RedirectToAction("Index", "Card", new { userId = user.USER_ID });
            return View("~/Views/Succ/SuccView.cshtml");
        }




        private int GetCurrentUserId(EventRegisterModel model)
        {
            
            var userId = model.UserId;
            return userId;
        }

        private int GetCurrentEventId(EventRegisterModel model)
        {
            var eventId = model.EventId;
            return eventId;
        }
    }
}
