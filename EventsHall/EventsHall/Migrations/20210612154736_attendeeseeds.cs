using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsHall.Migrations
{
    public partial class attendeeseeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Attendees",
                columns: new[] { "Id", "Email", "EventId", "Field", "Name", "Phone" },
                values: new object[] { 13, "reema@gmail.com", 1000, "IT", "Reema Alyousef", 547722199 });

            migrationBuilder.InsertData(
                table: "Attendees",
                columns: new[] { "Id", "Email", "EventId", "Field", "Name", "Phone" },
                values: new object[] { 7, "hala@gmail.com", 111111, "Business", "Hala Alyousef", 554124771 });

            migrationBuilder.InsertData(
                table: "Attendees",
                columns: new[] { "Id", "Email", "EventId", "Field", "Name", "Phone" },
                values: new object[] { 4, "durrdurr@gmail.com", 111111, "Marketing", "Dorrah Alsaad", 532121731 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Attendees",
                keyColumn: "Id",
                keyValue: 13);
        }
    }
}
