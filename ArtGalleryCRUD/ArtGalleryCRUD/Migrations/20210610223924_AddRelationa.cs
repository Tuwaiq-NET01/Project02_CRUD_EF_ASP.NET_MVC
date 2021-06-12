using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGalleryCRUD.Migrations
{
    public partial class AddRelationa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArtistId",
                table: "Paintings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BuyerId",
                table: "Paintings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GalleryId",
                table: "Paintings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_ArtistId",
                table: "Paintings",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_BuyerId",
                table: "Paintings",
                column: "BuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_Paintings_GalleryId",
                table: "Paintings",
                column: "GalleryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Artists_ArtistId",
                table: "Paintings",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "ArtId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Buyers_BuyerId",
                table: "Paintings",
                column: "BuyerId",
                principalTable: "Buyers",
                principalColumn: "ByrID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paintings_Galleries_GalleryId",
                table: "Paintings",
                column: "GalleryId",
                principalTable: "Galleries",
                principalColumn: "GlrId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Artists_ArtistId",
                table: "Paintings");

            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Buyers_BuyerId",
                table: "Paintings");

            migrationBuilder.DropForeignKey(
                name: "FK_Paintings_Galleries_GalleryId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_ArtistId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_BuyerId",
                table: "Paintings");

            migrationBuilder.DropIndex(
                name: "IX_Paintings_GalleryId",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "ArtistId",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "BuyerId",
                table: "Paintings");

            migrationBuilder.DropColumn(
                name: "GalleryId",
                table: "Paintings");
        }
    }
}
