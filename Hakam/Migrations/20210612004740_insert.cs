using Microsoft.EntityFrameworkCore.Migrations;

namespace Hakam.Migrations
{
    public partial class insert : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Podcast_Logo",
                table: "Podcasts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Podcast_Logo",
                table: "Podcasts");
        }
    }
}
