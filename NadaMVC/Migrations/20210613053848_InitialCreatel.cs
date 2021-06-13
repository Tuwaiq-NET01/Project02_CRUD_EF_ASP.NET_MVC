using Microsoft.EntityFrameworkCore.Migrations;

namespace NadaMVC.Migrations
{
    public partial class InitialCreatel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "Published", "Title", "image" },
                values: new object[,]
                {
                    { 1, "Roald Dahl", 1982, "The BFG", "https://upload.wikimedia.org/wikipedia/ar/thumb/b/b2/The_BFG_%28Dahl_novel_-_cover_art%29.jpg/227px-The_BFG_%28Dahl_novel_-_cover_art%29.jpg" },
                    { 2, "Jeff Kinney", 2007, "Diary of a Wimpy Kid", "https://upload.wikimedia.org/wikipedia/ar/0/09/Diary_of_a_wimpy_kid.jpg" },
                    { 3, "Antoine De Saint", 2016, "The Little Prince", "https://images-na.ssl-images-amazon.com/images/I/4186P0mACWL._SX336_BO1,204,203,200_.jpg" },
                    { 4, "Markus Zusak", 2016, "The Book Thief", "https://images-na.ssl-images-amazon.com/images/I/41LxDicrz2L._SX334_BO1,204,203,200_.jpg" },
                    { 5, "Gareth Moore", 2014, "Brain Games for Clever Kids", "https://images-na.ssl-images-amazon.com/images/I/51WAKxhIoyL._SX328_BO1,204,203,200_.jpg" },
                    { 7, "Simon", 2021, "Programming", "https://images-na.ssl-images-amazon.com/images/I/71d-G-ihrTL.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "BookId", "Author", "Published", "Title", "image" },
                values: new object[] { 6, "Simon", 2021, "Programming", "https://images-na.ssl-images-amazon.com/images/I/71d-G-ihrTL.jpg" });
        }
    }
}
