extern alias App;

using App::Practics.Garage.Application.Facades;
using App::Practics.Garage.Application.Facades.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Practics.Garage.Domain.Models;
using Practics.Garage.Domain.Repository.Base;
using Practics.Garage.Forms;
using Practics.Garage.Infrastructure.Contexts;
using Practics.Garage.Infrastructure.Repositories.Base;
using System;
using System.Windows.Forms;

namespace Practics.Garage
{
    static class Program
    {
        private static readonly string _connectionString = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Garage";
        public static IServiceProvider ServiceProvider { get; set; }

        public static void ConfigureServices()
        {
            var services = new ServiceCollection();

            services.AddDbContext<Infrastructure.Contexts.ApplicationContext>
            (
                options => options.UseSqlServer(_connectionString), 
                ServiceLifetime.Transient
            );

            services.AddTransient<IRepository<Product>, Repository<Product>>();
            services.AddTransient<IRepository<Manufacturer>, Repository<Manufacturer>>();
            services.AddTransient<IRepository<Specification>, Repository<Specification>>();

            services.AddTransient<ManufacturerFacade>();
            services.AddTransient<ProductFacade>();

            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConfigureServices();

            Application.Run
            (
                new CatalogForm
                (
                    ServiceProvider.GetRequiredService<ManufacturerFacade>(), 
                    ServiceProvider.GetRequiredService<ProductFacade>()
                )
            );
        }
    }
}
