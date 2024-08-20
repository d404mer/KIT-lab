using HorseClub.Models;

namespace HorseClub.Repos
{
    public interface IUserRepository
    {
        void SaveUser(User user);
        void UpdateUserProfile(User user);
        void DeleteUserProfile(int userId);
    }
}
