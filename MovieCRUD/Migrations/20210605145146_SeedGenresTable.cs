using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCRUD.Migrations
{
    public partial class SeedGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 28, "Action" },
                    { 53, "Thriller" },
                    { 10770, "TV Movie" },
                    { 878, "Science Fiction" },
                    { 10749, "Romance" },
                    { 9648, "Mystery" },
                    { 10402, "Music" },
                    { 27, "Horror" },
                    { 10752, "War" },
                    { 36, "History" },
                    { 10751, "Family" },
                    { 18, "Drama" },
                    { 99, "Documentary" },
                    { 80, "Crime" },
                    { 35, "Comedy" },
                    { 16, "Animation" },
                    { 12, "Adventure" },
                    { 14, "Fantasy" },
                    { 37, "Western" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 9648);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 10402);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 10749);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 10751);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 10752);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "id",
                keyValue: 10770);
        }
    }
}
