using Microsoft.EntityFrameworkCore.Migrations;

namespace University_Project3_SSMS.Migrations
{
    public partial class seedingInstructor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Name", "PhoneNum" },
                values: new object[] { 1, "Hasan", "0567800800" });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Name", "PhoneNum" },
                values: new object[] { 2, "Ahmed", "0567800008" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instructors",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
