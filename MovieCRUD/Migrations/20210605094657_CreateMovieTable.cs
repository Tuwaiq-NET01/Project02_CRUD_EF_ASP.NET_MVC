using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace MovieCRUD.Migrations
{
    public partial class CreateMovieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    backdrop_path = table.Column<string>(nullable: true),
                    overview = table.Column<string>(nullable: true),
                    poster_path = table.Column<string>(nullable: true),
                    release_date = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    vote_average = table.Column<double>(nullable: false),
                    runtime = table.Column<int>(nullable: false),
                    imdb_id = table.Column<string>(nullable: true),
                    budget = table.Column<int>(nullable: false),
                    revenue = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
