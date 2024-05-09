using CertMaker5000.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Runtime.InteropServices;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

namespace CertMaker5000
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            ApplicationConfiguration.Initialize();
            //Application.Run(new MainForm());
            //Application.Run(new MainStartForm());
            var DBConfig = MainStartForm.DialogForDatabaseConfig();


            var host = Host.CreateDefaultBuilder();

            ConfigureServices(host, DBConfig);
            var app = host.Build();

            var mainform = app.Services.GetRequiredService<MainForm>();


            //Application.Run(ServiceProvider.GetRequiredService<MainForm>());
            //Application.Run(ServiceProvider.GetService<MainStartForm>());


        }


        static void ConfigureServices(IHostBuilder builder, Func<DbContextOptionsBuilder, DbContextOptionsBuilder> dbbuilder)
        {
            builder.ConfigureServices((context, services) =>
            {
                //new DbContext<DataContext>(dbconfig)
                services.AddDbContext<DataContext>(spbuilder =>
                    dbbuilder(spbuilder)
                );
                services.AddTransient<MainForm>();
            });
        }
    }
}