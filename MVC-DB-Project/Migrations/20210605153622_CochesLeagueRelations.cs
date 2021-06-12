using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DB_Project.Migrations
{
    public partial class CochesLeagueRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "Coaches",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Coaches_LeagueId",
                table: "Coaches",
                column: "LeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Coaches_leagues_LeagueId",
                table: "Coaches",
                column: "LeagueId",
                principalTable: "leagues",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Coaches_leagues_LeagueId",
                table: "Coaches");

            migrationBuilder.DropIndex(
                name: "IX_Coaches_LeagueId",
                table: "Coaches");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "Coaches");
        }
    }
}
