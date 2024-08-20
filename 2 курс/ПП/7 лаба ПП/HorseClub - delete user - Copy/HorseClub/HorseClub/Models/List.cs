using System;
using System.Collections.Generic;

namespace HorseClub.Models;

public partial class List
{
    public int ListId { get; set; }

    public int? FkUserId { get; set; }

    public int? FkEventId { get; set; }

    public virtual Event? FkEvent { get; set; }

    public virtual User? FkUser { get; set; }
}
