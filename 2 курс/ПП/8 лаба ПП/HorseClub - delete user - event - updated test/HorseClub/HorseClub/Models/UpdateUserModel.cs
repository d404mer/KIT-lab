using System.ComponentModel.DataAnnotations;

namespace HorseClub.Models
{
    public class UpdateUserModel
    {
        public string new_USER_name { get; set; } = null!;

        public string new_USER_surname { get; set; } = null!;

        public string new_USER_email { get; set; } = null!;

        public int new_USER_age { get; set; }
    }

}
