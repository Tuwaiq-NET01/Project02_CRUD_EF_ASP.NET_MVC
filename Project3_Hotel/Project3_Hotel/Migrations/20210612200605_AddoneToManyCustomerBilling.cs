using Microsoft.EntityFrameworkCore.Migrations;

namespace Project3_Hotel.Migrations
{
    public partial class AddoneToManyCustomerBilling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CustomerId",
                table: "Billing",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Billing_CustomerId",
                table: "Billing",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Billing_Customer_CustomerId",
                table: "Billing",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Billing_Customer_CustomerId",
                table: "Billing");

            migrationBuilder.DropIndex(
                name: "IX_Billing_CustomerId",
                table: "Billing");

            migrationBuilder.DropColumn(
                name: "CustomerId",
                table: "Billing");
        }
    }
}
