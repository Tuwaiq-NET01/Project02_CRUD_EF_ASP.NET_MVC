using Microsoft.EntityFrameworkCore.Migrations;

namespace eLearn.Migrations
{
    public partial class InsertData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Lecturer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CourseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CourseLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Course_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Lecturer",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LecturerId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Lecturer", x => new { x.UserId, x.LecturerId });
                    table.ForeignKey(
                        name: "FK_User_Lecturer_Lecturer_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Lecturer_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lecturer_Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    LecturerId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lecturer_Course", x => new { x.LecturerId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_Lecturer_Course_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Lecturer_Course_Lecturer_LecturerId",
                        column: x => x.LecturerId,
                        principalTable: "Lecturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User_Course",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User_Course", x => new { x.UserId, x.CourseId });
                    table.ForeignKey(
                        name: "FK_User_Course_Course_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_User_Course_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryDescription", "CategoryImage", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Know more about  science", "https://image.shutterstock.com/z/stock-vector-science-word-cloud-53764600.jpg", "Science" },
                    { 2, "Know more about computer", "https://d2gg9evh47fn9z.cloudfront.net/800px_COLOURBOX37705714.jpg", "Computer" }
                });

            migrationBuilder.InsertData(
                table: "Lecturer",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Amal@gmail.com", "Bader", "alqahtani" },
                    { 2, "Sami@gmail.com", "Sami", "Alshammari" },
                    { 3, "Ahad@gmail.com", "Ahad", "Alghamdi" },
                    { 4, "Amal@gmail.com", "Rami", "Alshehri " },
                    { 5, "Sami@gmail.com", "Fahad", "Alshammari" },
                    { 6, "Ahad@gmail.com", "Nora", "Alghamdi" }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Amal@gmail.com", "Amal", "Almutairi" },
                    { 2, "Lama@gmail.com", "Lama", "Alsalman" },
                    { 3, "Reema@gmail.com", "Reema", "Altwaim" },
                    { 4, "Sultan@gmail.com", "Sultan", "Alsalman" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CategoryId", "CourseDescription", "CourseImage", "CourseLevel", "CourseName" },
                values: new object[,]
                {
                    { 1, 1, "Unit: Introduction to electrical engineering", "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg", "Beginner", "Electrical Engineering" },
                    { 2, 1, "Unit: Scale of the universe", "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg", "Beginner", "Biology" },
                    { 3, 1, "Unit: Scale of the universe", "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg", "Intermediate", "Cosmology " },
                    { 4, 1, "Unit: IAtoms, compounds, and ions", "https://image.freepik.com/free-vector/science-word-concept_23-2148543544.jpg", "Advanced", "Chemistry" },
                    { 5, 2, "Unit: Intro to HTML/CSS: Making webpages", "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg", "Beginner", "HTML/CSS: Making webpages" },
                    { 6, 2, "Unit: Intro to SQL: Querying and managing data", "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg", "Beginner", "Querying and managing data" },
                    { 7, 2, "Unit: HTML/JS: Making webpages interactive", "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg", "Intermediate", "HTML/JS webpages interactive" },
                    { 8, 2, "Unit: Advanced JS: Natural Simulations", "https://cdn5.vectorstock.com/i/1000x1000/54/79/word-cloud-computer-architecture-vector-1695479.jpg", "Advanced", "JS: Natural Simulations" }
                });

            migrationBuilder.InsertData(
                table: "User_Lecturer",
                columns: new[] { "LecturerId", "UserId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 3, 1, 2 },
                    { 5, 2, 3 },
                    { 4, 2, 4 },
                    { 4, 3, 5 },
                    { 6, 3, 6 },
                    { 5, 4, 7 },
                    { 2, 4, 8 }
                });

            migrationBuilder.InsertData(
                table: "Lecturer_Course",
                columns: new[] { "CourseId", "LecturerId", "Id" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 3, 3 },
                    { 7, 6, 9 },
                    { 3, 4, 6 },
                    { 4, 4, 4 },
                    { 4, 5, 7 },
                    { 8, 5, 8 },
                    { 5, 4, 5 },
                    { 6, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "User_Course",
                columns: new[] { "CourseId", "UserId", "Id" },
                values: new object[,]
                {
                    { 7, 3, 6 },
                    { 6, 4, 8 },
                    { 4, 2, 3 },
                    { 3, 2, 4 },
                    { 2, 1, 2 },
                    { 1, 1, 1 },
                    { 5, 3, 5 },
                    { 8, 4, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Course_CategoryId",
                table: "Course",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Lecturer_Course_CourseId",
                table: "Lecturer_Course",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Course_CourseId",
                table: "User_Course",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_User_Lecturer_LecturerId",
                table: "User_Lecturer",
                column: "LecturerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lecturer_Course");

            migrationBuilder.DropTable(
                name: "User_Course");

            migrationBuilder.DropTable(
                name: "User_Lecturer");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Lecturer");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
