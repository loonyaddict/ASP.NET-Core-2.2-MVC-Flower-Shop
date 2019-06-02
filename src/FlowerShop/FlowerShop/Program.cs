using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using FlowerShop.Models;
using System;

namespace FlowerShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Seeding could be as well added in startup, but this way is recommended since Framework 2.0
            // https://docs.microsoft.com/en-us/aspnet/core/migration/1x-to-2x/?view=aspnetcore-2.2#move-database-initialization-code
            var host = CreateWebHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<AppDbContext>();
                    DbInitializer.Seed(context);
                }
                catch (Exception)
                {
                    // TODO: Add Log here.
                }
            }
            host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}