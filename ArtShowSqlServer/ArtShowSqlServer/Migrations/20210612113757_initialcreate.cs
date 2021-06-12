using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtShowSqlServer.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artsits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberPhone = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artsits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArtWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtsitId = table.Column<int>(type: "int", nullable: false),
                    User_Id = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtWorks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtWorks_Artsits_ArtsitId",
                        column: x => x.ArtsitId,
                        principalTable: "Artsits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtWorks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Profile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    First_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Last_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone_Number = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Profile_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artsits",
                columns: new[] { "Id", "Name", "NumberPhone" },
                values: new object[,]
                {
                    { 1, "Mousa Fahad ", 553478768 },
                    { 2, " Afnan Ali", 50754676 },
                    { 3, "Amal Alshehri", 557779835 },
                    { 4, "Hassan Khiled", 53769487 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Username" },
                values: new object[,]
                {
                    { 1, "0987", "shahad123" },
                    { 2, "1234", "ali123" },
                    { 3, "5678", "sara123" }
                });

            migrationBuilder.InsertData(
                table: "ArtWorks",
                columns: new[] { "Id", "ArtsitId", "Image", "Price", "Title", "UserId", "User_Id" },
                values: new object[,]
                {
                    { 7, 1, " https://i.pinimg.com/564x/da/b4/83/dab483b7b0e472a8777ab008bb06dba3.jpg", 650, "Look Of Hope", null, 0 },
                    { 9, 1, "https://i.pinimg.com/474x/24/f9/54/24f9540c894b2756ff42dc0f8dbf2f76.jpg", 750, "Playing Music", null, 0 },
                    { 1, 2, "https://arabartforsale.com/uploads/artworks/1621526489_file.jpeg", 350, "African Girl", null, 0 },
                    { 6, 2, "https://i.pinimg.com/564x/0d/e5/54/0de554e7bdb9b876fd7a7138c70cdb2c.jpg", 600, "Playing Music", null, 0 },
                    { 8, 2, "https://i.pinimg.com/564x/b6/97/25/b6972560735a5eccba28aab8cf37dd92.jpg", 700, "Flower Girl", null, 0 },
                    { 4, 3, "https://i.pinimg.com/564x/ef/6b/11/ef6b11c49ea530a0420252f6defb8904.jpg", 500, "Peace", null, 0 },
                    { 5, 3, "https://i.pinimg.com/564x/16/e4/64/16e464c0cab9851c52eed6688889bc25.jpg", 550, "Mditate Look", null, 0 },
                    { 2, 4, "https://i.pinimg.com/564x/19/75/d6/1975d6e559da17936176eb6168161089.jpg", 400, "Beach Girl", null, 0 },
                    { 3, 4, "https://i.pinimg.com/564x/b5/97/59/b597595d747bde7c979c9e4a37e2c674.jpg", 450, "Health Heroes", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Profile",
                columns: new[] { "Id", "First_Name", "Gender", "Last_Name", "Phone_Number", "UserId" },
                values: new object[,]
                {
                    { 1, "Shahad", "Female", "Alshehri", 503664482, 1 },
                    { 2, "Ali", "Male", "Hassan", 553388292, 2 },
                    { 3, "sara", "Female", "Ali", 508194230, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_ArtsitId",
                table: "ArtWorks",
                column: "ArtsitId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtWorks_UserId",
                table: "ArtWorks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Profile_UserId",
                table: "Profile",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtWorks");

            migrationBuilder.DropTable(
                name: "Profile");

            migrationBuilder.DropTable(
                name: "Artsits");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
