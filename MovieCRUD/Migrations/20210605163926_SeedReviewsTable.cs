using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCRUD.Migrations
{
    public partial class SeedReviewsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "MovieId", "Rating", "UserId" },
                values: new object[,]
                {
                    { 1, "The Best Movie", 399566, 9.2f, 1 },
                    { 2, "Good Movie", 637649, 8.2f, 1 },
                    { 3, "Not Bad", 503736, 6.5f, 1 },
                    { 4, "This is best movie Ever", 578701, 9.8f, 1 },
                    { 5, "Good Movie", 615457, 7.3f, 1 },
                    { 6, "very Bad", 717192, 3.2f, 2 },
                    { 7, "Very Good Movie", 573680, 8.4f, 2 },
                    { 8, "The best Movie Ever Must Watch", 259693, 9.5f, 2 },
                    { 9, "Not Bad", 691179, 6.5f, 2 },
                    { 10, "Good Movie", 726684, 7.3f, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
