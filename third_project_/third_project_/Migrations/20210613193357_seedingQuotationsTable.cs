using Microsoft.EntityFrameworkCore.Migrations;

namespace third_project_.Migrations
{
    public partial class seedingQuotationsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Quotations",
                columns: new[] { "Id", "Message", "StudentId" },
                values: new object[,]
                {
                    { 1, " There is nothing permanent except change.", 1 },
                    { 2, " When you reach the end of your rope, tie a knot in it and hang on.", 1 },
                    { 3, " Learning never exhausts the mind.", 2 },
                    { 4, " All that we see or seem is but a dream within a dream.", 3 },
                    { 5, " No act of kindness, no matter how small, is ever wasted.", 4 },
                    { 6, " It is far better to be alone, than to be in bad company.", 4 },
                    { 7, " If you cannot do great things, do small things in a great way.", 5 },
                    { 8, " Keep your face always toward the sunshine - and shadows will fall behind you.", 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Quotations",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
