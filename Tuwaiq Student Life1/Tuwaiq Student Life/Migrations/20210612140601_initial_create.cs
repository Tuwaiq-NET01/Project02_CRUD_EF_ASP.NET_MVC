using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tuwaiq_Student_Life.Migrations
{
    public partial class initial_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Instructors_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstructorsStudents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudenId = table.Column<int>(type: "int", nullable: true),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorsStudents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstructorsStudents_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorsStudents_Students_StudenId",
                        column: x => x.StudenId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Sessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SessionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Duration = table.Column<float>(type: "real", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sessions_Instructors_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Instructors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentsSessions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    StudenId = table.Column<int>(type: "int", nullable: true),
                    SessionId = table.Column<int>(type: "int", nullable: false),
                    InstructorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentsSessions_Sessions_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Sessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentsSessions_Students_StudenId",
                        column: x => x.StudenId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Email", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "Amal@Amal", "Amal", "Fahad" },
                    { 2, "Leenah@Leenah", "Leenah", "Ahmad" },
                    { 3, "Sarah@Sarah", "Sarah", "Ali" },
                    { 4, "Reem@Reem", "Reem", "Khalid" },
                    { 5, "Ali@Ali", "Ali", "Saad" }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "SubjectName" },
                values: new object[,]
                {
                    { 1, "MVC .Net" },
                    { 2, "Design Patterns" },
                    { 3, "Unit testing" }
                });

            migrationBuilder.InsertData(
                table: "Instructors",
                columns: new[] { "Id", "Bio", "Email", "FirstName", "LastName", "SubjectId" },
                values: new object[,]
                {
                    { 1, "", "Salem@Salem", "Salem", "Ahamd", 1 },
                    { 2, "", "Hanaa@Hanaa", "Hanaa", "Abdullah", 1 },
                    { 3, "", "Waleed@Waleed", "Waleed", "Rashed", 2 },
                    { 4, "", "Rawan@Rawan", "Rawan", "Yousef", 3 }
                });

            migrationBuilder.InsertData(
                table: "InstructorsStudents",
                columns: new[] { "Id", "InstructorId", "StudenId", "StudentId" },
                values: new object[,]
                {
                    { 1, 1, null, 1 },
                    { 2, 1, null, 2 },
                    { 3, 1, null, 3 },
                    { 4, 1, null, 4 },
                    { 5, 1, null, 5 },
                    { 6, 2, null, 1 },
                    { 7, 2, null, 2 },
                    { 8, 2, null, 3 },
                    { 9, 3, null, 3 },
                    { 10, 3, null, 4 },
                    { 11, 3, null, 5 },
                    { 12, 4, null, 1 },
                    { 13, 4, null, 2 },
                    { 14, 4, null, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_SubjectId",
                table: "Instructors",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorsStudents_InstructorId",
                table: "InstructorsStudents",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorsStudents_StudenId",
                table: "InstructorsStudents",
                column: "StudenId");

            migrationBuilder.CreateIndex(
                name: "IX_Sessions_InstructorId",
                table: "Sessions",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsSessions_InstructorId",
                table: "StudentsSessions",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentsSessions_StudenId",
                table: "StudentsSessions",
                column: "StudenId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstructorsStudents");

            migrationBuilder.DropTable(
                name: "StudentsSessions");

            migrationBuilder.DropTable(
                name: "Sessions");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropTable(
                name: "Subjects");
        }
    }
}
