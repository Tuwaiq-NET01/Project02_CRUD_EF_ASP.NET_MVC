using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace CRUD_Project.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    ImageSrc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ImageSrc", "Name" },
                values: new object[,]
                {
                    { 1, "Kenneth S Krane", "https://m.media-amazon.com/images/I/41QiRwidJJL.jpg", "Introductory Nuclear Physics" },
                    { 2, "Douglas Comer", "https://images-na.ssl-images-amazon.com/images/I/513ShlaCsTL._SX384_BO1,204,203,200_.jpg", "Essentials of Computer Architecture 2nd Edition" },
                    { 3, "Kyle Simpson", "https://images-na.ssl-images-amazon.com/images/I/41vNUw5VbPL._SX398_BO1,204,203,200_.jpg", "You Don't Know JS Yet: Get Started" },
                    { 4, "Jeffrey Richter", "https://images-na.ssl-images-amazon.com/images/I/41IgijxpDhL._SX408_BO1,204,203,200_.jpg", "CLR via C#" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
