using Microsoft.EntityFrameworkCore.Migrations;

namespace Compound.Migrations
{
    public partial class creatingNewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Merchents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Merchents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Merchents",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Bunny toy", "Toy", 12.199999999999999 },
                    { 2, "Princesses toy", "Toy", 102.2 },
                    { 3, "Truck toy", "Car", 212.19999999999999 },
                    { 4, "Blocks to be destroyed", "Jengo", 132.19999999999999 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Merchents");
        }
    }
}
