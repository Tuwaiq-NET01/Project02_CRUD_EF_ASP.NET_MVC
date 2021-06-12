using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryStore.Migrations
{
    public partial class InsertIntoProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Price",
                value: 4f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "Price",
                value: 3.5f);
        }
    }
}
