using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGalleryCRUD.Migrations
{
    public partial class DeleteRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 1,
                columns: new[] { "ArtistId", "BuyerId", "GalleryId" },
                values: new object[] { 1, 2, 1 });

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 2,
                columns: new[] { "ArtistId", "BuyerId", "GalleryId" },
                values: new object[] { 1, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 3,
                columns: new[] { "ArtistId", "BuyerId", "GalleryId" },
                values: new object[] { 1, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 4,
                columns: new[] { "ArtistId", "BuyerId", "GalleryId" },
                values: new object[] { 2, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 5,
                columns: new[] { "ArtistId", "BuyerId", "GalleryId" },
                values: new object[] { 2, 5, 5 });

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 6,
                columns: new[] { "ArtistId", "BuyerId", "GalleryId" },
                values: new object[] { 2, 2, 6 });

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 7,
                columns: new[] { "ArtistId", "BuyerId", "GalleryId" },
                values: new object[] { 3, 6, 7 });

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 8,
                columns: new[] { "ArtistId", "BuyerId", "GalleryId" },
                values: new object[] { 3, 1, 8 });

            migrationBuilder.UpdateData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 9,
                columns: new[] { "ArtistId", "BuyerId", "GalleryId" },
                values: new object[] { 3, 2, 9 });

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
    }
}
