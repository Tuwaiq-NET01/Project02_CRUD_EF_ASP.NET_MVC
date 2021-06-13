using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3_Hotel.Migrations
{
    public partial class AddoneToManyReservationService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ReservationNumber",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ReservationNumber1",
                table: "Service",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Service_ReservationNumber1",
                table: "Service",
                column: "ReservationNumber1");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Reservation_ReservationNumber1",
                table: "Service",
                column: "ReservationNumber1",
                principalTable: "Reservation",
                principalColumn: "ReservationNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_Reservation_ReservationNumber1",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_ReservationNumber1",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ReservationNumber",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ReservationNumber1",
                table: "Service");
        }
    }
}
