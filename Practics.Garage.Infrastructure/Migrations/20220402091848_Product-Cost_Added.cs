using Microsoft.EntityFrameworkCore.Migrations;

namespace Practics.Garage.Infrastructure.Migrations
{
    public partial class ProductCost_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>("Cost", "Products", "decimal(18,2)", nullable: false, defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Cost", "Products");
        }
    }
}
