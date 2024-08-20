using HorseClub.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Text;
using System.Security.Cryptography;
using HorseClub.Repositories;
using HorseClub.DTO;



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
        public IActionResult Index(RegisterUserDTO userDto)
        {
            if (ModelState.IsValid)
            {
                              
                    string hashedPassword = HashPassword(userDto.USER_password);
                    User newUser = new User
                    {
                        USER_name = userDto.USER_name,
                        USER_surname = userDto.USER_surname,
                        USER_password = hashedPassword,
                        USER_age = userDto.USER_age,
                        USER_email = userDto.USER_email
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

                    int userId = newUser.USER_ID;
                    TempData["userId"] = userId;
                    return RedirectToAction("Index", "Card", new { userId = newUser.USER_ID });
                }

                    
                

            }

            return View(userDto);

                
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
