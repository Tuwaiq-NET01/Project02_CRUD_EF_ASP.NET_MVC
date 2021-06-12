using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStore.Migrations
{
    public partial class CreatedOrderTableAndRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarOrderModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<float>(type: "real", nullable: false),
                    ChassisId = table.Column<int>(type: "int", nullable: false),
                    EngineId = table.Column<int>(type: "int", nullable: false),
                    GearId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarOrderModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarOrderModel_Chassis_ChassisId",
                        column: x => x.ChassisId,
                        principalTable: "Chassis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarOrderModel_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarOrderModel_Engine_EngineId",
                        column: x => x.EngineId,
                        principalTable: "Engine",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarOrderModel_Gear_GearId",
                        column: x => x.GearId,
                        principalTable: "Gear",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarOrderModel_ChassisId",
                table: "CarOrderModel",
                column: "ChassisId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarOrderModel_ColorId",
                table: "CarOrderModel",
                column: "ColorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarOrderModel_EngineId",
                table: "CarOrderModel",
                column: "EngineId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CarOrderModel_GearId",
                table: "CarOrderModel",
                column: "GearId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarOrderModel");
        }
    }
}
