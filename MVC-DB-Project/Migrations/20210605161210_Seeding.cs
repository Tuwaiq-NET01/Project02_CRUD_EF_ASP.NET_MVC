using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DB_Project.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "leagues",
                columns: new[] { "Id", "country", "name", "numberOfTeams" },
                values: new object[] { 1, "Saudi Arabia", "League Meshal1", 16 });

            migrationBuilder.InsertData(
                table: "leagues",
                columns: new[] { "Id", "country", "name", "numberOfTeams" },
                values: new object[] { 2, "France", "League Meshal2", 30 });

            migrationBuilder.InsertData(
                table: "leagues",
                columns: new[] { "Id", "country", "name", "numberOfTeams" },
                values: new object[] { 3, "Spain", "League Meshal3", 38 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeagueId", "city", "name", "numberOfPlayers" },
                values: new object[] { 1, 1, "Jeddah", "Team Meshal1", 28 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeagueId", "city", "name", "numberOfPlayers" },
                values: new object[] { 2, 2, "Paris", "Team Meshal2", 30 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "LeagueId", "city", "name", "numberOfPlayers" },
                values: new object[] { 3, 3, "Madrid", "Team Meshal3", 25 });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "LeagueId", "TeamId", "experience", "name", "nationality" },
                values: new object[] { 1, 1, 1, 15, "Coache Meshal1", "KSA" });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "LeagueId", "TeamId", "experience", "name", "nationality" },
                values: new object[] { 2, 2, 2, 4, "Coache Meshal2", "ARG" });

            migrationBuilder.InsertData(
                table: "Coaches",
                columns: new[] { "Id", "LeagueId", "TeamId", "experience", "name", "nationality" },
                values: new object[] { 3, 3, 3, 10, "Coache Meshal3", "USA" });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CoacheId", "LeagueId", "TeamId", "name", "number" },
                values: new object[] { 1, 1, 1, 1, "Meshal", 10 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CoacheId", "LeagueId", "TeamId", "name", "number" },
                values: new object[] { 2, 2, 2, 2, "Meshal2", 7 });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "CoacheId", "LeagueId", "TeamId", "name", "number" },
                values: new object[] { 3, 3, 3, 3, "Meshal3", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Coaches",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "leagues",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "leagues",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "leagues",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
