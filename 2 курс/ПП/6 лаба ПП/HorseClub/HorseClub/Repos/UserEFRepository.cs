using HorseClub.Models;
using Microsoft.EntityFrameworkCore;

namespace HorseClub.Repos
{
    public class UserEFRepository
    {
        public static User now_user { get; set; }   
        public class UserRepositoriesImpl
        {
            public static User now_user { get; set; }
        }
        private readonly PpHorseClubDbContext PpHorseClubDbContext;
        public UserEFRepository(PpHorseClubDbContext context)
        {
            PpHorseClubDbContext = context;
        }

        public void SaveUser(User user)
        {
            PpHorseClubDbContext.Add(user);
            PpHorseClubDbContext.SaveChanges();
        }

        public void UpdateUserProfile(User user)
        {
            PpHorseClubDbContext.Users.Update(user);
            PpHorseClubDbContext.SaveChanges();
        }

        public void DeleteUserProfile(int USER_email)
        {
            var user = PpHorseClubDbContext.Users.Find(USER_email);
            if (user != null)
            {
                PpHorseClubDbContext.Users.Remove(user);
                PpHorseClubDbContext.SaveChanges();
            }
        }


    }
}

