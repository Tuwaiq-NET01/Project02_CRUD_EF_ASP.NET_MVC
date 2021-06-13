using Microsoft.EntityFrameworkCore.Migrations;

namespace Hospital_project3.Migrations
{
    public partial class SeedingdData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "NationalID", "Address", "Gender", "Name" },
                values: new object[,]
                {
                    { 1122998, "Almoroj", "Female", "Sara" },
                    { 1820336, "Alsalman", "Female", "Salwa" },
                    { 1354922, "Qurtubah", "Female", "Fai" },
                    { 1883547, "Narjes", "Male", "Mohhamad" },
                    { 1837354, "Alaziziah", "Female", "Lamees" },
                    { 1992755, "Alworod", "Male", "Fares" },
                    { 1683398, "Olia", "Male", "Saud" },
                    { 1124398, "Almoroj", "Female", "Lama" },
                    { 1775342, "Alqadsiah", "Male", "Battal" }
                });

            migrationBuilder.InsertData(
                table: "Physicians",
                columns: new[] { "Id", "Gender", "Name", "Position" },
                values: new object[,]
                {
                    { 1180, "Female", "Abrar", "Internist" },
                    { 1110, "Male", "Hossam", "Pediatrician" },
                    { 1111, "Male", "Saad", "Internist" },
                    { 1112, "Male", "John", "Peadiatric neurologist" },
                    { 1113, "Female", "Eman", "Cardiologist" },
                    { 1119, "Female", "Sara", "Psychiatrist" },
                    { 1117, "Female", "Hana", "Surgeon" },
                    { 1144, "Male", "Jason", "Dermatologist" },
                    { 1151, "Male", "Derek", "Surgeon" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "ID", "Date_Time", "PatientId", "PhysicianId" },
                values: new object[,]
                {
                    { 772, "10-12-2021 09:30AM", 1124398, 1110 },
                    { 886, "19-10-2021 01:00PM", 1775342, 1111 },
                    { 733, "03-09-2021 10:00AM", 1683398, 1113 },
                    { 992, "09-02-2021 08:00AM", 1837354, 1119 },
                    { 338, "11-07-2021 09:45AM", 1354922, 1180 },
                    { 177, "20-11-2021 12:00PM", 1992755, 1180 },
                    { 334, "30-05-2021 10:35AM", 1820336, 1151 }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "ID", "Name", "PhysicianId" },
                values: new object[,]
                {
                    { 66, "Internal medicine", 1111 },
                    { 20, "Neonatal", 1112 },
                    { 27, "Cardiology", 1113 },
                    { 44, "Emergency", 1113 },
                    { 90, "Anesthetics", 1151 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "ID",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "ID",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1122998);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1883547);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1124398);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1354922);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1683398);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1775342);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1820336);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1837354);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "NationalID",
                keyValue: 1992755);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Physicians",
                keyColumn: "Id",
                keyValue: 1180);
        }
    }
}
