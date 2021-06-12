using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryStore.Migrations
{
    public partial class RemoveInsertIntoProductsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Image", "Name", "Price" },
                values: new object[] { 1, "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/170x165/9df78eab33525d08d6e5fb8d27136e95/1/3/132.jpg", "Apple", 1.5f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Image", "Name", "Price" },
                values: new object[] { 2, "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/340x330/9df78eab33525d08d6e5fb8d27136e95/o/r/orange-2.jpg", "Orange", 2.5f });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Image", "Name", "Price" },
                values: new object[] { 3, "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/340x330/9df78eab33525d08d6e5fb8d27136e95/5/0/500_0.jpg", "Banana", 4f });
        }
    }
}
