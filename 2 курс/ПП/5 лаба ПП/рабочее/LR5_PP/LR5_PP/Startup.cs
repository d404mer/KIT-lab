namespace LR5_PP;

using LR5_PP.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        services.AddDbContext<HotelsContext>(options => options.UseSqlServer(SqlConnectionIntegratedSecurity));
        services.AddControllers(); // используем контроллеры без представлений
        }

    public static string SqlConnectionIntegratedSecurity
    {
        get
        {
            var sb = new SqlConnectionStringBuilder
            {
                DataSource = "",
                IntegratedSecurity = true,
                InitialCatalog = "SKACHKIDB"

            };
            return sb.ConnectionString;
        }
    }

    public void Configure(IApplicationBuilder app)
        {
        app.UseDefaultFiles();
        app.UseStaticFiles();
        app.UseDeveloperExceptionPage();
        app.UseRouting();
        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers(); // подключаем маршрутизацию на контроллеры
        });

    }

    }

