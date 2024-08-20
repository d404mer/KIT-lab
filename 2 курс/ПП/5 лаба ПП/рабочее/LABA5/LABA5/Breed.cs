using System;
using System.Collections.Generic;

namespace LABA5;

public partial class Breed
{
    public int BreedId { get; set; }

    public string? BreedName { get; set; }

    public virtual ICollection<Horse> Horses { get; set; } = new List<Horse>();
}
