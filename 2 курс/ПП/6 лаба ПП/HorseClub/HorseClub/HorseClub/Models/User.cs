using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HorseClub.Models;

public partial class User
{

    [Key] public int USER_ID { get; set; }

    public string USER_name { get; set; } = null!;

    public string USER_surname { get; set; } = null!;

    public string USER_email { get; set; } = null!;

    public int USER_age { get; set; }

    public string USER_password { get; set; } = null!;

    public virtual ICollection<List> Lists { get; set; } = new List<List>();
}
