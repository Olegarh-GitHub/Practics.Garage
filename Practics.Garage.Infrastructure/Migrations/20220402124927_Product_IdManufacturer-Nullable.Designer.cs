﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Practics.Garage.Infrastructure.Contexts;

namespace Practics.Garage.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20220402124927_Product_IdManufacturer-Nullable")]
    partial class Product_IdManufacturerNullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Practics.Garage.Domain.Models.Manufacturer", b =>
                {
                    b.Property<Guid>("IdGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdGuid");

                    b.ToTable("Manufacturers");
                });

            modelBuilder.Entity("Practics.Garage.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("IdGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("IdManufacturer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdGuid");

                    b.HasIndex("IdManufacturer");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Practics.Garage.Domain.Models.Specification", b =>
                {
                    b.Property<Guid>("IdGuid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<Guid>("IdProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGuid");

                    b.HasIndex("IdProduct");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("Practics.Garage.Domain.Models.Product", b =>
                {
                    b.HasOne("Practics.Garage.Domain.Models.Manufacturer", "Manufacturer")
                        .WithMany("Products")
                        .HasForeignKey("IdManufacturer");

                    b.Navigation("Manufacturer");
                });

            modelBuilder.Entity("Practics.Garage.Domain.Models.Specification", b =>
                {
                    b.HasOne("Practics.Garage.Domain.Models.Product", "Product")
                        .WithMany("Specifications")
                        .HasForeignKey("IdProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Practics.Garage.Domain.Models.Manufacturer", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Practics.Garage.Domain.Models.Product", b =>
                {
                    b.Navigation("Specifications");
                });
#pragma warning restore 612, 618
        }
    }
}
