using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc_Project2.Migrations
{
    public partial class Seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Flag", "Language", "Name" },
                values: new object[,]
                {
                    { 1, "https://upload.wikimedia.org/wikipedia/en/thumb/a/a4/Flag_of_the_United_States.svg/1920px-Flag_of_the_United_States.svg.png", "English", "United States" },
                    { 2, "https://th.bing.com/th/id/R9577060d3d8e2986295e430747ba0a65?rik=c%2fwkgwj3Y6S3wA&pid=ImgRaw", "Arabic", "United Arab Emirates" },
                    { 3, "https://th.bing.com/th/id/R0539c85b1aa77d7ecaac44873dc281d0?rik=sCwObasiJojamA&pid=ImgRaw", "Arabic", "Egypt" }
                });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Id", "Airlines", "Name" },
                values: new object[,]
                {
                    { 1, "Saudi Arabian Airlines", "Plane 01" },
                    { 2, "Emirates", "Plane 02" },
                    { 3, "Etihad Airways", "Plane 03" },
                    { 4, "Emirates", "Plane 04" }
                });

            migrationBuilder.InsertData(
                table: "passengers",
                columns: new[] { "Id", "Email", "Name", "PhoneNum", "PlaneId" },
                values: new object[,]
                {
                    { 1, "Mohammed@gmail.com", "Mohammed", "0599334453", 1 },
                    { 2, "Ali@gmail.com", "Ali", "0590834453", 1 },
                    { 3, "Hassan@gmail.com", "Hassan", "0504534231", 2 },
                    { 4, "Fahad@gmail.com", "Fahad", "0503625499", 2 },
                    { 5, "Anas@gmail.com", "Anas", "0504422453", 3 },
                    { 6, "Hamad@gmail.com", "Hamad", "0500983324", 3 },
                    { 7, "Ahmed@gmail.com", "Ahmed", "0599432343", 4 },
                    { 8, "Meshal@gmail.com", "Meshal", "0555098833", 4 }
                });

            migrationBuilder.InsertData(
                table: "Bags",
                columns: new[] { "Id", "Color", "PassengerId", "Size" },
                values: new object[,]
                {
                    { 1, "red", 1, "small" },
                    { 2, "black", 1, "big" },
                    { 3, "red", 2, "big" },
                    { 12, "brouwn", 2, "small" },
                    { 4, "black", 3, "small" },
                    { 5, "red", 3, "big" },
                    { 6, "white", 4, "small" },
                    { 8, "black", 5, "big" },
                    { 7, "brouwn", 6, "small" },
                    { 9, "black", 7, "big" },
                    { 10, "pink", 8, "small" },
                    { 11, "white", 8, "big" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Bags",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
