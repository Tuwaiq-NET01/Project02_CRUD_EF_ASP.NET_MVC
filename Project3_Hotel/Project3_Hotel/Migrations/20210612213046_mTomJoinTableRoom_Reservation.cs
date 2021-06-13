using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3_Hotel.Migrations
{
    public partial class mTomJoinTableRoom_Reservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms_Reservations",
                columns: table => new
                {
                    RoomNumber = table.Column<int>(type: "int", nullable: false),
                    ReservationNumber = table.Column<int>(type: "int", nullable: false),
                   /* RoomNumber1 = table.Column<int>(type: "int", nullable: true),
                    ReservationNumber1 = table.Column<int>(type: "int", nullable: true)*/
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms_Reservations", x => new { x.RoomNumber, x.ReservationNumber });
                    table.ForeignKey(
                        name: "FK_Rooms_Reservations_Reservation_ReservationNumber",
                        column: x => x.ReservationNumber,
                        principalTable: "Reservation",
                        principalColumn: "ReservationNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Reservations_Room_RoomNumber",
                        column: x => x.RoomNumber,
                        principalTable: "Room",
                        principalColumn: "RoomNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Reservations_ReservationNumber",
                table: "Rooms_Reservations",
                column: "ReservationNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_Reservations_RoomNumber",
                table: "Rooms_Reservations",
                column: "RoomNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms_Reservations");
        }
    }
}
