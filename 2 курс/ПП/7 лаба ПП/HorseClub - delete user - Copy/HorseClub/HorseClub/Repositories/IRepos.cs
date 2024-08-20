using HorseClub.Models;

namespace HorseClub.Repositories
{
    public interface IRepos
    {
        User GetUserById(int userId);
        void AddUser(User user);

        //public void DeleteUser(int userId);
    }
}
