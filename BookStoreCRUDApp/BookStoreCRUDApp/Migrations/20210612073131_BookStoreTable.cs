using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStoreCRUDApp.Migrations
{
    public partial class BookStoreTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BookStoreModelIdBookStore",
                table: "Books",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookStore",
                columns: table => new
                {
                    IdBookStore = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameOfBookStore = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    EmailOfBookStore = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookStore", x => x.IdBookStore);
                });

            migrationBuilder.InsertData(
                table: "BookStore",
                columns: new[] { "IdBookStore", "EmailOfBookStore", "Location", "NameOfBookStore", "Telephone" },
                values: new object[] { 1, "bs-r@mail.com", "Al-Hamra-Riyadh", " Jarir", "011984430" });

            migrationBuilder.InsertData(
                table: "BookStore",
                columns: new[] { "IdBookStore", "EmailOfBookStore", "Location", "NameOfBookStore", "Telephone" },
                values: new object[] { 2, "bs-j@mail.com", "Al-Manar-Jeddah", " Jarir", "01488994" });

            migrationBuilder.CreateIndex(
                name: "IX_Books_BookStoreModelIdBookStore",
                table: "Books",
                column: "BookStoreModelIdBookStore");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_BookStore_BookStoreModelIdBookStore",
                table: "Books",
                column: "BookStoreModelIdBookStore",
                principalTable: "BookStore",
                principalColumn: "IdBookStore",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_BookStore_BookStoreModelIdBookStore",
                table: "Books");

            migrationBuilder.DropTable(
                name: "BookStore");

            migrationBuilder.DropIndex(
                name: "IX_Books_BookStoreModelIdBookStore",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "BookStoreModelIdBookStore",
                table: "Books");
        }
    }
}
