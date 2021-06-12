using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace University_Project3_SSMS.Migrations
{
    public partial class seedingStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CollegeId", "DateOfBirth", "InstructorId", "Major", "Name", "PhoneNum" },
                values: new object[] { 1, 1, new DateTime(1991, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "IS", "Hussain Abdullah Alghamdi", "0567800818" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "CollegeId", "DateOfBirth", "InstructorId", "Major", "Name", "PhoneNum" },
                values: new object[] { 2, 1, new DateTime(1995, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "CS", "Thamer Saleh AlMthni", "0551609938" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
