using Microsoft.EntityFrameworkCore.Migrations;

namespace AirportsSystemsCrud.Migrations
{
    public partial class SeedingDataToFourTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Airports",
                columns: new[] { "Airport_ID", "Airport_Name", "Airport_Short", "Country_City", "Gate" },
                values: new object[,]
                {
                    { 1, "ALAIN INTERNATIONAL AIRPORT", "ANN", "emirates", "G11" },
                    { 2, "KING HUSSAIN INTERNATIONAL AIRPORT", "AQJ", "JURDAN", "G107" },
                    { 3, "ABUDAHABI INTERNATIONAL AIRPORT", "AUH", "emirates", "G07" },
                    { 4, "BAHRAIN INTERNATIONAL AIRPORT", "BAH", "bahrain", "G34" },
                    { 5, "KING FAHD INTERNATIONAL AIRPORT", "DMM", "dammam", "G2" }
                });

            migrationBuilder.InsertData(
                table: "Passengers",
                columns: new[] { "Passenger_ID", "First_Name", "Gender", "Last_Name", "Nationality", "Passport_NO" },
                values: new object[,]
                {
                    { 234567890, "Sou", "Male", "Hong", "Japanese", 10 },
                    { 987654321, "Zaina", "Female", "Algmosh", "Egyptian", 12 },
                    { 345678901, "Mohammed", "Male", "Alqahtani", "Saudi Arabia", 20 }
                });

            migrationBuilder.InsertData(
                table: "Planes",
                columns: new[] { "Plane_ID", "Capacity", "Plane_Name", "Plane_Type" },
                values: new object[,]
                {
                    { 12, 200, "Airbus 330", "Airbus" },
                    { 13, 340, "Airbus 340", "Airbus" },
                    { 11, 500, "Airbus A300 / A310", "Airbus" },
                    { 14, 350, "Airbus 350", "Airbus" },
                    { 15, 250, "Airbus 380", "Airbus" }
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripID", "Cabin_Class", "Destination", "Duration", "Price", "Road_Type", "Take_Off_Time", "Trip_Type", "Weight" },
                values: new object[,]
                {
                    { 61456, "guest", "NewYork-USA", 14, 5689, "round-trip", 19, "international", 40 },
                    { 61132, "guest", "dammam", 3, 457, "one-way", 22, "Internal", 30 },
                    { 61234, "first", "LA-USA", 10, 7939, "one-way", 23, "international", 50 },
                    { 61345, "guest", "Turkey", 13, 4211, "round-trip", 0, "international", 40 },
                    { 61567, "guest", "Bali", 11, 2945, "one-way", 2, "international", 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Airport_ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Airport_ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Airport_ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Airport_ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Airports",
                keyColumn: "Airport_ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Passenger_ID",
                keyValue: 234567890);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Passenger_ID",
                keyValue: 345678901);

            migrationBuilder.DeleteData(
                table: "Passengers",
                keyColumn: "Passenger_ID",
                keyValue: 987654321);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Plane_ID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Plane_ID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Plane_ID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Plane_ID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Planes",
                keyColumn: "Plane_ID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripID",
                keyValue: 61132);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripID",
                keyValue: 61234);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripID",
                keyValue: 61345);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripID",
                keyValue: 61456);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "TripID",
                keyValue: 61567);
        }
    }
}
