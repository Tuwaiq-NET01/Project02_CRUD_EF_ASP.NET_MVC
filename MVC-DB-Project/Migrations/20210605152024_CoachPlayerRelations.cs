using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC_DB_Project.Migrations
{
    public partial class CoachPlayerRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoacheId",
                table: "Players",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Players_CoacheId",
                table: "Players",
                column: "CoacheId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Coaches_CoacheId",
                table: "Players",
                column: "CoacheId",
                principalTable: "Coaches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Coaches_CoacheId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_CoacheId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "CoacheId",
                table: "Players");
        }
    }
}
