using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Compound.Migrations
{
    public partial class AddingValuesToTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villa",
                columns: new[] { "Villa_Id", "Villa_Group", "Villa_Img", "Villa_Name", "Villa_Number" },
                values: new object[,]
                {
                    { 1, "A", "https://q-xx.bstatic.com/images/hotel/max1024x768/163/163300408.jpg", "Al-Azhar", 1 },
                    { 2, "A", "https://cf.bstatic.com/images/hotel/max1024x768/256/256451213.jpg", "Al-Khair", 2 },
                    { 3, "B", "https://assets.entrepreneur.com/content/3x2/2000/1604135072-webaliser--TPTXZd9mOo-unsplash.jpg", "Al-Khaliej", 3 },
                    { 4, "C", "https://images.traum-ferienwohnungen.de/277125/8501414/46/villa-blanka.jpg", "Al-Rabea", 4 },
                    { 33, "D", "https://images.traum-ferienwohnungen.de/266108/7923121/46/villa-1.jpg", "Al-Hamdanyah", 5 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_Id", "User_Email", "User_Name", "User_PhoneNumber", "VillaId" },
                values: new object[,]
                {
                    { 1, "ControlS@gmail.com", "Abdulrahman", "0560965772", 1 },
                    { 2, "Ahmad@gmail.com", "Ahmad", "0512312345", 1 },
                    { 3, "Anas@gmail.com", "Anas", "0567324545", 1 },
                    { 4, "Sarah@gmail.com", "Sarah", "0555333642", 2 },
                    { 5, "Amjad@gmail.com", "Amjad", "0553366990", 2 }
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "Staff_Id", "Staff_AtWork", "Staff_Email", "Staff_Img", "Staff_Name", "Staff_PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { 2, true, "JhonS@gmail.com", "https://cdn-0.generatormix.com/images/anime-character/death-the-kid.jpg", "Jhon", "0576855421", 1 },
                    { 5, true, "JasminS@gmail.com", "https://vignette.wikia.nocookie.net/akamegakill/images/6/62/Jaegers5.png/revision/latest?cb=20150720195115&path-prefix=ru", "Jasmin", "0500011123", 2 },
                    { 3, true, "AliceS@gmail.com", "https://animerantshome.files.wordpress.com/2019/08/istj-anime-characters-akame-ga-kill.png?w=600", "Alice", "0567431473", 3 },
                    { 4, true, "TonyS@gmail.com", "https://static.fandomspot.com/images/11/10193/00-featured-killua-zoldyck-hunter-x-hunter-anime-preview.jpg", "Tony", "0576524582", 3 },
                    { 1, true, "MohammadS@gmail.com", "https://content.api.news/v3/images/bin/7b790c831c72c5dd3b3275833df09f29", "Mohammad", "0560908070", 4 }
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "Event_Id", "Event_Date", "Event_Name", "StaffId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Musical concert", 2 },
                    { 5, new DateTime(2021, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Otaku Event", 2 },
                    { 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gamming Event", 5 },
                    { 3, new DateTime(2022, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Musical Event", 3 },
                    { 4, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hackthon", 4 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Service_Id", "Service_Name", "StaffId" },
                values: new object[,]
                {
                    { 3, "InVilla Service", 3 },
                    { 4, "Massage", 3 },
                    { 5, "Whatever", 3 },
                    { 1, "Clean the swimming pool", 4 },
                    { 2, "Preparing the basketball ground play", 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Event_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Event_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Event_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Event_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Events",
                keyColumn: "Event_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Service_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Service_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Service_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Service_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Service_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Staff",
                keyColumn: "Staff_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "User_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villa",
                keyColumn: "Villa_Id",
                keyValue: 1);
        }
    }
}
