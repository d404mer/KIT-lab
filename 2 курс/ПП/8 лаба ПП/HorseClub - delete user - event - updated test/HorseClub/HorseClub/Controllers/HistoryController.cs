using HorseClub.Models;
using HorseClub.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HorseClub.Controllers
{
    public class HistoryController : Controller
    {
        private readonly PpHorseClubDbContext db;
        public HistoryController(PpHorseClubDbContext context)
        {
            db = context;
        }
        public IActionResult Index(int userId)
        {
            TempData["userId"] = userId;
            List<RecordHistoryItem> UserEvents = GetRecordHistoryFromDatabase();
            return View(UserEvents);
        }


        public List<RecordHistoryItem> GetRecordHistoryFromDatabase()
        {
            // Здесь просто возвращаем фиктивные данные для тестирования
            var recordHistory = new List<RecordHistoryItem>
    {
        new RecordHistoryItem { RecordId = 1, EventName = "Событие 1", Date = DateTime.Now.AddDays(-2) },
        new RecordHistoryItem { RecordId = 2, EventName = "Событие 2", Date = DateTime.Now.AddDays(-1) },
        new RecordHistoryItem { RecordId = 3, EventName = "Событие 3", Date = DateTime.Now },
          new RecordHistoryItem { RecordId = 3, EventName = "Событие 3", Date = DateTime.Now }
    };

            return recordHistory;
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
