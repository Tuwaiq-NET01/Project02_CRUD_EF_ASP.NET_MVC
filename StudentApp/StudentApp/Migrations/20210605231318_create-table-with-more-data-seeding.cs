using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentApp.Migrations
{
    public partial class createtablewithmoredataseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: ".net");

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Img", "Name" },
                values: new object[] { 2, "https://ensocore.com/media/61/reactjs-logo-sticker%20%281%29.jpg", "React" });

            migrationBuilder.InsertData(
                table: "StudentCourse",
                columns: new[] { "StudentId", "CourseId" },
                values: new object[] { 1, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StudentCourse",
                keyColumns: new[] { "StudentId", "CourseId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Ahmed");
        }
    }
}
