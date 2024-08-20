using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

    public DbSet<Event> Events { get; set; }

    public DbSet<List> EVENTPLUSUSER { get; set; }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
