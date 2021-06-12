using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStore.Migrations
{
    public partial class DataSeedingForCarOrder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarOrderModel",
                columns: new[] { "Id", "ChassisId", "ColorId", "EngineId", "GearId", "TotalPrice" },
                values: new object[] { 1, 1, 1, 1, 1, 55000f });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarOrderModel",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
