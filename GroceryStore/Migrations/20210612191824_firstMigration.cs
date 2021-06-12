using Microsoft.EntityFrameworkCore.Migrations;

namespace GroceryStore.Migrations
{
    public partial class firstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BranchProduct",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BranchProduct", x => new { x.BranchId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_BranchProduct_Branches_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BranchProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CustomerProduct",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerProduct", x => new { x.CustomerId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerProduct_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Branches",
                columns: new[] { "BranchId", "Address", "Name" },
                values: new object[,]
                {
                    { 1, "Riyadh", "Norah Grocery" },
                    { 2, "Dammam", "Norah Grocery" },
                    { 3, "Jeddah", "Norah Grocery" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "Email", "FirstName", "LastName", "Phone" },
                values: new object[,]
                {
                    { 1, "Jeddah, Al Marwah, Saeed Albasri street", "norah@outlook.sa", "Norah", "Almutairi", "0534355512" },
                    { 2, "Riyadh, Al Narjis, Alsalamah street", "Maha@outlook.sa", "Maha", "Alzahrani", "0565355519" },
                    { 3, "Dammam, Al Rawdah, Malik Ibn Jubair street", "Mona@outlook.sa", "Mona", "Alghamdi", "0535366514" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/170x165/9df78eab33525d08d6e5fb8d27136e95/1/3/132.jpg", "Apple", 1.5f },
                    { 2, "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/340x330/9df78eab33525d08d6e5fb8d27136e95/o/r/orange-2.jpg", "Orange", 2.5f },
                    { 3, "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/340x330/9df78eab33525d08d6e5fb8d27136e95/5/0/500_0.jpg", "Banana", 3.5f }
                });

            migrationBuilder.InsertData(
                table: "BranchProduct",
                columns: new[] { "BranchId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 2, 2 },
                    { 1, 2 },
                    { 2, 3 }
                });

            migrationBuilder.InsertData(
                table: "CustomerProduct",
                columns: new[] { "CustomerId", "ProductId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 1 },
                    { 1, 2 },
                    { 2, 2 },
                    { 3, 2 },
                    { 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CustomerId", "Password", "UserName" },
                values: new object[,]
                {
                    { 1, 1, "sfs34", "Norah123" },
                    { 2, 2, "maha222", "Mahaaz" },
                    { 3, 3, "Moon66", "Moon" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BranchProduct_ProductId",
                table: "BranchProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerProduct_ProductId",
                table: "CustomerProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CustomerId",
                table: "Users",
                column: "CustomerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BranchProduct");

            migrationBuilder.DropTable(
                name: "CustomerProduct");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
