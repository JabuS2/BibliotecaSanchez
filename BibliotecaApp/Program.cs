using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using BibliotecaApp.Data;
using BibliotecaApp.Services;
using System;
using System.IO;
using System.Windows.Forms;

namespace BibliotecaApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                try
                {
                    var context = services.GetRequiredService<BibliotecaContext>();
                    context.Database.Migrate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro ao migrar o banco de dados: {ex.Message}");
                }
            }

            ApplicationConfiguration.Initialize();
            var form1 = host.Services.GetRequiredService<Form1>();
            Application.Run(form1);
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.SetBasePath(Directory.GetCurrentDirectory());
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureServices((context, services) =>
                {
                    var environment = context.Configuration.GetSection("AppSettings:Environment").Value;

                    if (environment == "Production")
                    {
                        var prodConnectionString = context.Configuration.GetConnectionString("BibliotecaConnectionStringProd");
                        services.AddDbContext<BibliotecaContext>(options =>
                            options.UseSqlServer(prodConnectionString));
                    }
                    else
                    {
                        var devConnectionString = context.Configuration.GetConnectionString("BibliotecaConnectionStringDev");
                        services.AddDbContext<BibliotecaContext>(options =>
                            options.UseNpgsql(devConnectionString));
                    }

                    services.AddTransient<LivroService>();
                    services.AddTransient<AutorService>();
                    services.AddTransient<Form1>();
                });
    }
}
