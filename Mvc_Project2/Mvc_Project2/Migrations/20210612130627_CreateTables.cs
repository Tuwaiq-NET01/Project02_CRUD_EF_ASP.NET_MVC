using Microsoft.EntityFrameworkCore.Migrations;

namespace Mvc_Project2.Migrations
{
    public partial class CreateTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNum",
                table: "passengers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNum",
                value: "0599334453");

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNum",
                value: "0590834453");

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNum",
                value: "0504534231");

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhoneNum",
                value: "0503625499");

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhoneNum",
                value: "0504422453");

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhoneNum",
                value: "0500983324");

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhoneNum",
                value: "0599432343");

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhoneNum",
                value: "0555098833");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNum",
                table: "passengers",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 1,
                column: "PhoneNum",
                value: 599334453);

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 2,
                column: "PhoneNum",
                value: 590834453);

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 3,
                column: "PhoneNum",
                value: 504534231);

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 4,
                column: "PhoneNum",
                value: 503625499);

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 5,
                column: "PhoneNum",
                value: 504422453);

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 6,
                column: "PhoneNum",
                value: 500983324);

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 7,
                column: "PhoneNum",
                value: 599432343);

            migrationBuilder.UpdateData(
                table: "passengers",
                keyColumn: "Id",
                keyValue: 8,
                column: "PhoneNum",
                value: 555098833);
        }
    }
}
