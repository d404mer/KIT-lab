using HorseClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Text;
using System.Security.Cryptography;
using HorseClub.Repositories;



namespace HorseClub.Controllers

{
    public class RegisterUserController : Controller
    {

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

                if (IsUserExists(newUser.USER_email) == true)
                {
                    //POPUP
                    TempData["ErrorMessage"] = "Email is already in use";
                    return View(newUser);
                }
                else
                {

                    ReposImpl repo = new ReposImpl(PpHorseClubDbContext);


                    repo.AddUser(newUser);

                    //User currUser = repo.GetUserById(newUser);
                    //int userId = currUser.USER_ID;
                    //TempData["userId"] = userId;
                    return RedirectToAction("Index", "Card", new { userId = newUser.USER_ID });
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
