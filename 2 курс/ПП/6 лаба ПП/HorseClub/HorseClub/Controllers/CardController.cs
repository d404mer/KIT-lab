using HorseClub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;
using HorseClub.Repos;



namespace HorseClub.Controllers
{
    public class CardController : Controller
    {
        public static UserEFRepository? us;

        private readonly PpHorseClubDbContext PpHorseClubDbContext;
        public CardController(PpHorseClubDbContext context)
        {
            PpHorseClubDbContext = context;
        }

        [HttpPost]
        public IActionResult DeleteProfile(int user_email)
        {
        var CurrentUser = TempData["CurrUser"] as User;
            us.DeleteUserProfile(user_email);
            // Можно добавить дополнительные действия после удаления, например, перенаправление на другую страницу
            return RedirectToAction("Index", "Home");
        }



        public IActionResult Index()
        {
            return View();

        }


      

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < hashedBytes.Length; i++)
                {
                    builder.Append(hashedBytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
    }
}
