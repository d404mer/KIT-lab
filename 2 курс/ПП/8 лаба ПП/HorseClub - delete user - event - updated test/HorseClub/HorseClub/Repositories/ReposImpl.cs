using HorseClub.Models;
using Microsoft.EntityFrameworkCore;


namespace HorseClub.Repositories
{
    public class ReposImpl : IRepos
    {
        private readonly PpHorseClubDbContext PpHorseClubDbContext;
        public ReposImpl(PpHorseClubDbContext context)
        {
            this.PpHorseClubDbContext = context;
        }

        public void AddUser(User user)
        {
            PpHorseClubDbContext.Add(user);
            PpHorseClubDbContext.SaveChanges();
        }


        public void AddList(EVENTPLUSUSER currEvent)
        {
            //PpHorseClubDbContext.EVENTPLUSUSER.Add(currEvent);
            //PpHorseClubDbContext.SaveChanges();
        }

        public User GetUserById(int userId)
        {
                
            return  PpHorseClubDbContext.Users.FirstOrDefault(u => u.USER_ID == userId);

        }

        public Event GetEventById(int eventId)
        {
            return PpHorseClubDbContext.Events.FirstOrDefault(u => u.EVENTS_ID == eventId);
        }

        
    }
}

