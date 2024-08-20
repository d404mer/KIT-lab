using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HorseClub.Models;

public partial class Event
{
    [Key] public int EventsId { get; set; }

    public string EventsName { get; set; } = null!;

    public string EventsDesc { get; set; } = null!;

    public DateTime EventsSttime { get; set; }

    public DateTime EventsEndtime { get; set; }

    public string EventsPlace { get; set; } = null!;

    public int? FkEventtypeId { get; set; }

    public virtual EventType? FkEventtype { get; set; }

    public virtual ICollection<List> Lists { get; set; } = new List<List>();
}
