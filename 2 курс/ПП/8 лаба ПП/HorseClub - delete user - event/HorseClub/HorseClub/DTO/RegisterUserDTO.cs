using System.ComponentModel.DataAnnotations;

namespace HorseClub.DTO
{
    public class RegisterUserDTO
    {
        public string USER_name { get; set; } = null!;

        public string USER_surname { get; set; } = null!;

        public string USER_email { get; set; } = null!;

        public int USER_age { get; set; }

        public string USER_password { get; set; } = null!;
    }
}
