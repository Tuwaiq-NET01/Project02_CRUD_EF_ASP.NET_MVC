using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCRUD.Migrations
{
    public partial class SeedUsersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ProfilePic", "UserName" },
                values: new object[] { 1, "http://farmersca.com/wp-content/uploads/2016/07/default-profile.png", "Abdullah" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "ProfilePic", "UserName" },
                values: new object[] { 2, "http://farmersca.com/wp-content/uploads/2016/07/default-profile.png", "Mohammed" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
