using Microsoft.EntityFrameworkCore;
using Practics.Garage.Domain.Models;
using Practics.Garage.Domain.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Design;

namespace Practics.Garage.Infrastructure.Contexts
{
    public sealed class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Specification> Specifications { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasKey(entity => entity.IdGuid);
            modelBuilder.Entity<Product>()
                .HasMany(entity => entity.Specifications)
                .WithOne(entity => entity.Product)
                .HasForeignKey(entity => entity.IdProduct);

            modelBuilder.Entity<Manufacturer>().HasKey(entity => entity.IdGuid);
            modelBuilder.Entity<Manufacturer>()                
                .HasMany(entity => entity.Products)
                .WithOne(entity => entity.Manufacturer)
                .HasForeignKey(entity => entity.IdManufacturer);               
            
            modelBuilder.Entity<Specification>().HasKey(entity => entity.IdGuid);

            modelBuilder.Entity<Specification>()               
                .HasOne(entity => entity.Product);
        }
    }
    
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = Garage");

            return new ApplicationContext(optionsBuilder.Options);
        }
    }
}
