using Microsoft.EntityFrameworkCore.Migrations;

namespace third_project_.Migrations
{
    public partial class AddRelationOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Quotations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Quotations_StudentId",
                table: "Quotations",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotations_Students_StudentId",
                table: "Quotations",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotations_Students_StudentId",
                table: "Quotations");

            migrationBuilder.DropIndex(
                name: "IX_Quotations_StudentId",
                table: "Quotations");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Quotations");
        }
    }
}
