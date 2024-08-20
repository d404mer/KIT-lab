using System;
using System.Collections.Generic;
using Azure.Identity;
using HorseClub.Models;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.EntityFrameworkCore;

namespace HorseClub;

public partial class PpHorseClubDbContext : DbContext
{
    public PpHorseClubDbContext()
    {
    }

    public PpHorseClubDbContext(DbContextOptions<PpHorseClubDbContext> options)
        : base(options)
    {

    }
   

    public virtual DbSet<User> Users { get; set; }


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
