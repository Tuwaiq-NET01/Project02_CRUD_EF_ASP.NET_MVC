using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3_Hotel.Migrations
{
    public partial class updateall : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Customer_CustomerId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Hotel_HotelId",
                table: "Room");

            migrationBuilder.DropTable(
                name: "Rooms_Reservations");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Room",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reservation",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Customer_CustomerId",
                table: "Reservation",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Hotel_HotelId",
                table: "Room",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reservation_Customer_CustomerId",
                table: "Reservation");

            migrationBuilder.DropForeignKey(
                name: "FK_Room_Hotel_HotelId",
                table: "Room");

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Room",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Reservation",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Rooms_Reservations",
                columns: table => new
                {
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    ReservationNumber = table.Column<int>(type: "int", nullable: false),
                    ReservationNumber1 = table.Column<int>(type: "int", nullable: true),
                    RoomNumber1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms_Reservations", x => new { x.RoomNumber, x.ReservationNumber });
                    table.ForeignKey(
                        name: "FK_Rooms_Reservations_Reservation_ReservationNumber1",
                        column: x => x.ReservationNumber1,
                        principalTable: "Reservation",
                        principalColumn: "ReservationNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Reservations_Room_RoomNumber1",
                        column: x => x.RoomNumber1,
                        principalTable: "Room",
                        principalColumn: "RoomNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Reservations_ReservationNumber1",
                table: "Rooms_Reservations",
                column: "ReservationNumber1");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Reservations_RoomNumber1",
                table: "Rooms_Reservations",
                column: "RoomNumber1");

            migrationBuilder.AddForeignKey(
                name: "FK_Reservation_Customer_CustomerId",
                table: "Reservation",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Room_Hotel_HotelId",
                table: "Room",
                column: "HotelId",
                principalTable: "Hotel",
                principalColumn: "HotelId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
