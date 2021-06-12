using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc_Project2.Migrations
{
    public partial class make2ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaneId",
                table: "passengers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PassengerId",
                table: "Bags",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_passengers_PlaneId",
                table: "passengers",
                column: "PlaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Bags_PassengerId",
                table: "Bags",
                column: "PassengerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bags_passengers_PassengerId",
                table: "Bags",
                column: "PassengerId",
                principalTable: "passengers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_passengers_Planes_PlaneId",
                table: "passengers",
                column: "PlaneId",
                principalTable: "Planes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bags_passengers_PassengerId",
                table: "Bags");

            migrationBuilder.DropForeignKey(
                name: "FK_passengers_Planes_PlaneId",
                table: "passengers");

            migrationBuilder.DropIndex(
                name: "IX_passengers_PlaneId",
                table: "passengers");

            migrationBuilder.DropIndex(
                name: "IX_Bags_PassengerId",
                table: "Bags");

            migrationBuilder.DropColumn(
                name: "PlaneId",
                table: "passengers");

            migrationBuilder.DropColumn(
                name: "PassengerId",
                table: "Bags");
        }
    }
}
