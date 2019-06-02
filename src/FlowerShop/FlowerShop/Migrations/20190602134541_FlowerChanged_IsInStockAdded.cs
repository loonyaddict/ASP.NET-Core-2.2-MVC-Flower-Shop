using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowerShop.Migrations
{
    public partial class FlowerChanged_IsInStockAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsInStock",
                table: "Flowers",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsInStock",
                table: "Flowers");
        }
    }
}
