using HorseClub.Models;
using Microsoft.AspNetCore.Mvc;
using HorseClub.Repositories;



namespace HorseClub.Controllers
{
    public class CardController : Controller
    {
        private readonly PpHorseClubDbContext PpHorseClubDbContext;
        public CardController(PpHorseClubDbContext context)
        {
            PpHorseClubDbContext = context;
        }


        public IActionResult Index(int userId)
        {

            ReposImpl repo = new ReposImpl(PpHorseClubDbContext);
            User user = repo.GetUserById(userId);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        [HttpPost]
        public IActionResult DeleteUser()
        {
            if (TempData["userId"] is int userId)
            {
                ViewData["userId"] = userId;

                var CurrUserId = PpHorseClubDbContext.Users.Find(userId);

                PpHorseClubDbContext.Remove(CurrUserId);
                PpHorseClubDbContext.SaveChanges();
                return RedirectToAction("Index", "Home");

            }
            return View();


        }

        [HttpPost]
        public IActionResult RedirectToUpdateUser()
        {
            if (TempData["userId"] is int userId)
            {
                ViewData["userId"] = userId;

                User UserToUpdate = PpHorseClubDbContext.Users.Find(userId);


                return RedirectToAction("UserUpdateIndex", "UpdateUser", new { userId = UserToUpdate.USER_ID });

            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult RedirectToEvents()
        {
            if (TempData["userId"] is int userId)
            {
                ViewData["userId"] = userId;

                User UserToUpdate = PpHorseClubDbContext.Users.Find(userId);


                return RedirectToAction("EventsView", "Events", new { userId = UserToUpdate.USER_ID });

            }
            return NotFound();
        }


        [HttpPost]
        public IActionResult RedirectToHistory()
        {
            if (TempData["userId"] is int userId)
            {
                ViewData["userId"] = userId;

                User UserToUpdate = PpHorseClubDbContext.Users.Find(userId);


                return RedirectToAction("Index", "History", new { userId = UserToUpdate.USER_ID });

            }
            return NotFound();
        }

    }
}
