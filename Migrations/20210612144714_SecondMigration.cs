using Microsoft.EntityFrameworkCore.Migrations;

namespace Project03_CRUD_With_ASP.NET_MVC.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Categories",
                table: "TodoItems");

            migrationBuilder.AddColumn<bool>(
                name: "How",
                table: "TodoItems",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "What",
                table: "TodoItems",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "When",
                table: "TodoItems",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Where",
                table: "TodoItems",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Why",
                table: "TodoItems",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "How",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "What",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "When",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Where",
                table: "TodoItems");

            migrationBuilder.DropColumn(
                name: "Why",
                table: "TodoItems");

            migrationBuilder.AddColumn<int>(
                name: "Categories",
                table: "TodoItems",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
