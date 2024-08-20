using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HorseClub.Models;

public partial class List
{
    [Key] public int LIST_ID { get; set; }

    public int? FK_USER_ID { get; set; }

    public int? FK_EVENT_ID { get; set; }
}
