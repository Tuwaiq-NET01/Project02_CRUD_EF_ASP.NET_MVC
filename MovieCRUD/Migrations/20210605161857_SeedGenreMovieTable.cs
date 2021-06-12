using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCRUD.Migrations
{
    public partial class SeedGenreMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "GenreMovie",
                columns: new[] { "Id", "GenreId", "MovieId" },
                values: new object[,]
                {
                    { 1, 35, 337404 },
                    { 34, 16, 527774 },
                    { 35, 12, 527774 },
                    { 36, 14, 527774 },
                    { 37, 10751, 527774 },
                    { 38, 28, 527774 },
                    { 39, 28, 615457 },
                    { 40, 53, 615457 },
                    { 41, 80, 615457 },
                    { 42, 35, 615457 },
                    { 43, 18, 520763 },
                    { 44, 878, 520763 },
                    { 45, 53, 520763 },
                    { 46, 16, 726684 },
                    { 33, 18, 635302 },
                    { 47, 35, 726684 },
                    { 49, 12, 726684 },
                    { 50, 35, 691179 },
                    { 51, 99, 691179 },
                    { 52, 10770, 691179 },
                    { 53, 27, 259693 },
                    { 54, 9648, 259693 },
                    { 55, 53, 259693 },
                    { 56, 28, 791373 },
                    { 57, 12, 791373 },
                    { 58, 14, 791373 },
                    { 59, 878, 791373 },
                    { 60, 27, 573680 },
                    { 61, 28, 717192 },
                    { 48, 10751, 726684 },
                    { 62, 80, 717192 },
                    { 32, 14, 635302 },
                    { 30, 28, 635302 },
                    { 2, 80, 337404 },
                    { 3, 27, 632357 },
                    { 4, 28, 637649 },
                    { 5, 80, 637649 },
                    { 6, 28, 503736 },
                    { 7, 27, 503736 },
                    { 8, 53, 503736 },
                    { 9, 28, 460465 },
                    { 10, 14, 460465 },
                    { 11, 12, 460465 },
                    { 12, 28, 399566 },
                    { 13, 12, 399566 },
                    { 14, 878, 399566 },
                    { 31, 12, 635302 },
                    { 15, 28, 567189 },
                    { 17, 10752, 567189 },
                    { 18, 53, 578701 },
                    { 19, 18, 578701 },
                    { 20, 28, 578701 },
                    { 21, 9648, 578701 },
                    { 22, 80, 823855 },
                    { 23, 18, 823855 },
                    { 24, 9648, 823855 },
                    { 25, 53, 823855 },
                    { 26, 53, 808023 },
                    { 27, 28, 808023 },
                    { 28, 80, 808023 },
                    { 29, 16, 635302 },
                    { 16, 53, 567189 },
                    { 63, 18, 717192 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 63);
        }
    }
}
