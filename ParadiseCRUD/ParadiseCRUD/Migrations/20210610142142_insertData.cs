using Microsoft.EntityFrameworkCore.Migrations;

namespace ParadiseCRUD.Migrations
{
    public partial class insertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Flowers",
                columns: new[] { "ID", "Image", "LevelCare", "Name", "Place", "Size", "Tempreture" },
                values: new object[] { 1, "https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/pink-dahlias-royalty-free-image-513204805-1562778270.jpg?crop=0.445xw:1.00xh;0.450xw,0&resize=980:*", "Easy", "Dahlias", "indoors", "6 to 8 inches", "20°–22°C" });

            migrationBuilder.InsertData(
                table: "Plants",
                columns: new[] { "ID", "Image", "LevelCare", "Name", "Place", "Size", "Tempreture" },
                values: new object[] { 1, "https://images.unsplash.com/photo-1598880940080-ff9a29891b85?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1yZWxhdGVkfDF8fHxlbnwwfHx8fA%3D%3D&auto=format&fit=crop&w=700&q=60", "Easy", "Pothos", "indoors", "12 inches", "15°-29°C" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Flowers",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Plants",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
