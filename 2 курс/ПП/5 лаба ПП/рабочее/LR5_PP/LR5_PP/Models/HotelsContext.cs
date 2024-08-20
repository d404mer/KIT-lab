using Microsoft.EntityFrameworkCore;
namespace LR5_PP.Models;


    public class HotelsContext : DbContext
    {
    public DbSet<Hotel> Hotels { get; set; }
    public HotelsContext (DbContextOptions<HotelsContext> options) : base(options) {
        Database.EnsureCreated();

    }
}
