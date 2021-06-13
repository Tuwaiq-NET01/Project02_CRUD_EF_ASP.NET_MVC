using Microsoft.EntityFrameworkCore.Migrations;

namespace Hakam.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes");

            migrationBuilder.RenameTable(
                name: "Quotes",
                newName: "Qoutes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qoutes",
                table: "Qoutes",
                column: "Quote_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Qoutes",
                table: "Qoutes");

            migrationBuilder.RenameTable(
                name: "Qoutes",
                newName: "Quotes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes",
                column: "Quote_ID");
        }
    }
}
