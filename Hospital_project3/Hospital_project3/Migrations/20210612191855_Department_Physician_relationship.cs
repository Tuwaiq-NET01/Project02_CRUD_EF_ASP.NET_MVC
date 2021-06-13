using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_project3.Migrations
{
    public partial class Department_Physician_relationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PhysicianId",
                table: "Departments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Departments_PhysicianId",
                table: "Departments",
                column: "PhysicianId");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Physicians_PhysicianId",
                table: "Departments",
                column: "PhysicianId",
                principalTable: "Physicians",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Physicians_PhysicianId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_PhysicianId",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "PhysicianId",
                table: "Departments");
        }
    }
}
