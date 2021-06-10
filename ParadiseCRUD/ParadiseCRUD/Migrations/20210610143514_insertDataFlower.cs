using Microsoft.EntityFrameworkCore.Migrations;

namespace ParadiseCRUD.Migrations
{
    public partial class insertDataFlower : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flowers",
                columns: new[] { "ID", "Image", "LevelCare", "Name", "Place", "Size", "Tempreture" },
                values: new object[] { 2, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/cornflowers-royalty-free-image-104696040-1562778695.jpg?crop=0.445xw:1.00xh;0.386xw,0&resize=980:*", "Easy", "Cornflower", "outdoors", "6 to 9 inches", "15°-26°C" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flowers",
                keyColumn: "ID",
                keyValue: 2);
        }
    }
}
