using HorseClub.Models;
using HorseClub.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HorseClub.Controllers
{
    public class UpdateUserController : Controller
    {
        private readonly PpHorseClubDbContext PpHorseClubDbContext;
        public UpdateUserController(PpHorseClubDbContext context)
        {
            PpHorseClubDbContext = context;
        }

        public IActionResult UserUpdateindex(int userId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserUpdate(UpdateUserModel model)
        {
            if (TempData["userId"] is int userId)
            {

                    ViewData["userId"] = userId;
                //UpdateUserModel model = new UpdateUserModel();
                ReposImpl repo = new ReposImpl(PpHorseClubDbContext);
                User userToUpdate = repo.GetUserById(userId);

                UpdateUserModel new_model = new UpdateUserModel
                {
                    new_USER_age = model.new_USER_age,
                    //new_USER_email = model.new_USER_email,
                    new_USER_name = model.new_USER_name,
                    new_USER_surname = model.new_USER_surname,
                };

                if (userToUpdate != null) 
                {
                    userToUpdate.USER_name = new_model.new_USER_name;
                    userToUpdate.USER_surname = new_model.new_USER_surname;
                    //userToUpdate.USER_email = new_model.new_USER_email;
                    userToUpdate.USER_age = new_model.new_USER_age;

                }
                PpHorseClubDbContext.SaveChanges();
                return RedirectToAction("Index", "Card", new { userId = userToUpdate.USER_ID });
            }

            return NotFound();
        }
    }
}
