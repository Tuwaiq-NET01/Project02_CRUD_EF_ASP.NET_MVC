using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace animeik.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Categoryid = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Categoryid);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    username = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Animes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    title = table.Column<string>(nullable: true),
                    url = table.Column<string>(nullable: true),
                    image_url = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true),
                    episodes = table.Column<int>(nullable: false),
                    start_date = table.Column<string>(nullable: true),
                    end_date = table.Column<string>(nullable: true),
                    score = table.Column<double>(nullable: false),
                    Categoryid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Animes_Categories_Categoryid",
                        column: x => x.Categoryid,
                        principalTable: "Categories",
                        principalColumn: "Categoryid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Faviortes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AnimeIdid = table.Column<int>(nullable: false),
                    UserIdid = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faviortes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Faviortes_Animes_AnimeIdid",
                        column: x => x.AnimeIdid,
                        principalTable: "Animes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Faviortes_Users_UserIdid",
                        column: x => x.UserIdid,
                        principalTable: "Users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Categoryid", "Name" },
                values: new object[,]
                {
                    { 1, "action" },
                    { 2, "romance" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "id", "username" },
                values: new object[,]
                {
                    { 2, "eren" },
                    { 1, "hassan" }
                });

            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "id", "Categoryid", "end_date", "episodes", "image_url", "score", "start_date", "title", "type", "url" },
                values: new object[] { 1, 1, "2021", 23, "e", 6.5, "2020", "naruto", "", "www.examle.com" });

            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "id", "Categoryid", "end_date", "episodes", "image_url", "score", "start_date", "title", "type", "url" },
                values: new object[] { 3, 1, "2021", 12, "a", 10.5, "2004", "attack on titan", "", "www.examle.com" });

            migrationBuilder.InsertData(
                table: "Animes",
                columns: new[] { "id", "Categoryid", "end_date", "episodes", "image_url", "score", "start_date", "title", "type", "url" },
                values: new object[] { 2, 2, "2021", 34, "s", 9.5, "2002", "onepiece", "", "www.examle.com" });

            migrationBuilder.InsertData(
                table: "Faviortes",
                columns: new[] { "id", "AnimeIdid", "UserIdid" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.InsertData(
                table: "Faviortes",
                columns: new[] { "id", "AnimeIdid", "UserIdid" },
                values: new object[] { 2, 1, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Animes_Categoryid",
                table: "Animes",
                column: "Categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_Faviortes_AnimeIdid",
                table: "Faviortes",
                column: "AnimeIdid");

            migrationBuilder.CreateIndex(
                name: "IX_Faviortes_UserIdid",
                table: "Faviortes",
                column: "UserIdid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faviortes");

            migrationBuilder.DropTable(
                name: "Animes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
