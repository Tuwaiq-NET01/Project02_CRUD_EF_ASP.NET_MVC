using Microsoft.EntityFrameworkCore.Migrations;

namespace CarStore.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Chassis",
                columns: new[] { "Id", "Image", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "https://previews.123rf.com/images/nerthuz/nerthuz1610/nerthuz161000173/65011853-unibody-car-chassis.jpg", 15000f, "Sedan" },
                    { 2, "https://preview.free3d.com/img/2016/04/2374224423268910544/6ud0kqh2-900.jpg", 20000f, "SUV" }
                });

            migrationBuilder.InsertData(
                table: "Color",
                columns: new[] { "Id", "Image", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "https://st4.depositphotos.com/26898060/37821/i/450/depositphotos_378210622-stock-photo-modern-luxury-white-car-front.jpg", 5000f, "White" },
                    { 2, "https://img.freepik.com/free-photo/front-view-generic-brandless-moder-car_110488-502.jpg", 5000f, "Black" }
                });

            migrationBuilder.InsertData(
                table: "Engine",
                columns: new[] { "Id", "Image", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "https://carpart.com.au/uploads/images/blog/204/v6engine-1569930056.jpg", 15000f, "V-6" },
                    { 2, "https://www.renderhub.com/markos3d/lsa-v8-engine-supercharged-muscle-car-engine/lsa-v8-engine-supercharged-muscle-car-engine-01.jpg", 30000f, "V-8" },
                    { 3, "https://best-automechanicschools.com/wp-content/uploads/2018/11/turbocharger-vs-supercharger-v12-engine-18.png", 60000f, "V-12" }
                });

            migrationBuilder.InsertData(
                table: "Gear",
                columns: new[] { "Id", "Image", "Price", "Type" },
                values: new object[,]
                {
                    { 1, "https://st4.depositphotos.com/1000844/22907/i/1600/depositphotos_229077072-stock-photo-automatic-gear-box-stick.jpg", 20000f, "Automatic" },
                    { 2, "https://miro.medium.com/max/2000/1*drEf-yp7j3_x23nJSo---w.jpeg", 10000f, "Manual" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chassis",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Chassis",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Color",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Engine",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Engine",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Engine",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gear",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gear",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
