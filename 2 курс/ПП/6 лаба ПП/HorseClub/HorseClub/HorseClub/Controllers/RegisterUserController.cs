using HorseClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Text;
using System.Security.Cryptography;



namespace HorseClub.Controllers

{
    public class RegisterUserController : Controller
    {

        //private readonly PpHorseClubDbContext _context;
        private readonly PpHorseClubDbContext PpHorseClubDbContext;


        public RegisterUserController (PpHorseClubDbContext _context)
        {
            PpHorseClubDbContext = _context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                              
                    string hashedPassword = HashPassword(user.USER_password);
                    User newUser = new User
                    {
                        USER_name = user.USER_name,
                        USER_surname = user.USER_surname,
                        USER_password = hashedPassword,
                        USER_age = user.USER_age,
                        USER_email = user.USER_email
                    };

                if (IsUserExists(user.USER_email) == true)
                {
                    //POPUP
                    TempData["ErrorMessage"] = "Email is already in use";
                    return View(user);
                }
                else
                {
                    ViewBag.FirstName = user.USER_name;
                    ViewBag.LastName = user.USER_surname;


                    // Сохранение нового пользователя в базе данных
                    PpHorseClubDbContext.Users.Add(newUser);
                    PpHorseClubDbContext.SaveChanges();
                    return View("~/Views/Card/Index.cshtml");
                }

                    
                

            }

            return View(user);

                
        }







        public bool IsUserExists(string email)
        {
            bool check = false;

            foreach (User users in PpHorseClubDbContext.Users)
            {
                if (email == users.USER_email)
                {
                    check = true;
                }
            }

            return check;
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
