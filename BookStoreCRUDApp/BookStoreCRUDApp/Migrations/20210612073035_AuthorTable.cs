using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreCRUDApp.Migrations
{
    public partial class AuthorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorModelAuthorID",
                table: "Book_Author",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorFirstName = table.Column<string>(nullable: true),
                    AuthorLastName = table.Column<string>(nullable: true),
                    AuthorEmail = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorID", "AuthorEmail", "AuthorFirstName", "AuthorLastName", "Notes" },
                values: new object[,]
                {
                    { 1, "Andrea@mail.com", "Andrea", "Arbasi", "This author has written great" },
                    { 2, "Jan@mail.com", "Jan", "Wengro", "This author has written great" },
                    { 3, "Pon@mail.com", "Pon", "Pattren", "This author has written great" },
                    { 4, "Alexander@mail.com", " Alexander", "Jony", "This author has written great" },
                    { 5, "Mikel@mail.com", "Mikel", "Jon", "This author has written great" },
                    { 6, "Murray@mail.com", " Murray", "Silverstein", "This author has written great" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Author_AuthorModelAuthorID",
                table: "Book_Author",
                column: "AuthorModelAuthorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Author_Authors_AuthorModelAuthorID",
                table: "Book_Author",
                column: "AuthorModelAuthorID",
                principalTable: "Authors",
                principalColumn: "AuthorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Author_Authors_AuthorModelAuthorID",
                table: "Book_Author");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Book_Author_AuthorModelAuthorID",
                table: "Book_Author");

            migrationBuilder.DropColumn(
                name: "AuthorModelAuthorID",
                table: "Book_Author");
        }
    }
}
