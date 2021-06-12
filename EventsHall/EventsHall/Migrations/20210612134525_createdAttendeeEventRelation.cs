using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsHall.Migrations
{
    public partial class createdAttendeeEventRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventId",
                table: "Attendees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_EventId",
                table: "Attendees",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attendees_Events_EventId",
                table: "Attendees",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attendees_Events_EventId",
                table: "Attendees");

            migrationBuilder.DropIndex(
                name: "IX_Attendees_EventId",
                table: "Attendees");

            migrationBuilder.DropColumn(
                name: "EventId",
                table: "Attendees");
        }
    }
}
