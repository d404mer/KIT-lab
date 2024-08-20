using System;
using System.Collections.Generic;

namespace LABA5;

public partial class EventType
{
    public int EventtypeId { get; set; }

    public string? EventtypeName { get; set; }

    public string? EventtypeDesc { get; set; }

    public virtual ICollection<Event> Events { get; set; } = new List<Event>();
}
