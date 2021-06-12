using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreCRUDApp.Migrations
{
    public partial class BookTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Price = table.Column<float>(nullable: false),
                    NoPage = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    IdBookStore = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                });

            migrationBuilder.CreateTable(
                name: "Book_Author",
                columns: table => new
                {
                    BAId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID = table.Column<int>(nullable: false),
                    AuthorID = table.Column<int>(nullable: false),
                    BookModelBookID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book_Author", x => x.BAId);
                    table.ForeignKey(
                        name: "FK_Book_Author_Books_BookModelBookID",
                        column: x => x.BookModelBookID,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookID", "IdBookStore", "NoPage", "Notes", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 1, 530, "Good Book !", 103.5f, "Opertaing System" },
                    { 2, 1, 400, "boring book", 99.5f, "Data Structure" },
                    { 3, 1, 500, "Interesting book", 300.5f, "Software Testing" },
                    { 4, 2, 300, "boring book", 200.9f, "Design Pattren" },
                    { 5, 2, 250, "A very useful book", 90.5f, "Learn How To Learn" },
                    { 6, 2, 100, "Interesting book", 88.5f, "Act Like A Success" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Book_Author_BookModelBookID",
                table: "Book_Author",
                column: "BookModelBookID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book_Author");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
