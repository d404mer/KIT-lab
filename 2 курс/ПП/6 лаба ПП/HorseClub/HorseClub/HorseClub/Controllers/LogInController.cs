using HorseClub.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text;
using System.Security.Cryptography;

namespace HorseClub.Controllers
{
    public class LogInController : Controller
    {
        private readonly PpHorseClubDbContext PpHorseClubDbContext;
        public LogInController(PpHorseClubDbContext context)
        {
            PpHorseClubDbContext = context;
        }
      
        
        public IActionResult Index()
        {
            return View("~/Views/LogIn/Index.cshtml");
        }

        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            User user = PpHorseClubDbContext.Users.FirstOrDefault(u => u.USER_email == email);

            if (user == null)
            {
                TempData["ErrorMessage"] = "Incorrect login";
                return View();
            }


            if (VerifyPassword(password, user.USER_password) == false)
            {
                TempData["ErrorMessage"] = "Incorrect password";
                return View();
            }

            if (VerifyPassword(password, user.USER_password) == true)
            {
                var firtsname = user.USER_name;
                var lastname = user.USER_surname;

                ViewBag.FirstName = firtsname;
                ViewBag.LastName = lastname;
                return View("~/Views/Card/Index.cshtml");
            }
                return View();
        }










        private bool VerifyPassword(string password, string hashedPassword)
        {
            return HashPassword(password) == hashedPassword;
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
