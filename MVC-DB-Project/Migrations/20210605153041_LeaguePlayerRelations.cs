using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DB_Project.Migrations
{
    public partial class LeaguePlayerRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Players_LeagueId",
                table: "Players",
                column: "LeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_leagues_LeagueId",
                table: "Players",
                column: "LeagueId",
                principalTable: "leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_leagues_LeagueId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_LeagueId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "Players");
        }
    }
}
