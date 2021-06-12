using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreCRUDApp.Migrations
{
    public partial class BookAuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_Authors_AuthorModelAuthorID",
                table: "Book_Author");

            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_Books_BookModelBookID",
                table: "Book_Author");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book_Author",
                table: "Book_Author");

            migrationBuilder.RenameTable(
                name: "Book_Author",
                newName: "BookAuthor");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Author_BookModelBookID",
                table: "BookAuthor",
                newName: "IX_BookAuthor_BookModelBookID");

            migrationBuilder.RenameIndex(
                name: "IX_Book_Author_AuthorModelAuthorID",
                table: "BookAuthor",
                newName: "IX_BookAuthor_AuthorModelAuthorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor",
                column: "BAId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Authors_AuthorModelAuthorID",
                table: "BookAuthor",
                column: "AuthorModelAuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BookAuthor_Books_BookModelBookID",
                table: "BookAuthor",
                column: "BookModelBookID",
                principalTable: "Books",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Authors_AuthorModelAuthorID",
                table: "BookAuthor");

            migrationBuilder.DropForeignKey(
                name: "FK_BookAuthor_Books_BookModelBookID",
                table: "BookAuthor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookAuthor",
                table: "BookAuthor");

            migrationBuilder.RenameTable(
                name: "BookAuthor",
                newName: "Book_Author");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthor_BookModelBookID",
                table: "Book_Author",
                newName: "IX_Book_Author_BookModelBookID");

            migrationBuilder.RenameIndex(
                name: "IX_BookAuthor_AuthorModelAuthorID",
                table: "Book_Author",
                newName: "IX_Book_Author_AuthorModelAuthorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book_Author",
                table: "Book_Author",
                column: "BAId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_Authors_AuthorModelAuthorID",
                table: "Book_Author",
                column: "AuthorModelAuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_Books_BookModelBookID",
                table: "Book_Author",
                column: "BookModelBookID",
                principalTable: "Books",
                principalColumn: "BookID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
