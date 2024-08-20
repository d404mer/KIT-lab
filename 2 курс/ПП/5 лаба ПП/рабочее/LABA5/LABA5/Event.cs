using System;
using System.Collections.Generic;

namespace LABA5;

public partial class Event
{
    public int EventsId { get; set; }

    public string? EventsName { get; set; }

    public string? EventsDesc { get; set; }

    public DateTime? EventsSttime { get; set; }

    public DateTime? EventsEndtime { get; set; }

    public string? EventsPlace { get; set; }

    public int? FkEventtypeId { get; set; }

    public virtual EventType? FkEventtype { get; set; }

    public virtual ICollection<List> Lists { get; set; } = new List<List>();
}
