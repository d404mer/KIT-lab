using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace HorseClub
{
    public class Program
    {
        public static void Main(string[] args)
        {
            

            var builder = WebApplication.CreateBuilder(args);

            var connectionString = "Server=DESKTOP-AF0FDGA;Database=PP_HorseClubDb;Integrated Security=true;TrustServerCertificate=True;";
            var optionsBuilder = new DbContextOptionsBuilder<PpHorseClubDbContext>();
            optionsBuilder.UseSqlServer(connectionString);



            builder.Services.AddDbContext<PpHorseClubDbContext>(options => options.UseSqlServer(connectionString));

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // добавляем контекст ApplicationContext в качестве сервиса в приложение

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            app.Run();
        }


    }
}
