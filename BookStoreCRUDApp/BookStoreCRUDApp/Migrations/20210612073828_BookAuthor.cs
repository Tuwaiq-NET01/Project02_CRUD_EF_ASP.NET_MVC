using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreCRUDApp.Migrations
{
    public partial class BookAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "BAId", "AuthorID", "AuthorModelAuthorID", "BookID", "BookModelBookID" },
                values: new object[] { 1, 1, null, 1, null });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "BAId", "AuthorID", "AuthorModelAuthorID", "BookID", "BookModelBookID" },
                values: new object[] { 2, 2, null, 2, null });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "BAId", "AuthorID", "AuthorModelAuthorID", "BookID", "BookModelBookID" },
                values: new object[] { 3, 3, null, 1, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "BAId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "BAId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookAuthor",
                keyColumn: "BAId",
                keyValue: 3);
        }
    }
}
