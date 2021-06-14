using Microsoft.EntityFrameworkCore.Migrations;

namespace third_project_.Migrations
{
    public partial class updateQuotationCoulmn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Quotations");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Quotations",
                type: "varchar(250)",
                maxLength: 250,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Message",
                table: "Quotations");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Quotations",
                type: "text",
                nullable: true);
        }
    }
}
