using Microsoft.EntityFrameworkCore.Migrations;

namespace third_project_.Migrations
{
    public partial class CreateQuotationModelUpdateTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "Quotations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Quotations",
                table: "Quotations",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Quotations",
                table: "Quotations");

            migrationBuilder.RenameTable(
                name: "Quotations",
                newName: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");
        }
    }
}
