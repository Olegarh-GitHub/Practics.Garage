﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Practics.Garage.Infrastructure.Migrations
{
    public partial class Product_IdManufacturerNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_IdManufacturer",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdManufacturer",
                table: "Products",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_IdManufacturer",
                table: "Products",
                column: "IdManufacturer",
                principalTable: "Manufacturers",
                principalColumn: "IdGuid",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Manufacturers_IdManufacturer",
                table: "Products");

            migrationBuilder.AlterColumn<Guid>(
                name: "IdManufacturer",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Manufacturers_IdManufacturer",
                table: "Products",
                column: "IdManufacturer",
                principalTable: "Manufacturers",
                principalColumn: "IdGuid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
