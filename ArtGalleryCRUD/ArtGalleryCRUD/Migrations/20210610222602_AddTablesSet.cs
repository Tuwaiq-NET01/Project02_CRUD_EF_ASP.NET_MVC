using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGalleryCRUD.Migrations
{
    public partial class AddTablesSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ArtId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtBio = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ArtId);
                });

            migrationBuilder.CreateTable(
                name: "Buyers",
                columns: table => new
                {
                    ByrID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ByrName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ByrMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ByrPhone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buyers", x => x.ByrID);
                });

            migrationBuilder.CreateTable(
                name: "Galleries",
                columns: table => new
                {
                    GlrId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GlrName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlrImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GlrLocation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Galleries", x => x.GlrId);
                });

            migrationBuilder.CreateTable(
                name: "Paintings",
                columns: table => new
                {
                    PntId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PntName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PntImg = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PntOverview = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PntPrice = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paintings", x => x.PntId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Buyers");

            migrationBuilder.DropTable(
                name: "Galleries");

            migrationBuilder.DropTable(
                name: "Paintings");
        }
    }
}
