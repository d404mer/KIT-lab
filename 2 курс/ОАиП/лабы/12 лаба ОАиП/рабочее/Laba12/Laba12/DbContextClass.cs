using Laba12;
using login_system;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppDbContext : DbContext
{
    private const string ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=LibraryDb;Integrated Security=True;";

    public DbSet<User> Users { get; set; }
    public DbSet<DepartamentClass> Departaments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DepartamentClass>()
            .HasMany(u => u.Users)
            .WithOne(b => b.Departament)
            .HasForeignKey(b => b.UserID);
    }


}
