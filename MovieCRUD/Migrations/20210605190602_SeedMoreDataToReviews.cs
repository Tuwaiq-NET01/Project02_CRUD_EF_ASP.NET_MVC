using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieCRUD.Migrations
{
    public partial class SeedMoreDataToReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 80, 823855 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 19,
                column: "MovieId",
                value: 823855);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 9648, 823855 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 53, 823855 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 53, 578701 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 23,
                column: "MovieId",
                value: 578701);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 28, 578701 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 9648, 578701 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 16, 726684 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 35, 726684 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 10751, 726684 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 12, 726684 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 28, 615457 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 53, 615457 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 80, 615457 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 35, 615457 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 18, 520763 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 878, 520763 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 53, 520763 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 27, 259693 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 9648, 259693 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 53, 259693 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 35, 691179 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 99, 691179 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 10770, 691179 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 27, 573680 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 57,
                column: "GenreId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 58,
                column: "GenreId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 59,
                column: "GenreId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 878, 791373 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 337404);

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "MovieId", "Rating", "UserId" },
                values: new object[,]
                {
                    { 14, "Good Movie", 615457, 7.1f, 2 },
                    { 11, "Very Good Movie", 337404, 8.5f, 2 },
                    { 13, "Very Good Movie", 259693, 7.3f, 1 },
                    { 12, "Good Movie", 573680, 7.3f, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 53, 578701 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 19,
                column: "MovieId",
                value: 578701);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 28, 578701 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 9648, 578701 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 80, 823855 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 23,
                column: "MovieId",
                value: 823855);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 9648, 823855 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 53, 823855 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 28, 615457 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 53, 615457 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 80, 615457 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 35, 615457 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 18, 520763 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 878, 520763 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 53, 520763 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 16, 726684 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 35, 726684 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 10751, 726684 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 12, 726684 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 35, 691179 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 99, 691179 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 10770, 691179 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 27, 259693 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 9648, 259693 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 53, 259693 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 28, 791373 });

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 57,
                column: "GenreId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 58,
                column: "GenreId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 59,
                column: "GenreId",
                value: 878);

            migrationBuilder.UpdateData(
                table: "GenreMovie",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "GenreId", "MovieId" },
                values: new object[] { 27, 573680 });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "MovieId",
                value: 399566);
        }
    }
}
