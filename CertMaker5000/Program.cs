using DataContextLibrary;
using Microsoft.Data.SqlClient;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySql.Data.MySqlClient;
using Npgsql;
using CertMaker5000.Screens;
using System.Runtime.InteropServices;
using static Microsoft.WindowsAPICodePack.Shell.PropertySystem.SystemProperties.System;

namespace CertMaker5000
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            

            ApplicationConfiguration.Initialize();


            var DBConfig = MainStartForm.DialogForDatabaseConfig();


            // FOR CREATING MIGRATIONS 
            //var DBConfig = UseSqlServer;
            //var DBConfig = UsePostgresql;
            //var DBConfig = UseSqLite;
            //var DBConfig = UseMySQL;
            

            var host = Host.CreateDefaultBuilder();

            ConfigureServices(host, DBConfig);
            var app = host.Build();

            var mainform = app.Services.GetRequiredService<MainForm>();
            mainform.ShowDialog();



        }

        public static DbContextOptionsBuilder UseMySQL(DbContextOptionsBuilder builder)
        {
            MySqlConnectionStringBuilder csb = new();
            csb.Server = "localhost";
            csb.Port = 3306;
            csb.Database = "test";
            csb.UserID = "admin";
            csb.Password = "password";

            builder.UseMySQL(csb.ConnectionString, x => x.MigrationsAssembly("MigrationsMySQL"));
            return builder;
        }
        public static DbContextOptionsBuilder UseSqlServer(DbContextOptionsBuilder builder)
        {
            SqlConnectionStringBuilder csb = new();
            csb.DataSource = ".";
            csb.InitialCatalog = "test";
            csb.TrustServerCertificate = true;
            
            csb.UserID = "admin";
            csb.Password = "password";
            

            builder.UseSqlServer(csb.ConnectionString, x => x.MigrationsAssembly("MigrationsSqlServer"));
            return builder;
        }

        public static DbContextOptionsBuilder UseSqLite(DbContextOptionsBuilder builder)
        {
            SqliteConnectionStringBuilder csb = new();

            csb.DataSource = @"C:\Users\Owner\Downloads\testsqlite.sqlite";
         
            builder.UseSqlite(csb.ConnectionString, x => x.MigrationsAssembly("MigrationsSqLite"));
            return builder;
        }

        public static DbContextOptionsBuilder UsePostgresql(DbContextOptionsBuilder builder)
        {
            NpgsqlConnectionStringBuilder csb = new();
            csb.Host = "localhost";
            csb.Port = 5432;
            csb.Database = "test";
            csb.Username = "postgres";
            csb.Password = "postgres";

            builder.UseNpgsql(csb.ConnectionString, x => x.MigrationsAssembly("MigrationsPostgresql"));
            return builder;
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