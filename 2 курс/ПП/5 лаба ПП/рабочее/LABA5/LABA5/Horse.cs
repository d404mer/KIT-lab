using System;
using System.Collections.Generic;

namespace LABA5;

public partial class Horse
{
    public int HorseId { get; set; }

    public string? HorseName { get; set; }

    public int? HorseAge { get; set; }

    public int? FkHorseBreedId { get; set; }

    public byte[]? HorseSex { get; set; }

    public int? FkUserId { get; set; }

    public int? FkUserIdHorse { get; set; }

    public virtual Breed? FkHorseBreed { get; set; }

    public virtual User? FkUserIdHorseNavigation { get; set; }
}
