using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3_Hotel.Migrations
{
    public partial class deleteServiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Service");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Service",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationNumber = table.Column<int>(type: "int", nullable: true),
                    ServiceCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service", x => x.ServiceId);
                    table.ForeignKey(
                        name: "FK_Service_Reservation_ReservationNumber",
                        column: x => x.ReservationNumber,
                        principalTable: "Reservation",
                        principalColumn: "ReservationNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Service_ReservationNumber",
                table: "Service",
                column: "ReservationNumber");
        }
    }
}
