using Microsoft.EntityFrameworkCore.Migrations;

namespace Hakam.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Qoutes",
                table: "Qoutes");

            migrationBuilder.RenameTable(
                name: "Qoutes",
                newName: "Quotes");

            migrationBuilder.RenameColumn(
                name: "Quote_ID",
                table: "Quotes",
                newName: "Qoute_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes",
                column: "Qoute_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quotes",
                table: "Quotes");

            migrationBuilder.RenameTable(
                name: "Quotes",
                newName: "Qoutes");

            migrationBuilder.RenameColumn(
                name: "Qoute_ID",
                table: "Qoutes",
                newName: "Quote_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Qoutes",
                table: "Qoutes",
                column: "Quote_ID");
        }
    }
}
