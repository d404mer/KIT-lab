using HorseClub.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;



namespace HorseClub.Controllers
{
    public class CardController : Controller
    {
        private readonly PpHorseClubDbContext PpHorseClubDbContext;
        public CardController(PpHorseClubDbContext context)
        {
            PpHorseClubDbContext = context;
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
