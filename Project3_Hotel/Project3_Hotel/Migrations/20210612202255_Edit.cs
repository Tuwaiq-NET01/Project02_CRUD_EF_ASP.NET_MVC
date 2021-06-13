using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3_Hotel.Migrations
{
    public partial class Edit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_Reservation_ReservationNumber1",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_ReservationNumber1",
                table: "Service");

            migrationBuilder.DropColumn(
                name: "ReservationNumber1",
                table: "Service");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationNumber",
                table: "Service",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Service_ReservationNumber",
                table: "Service",
                column: "ReservationNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Service_Reservation_ReservationNumber",
                table: "Service",
                column: "ReservationNumber",
                principalTable: "Reservation",
                principalColumn: "ReservationNumber",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Service_Reservation_ReservationNumber",
                table: "Service");

            migrationBuilder.DropIndex(
                name: "IX_Service_ReservationNumber",
                table: "Service");

            migrationBuilder.AlterColumn<int>(
                name: "ReservationNumber",
                table: "Service",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
    }
}
