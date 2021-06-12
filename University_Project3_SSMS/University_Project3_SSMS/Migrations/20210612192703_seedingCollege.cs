using Microsoft.EntityFrameworkCore.Migrations;

namespace University_Project3_SSMS.Migrations
{
    public partial class seedingCollege : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "FCIT" });

            migrationBuilder.InsertData(
                table: "Colleges",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "College of Engineering" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colleges",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
