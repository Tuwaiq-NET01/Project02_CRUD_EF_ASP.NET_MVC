using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Website.Migrations
{
    public partial class seedingprofile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Background_Image", "Image", "Name", "UserId" },
                values: new object[] { 1, "https://images.pexels.com/photos/946351/pexels-photo-946351.jpeg?w=500&h=650&auto=compress&cs=tinysrgb", "https://res.cloudinary.com/crunchbase-production/image/upload/c_thumb,h_256,w_256,f_auto,g_faces,z_0.7,q_auto:eco/tluillv6dybajfj7i0dq", "Kirsten Korosec", 1 });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Background_Image", "Image", "Name", "UserId" },
                values: new object[] { 2, "https://images.pexels.com/photos/3692749/pexels-photo-3692749.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2014_01/95471/2503781351_7feef38a1a_b-95471.jpg", "Devin Coldewey", 2 });

            migrationBuilder.InsertData(
                table: "Profiles",
                columns: new[] { "Id", "Background_Image", "Image", "Name", "UserId" },
                values: new object[] { 3, "https://images.pexels.com/photos/4500796/pexels-photo-4500796.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", "https://www.monteirolobato.edu.br/public/assets/admin/images/avatars/avatar5_big.png", "Rebecca Bellan", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Profiles",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
