using Microsoft.EntityFrameworkCore;
using Practics.Garage.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practics.Garage.Infrastructure.Contexts
{
    public sealed class ApplicationContext : DbContext
    {
        private string _connectionString => "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Garage";
        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Specification> Specifications { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(_connectionString);
    }
}
