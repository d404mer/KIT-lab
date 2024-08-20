using System;
using System.Collections.Generic;

namespace LABA5;

public partial class User
{
    public int UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserSurname { get; set; }

    public string? UserEmail { get; set; }

    public string? UserPhone { get; set; }

    public int? UserAge { get; set; }

    public string? UserLogin { get; set; }

    public string? UserPassword { get; set; }

    public int? FkStatusId { get; set; }

    public virtual Status? FkStatus { get; set; }

    public virtual ICollection<Horse> Horses { get; set; } = new List<Horse>();

    public virtual ICollection<List> Lists { get; set; } = new List<List>();
}
