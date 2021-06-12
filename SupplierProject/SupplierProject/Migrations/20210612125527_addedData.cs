using Microsoft.EntityFrameworkCore.Migrations;

namespace SupplierProject.Migrations
{
    public partial class addedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierID", "Address", "FirstName", "Gender", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Jubail", "Yasmin", "Female", "AlGhamdi", "055-569-9110" },
                    { 2, "Dammam", "Rita", "Female ", "Farr", "050-569-9110" },
                    { 3, "Riyadh", "Tony", "Male", "Roberts", "054-932-6548" },
                    { 4, "Jeddah", "Amelia", "Female", "Owen", "051-436-5094" },
                    { 5, "Dammam", "Kyle", "Male ", "Fox", "059-330-4393" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierID",
                keyValue: 5);
        }
    }
}
