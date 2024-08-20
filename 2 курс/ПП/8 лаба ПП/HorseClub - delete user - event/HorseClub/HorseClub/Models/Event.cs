using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HorseClub.Models;

public partial class Event
{
    [Key] public int EVENTS_ID { get; set; }

    public string EVENTS_name { get; set; } = null!;

    public string EVENTS_desc { get; set; } = null!;

    public DateTime EVENTS_STtime { get; set; }

    public DateTime EVENTS_ENDtime { get; set; }

    public string EVENTS_place { get; set; } = null!;


    public virtual ICollection<List> Lists { get; set; } = new List<List>();
}
