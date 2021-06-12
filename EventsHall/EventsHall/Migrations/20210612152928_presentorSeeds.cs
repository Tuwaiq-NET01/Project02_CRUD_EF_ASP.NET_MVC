using Microsoft.EntityFrameworkCore.Migrations;

namespace EventsHall.Migrations
{
    public partial class presentorSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Presentors",
                columns: new[] { "Id", "Email", "Field", "Name", "Phone" },
                values: new object[,]
                {
                    { 10, "spurofthemoment@gmail.com", "IT", "Sameera Alhussainy", 556110112 },
                    { 2, "ceo@tesla.com", "Business", "Elon Musk", 556123123 },
                    { 665, "mj@gmail.com", "Health", "Michael Jackson", 522666987 },
                    { 1, "steven@galaxybrain.com", "Science", "Steven Hawking", 598644222 },
                    { 100, "hala@galaxybrain.com", "Bullshit", "Hala Alyousef", 522441234 },
                    { 333, "reema@galaxybrain.com", "Divine Philosophy", "Reema Alyousef", 547722199 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Presentors",
                keyColumn: "Id",
                keyValue: 665);
        }
    }
}
