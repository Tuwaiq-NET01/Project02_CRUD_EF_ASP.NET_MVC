using Microsoft.EntityFrameworkCore.Migrations;

namespace Music_Website.Migrations
{
    public partial class SeedingMusic : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "Music_image", "ProfileId", "audio", "description", "title" },
                values: new object[] { 1, "https://m.media-amazon.com/images/I/514gcbVy-QL._SL500_.jpg", 1, "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613571243/zwz1nov81nhkbnnj6e6i.mp3", "The official music video for Ocean by David Davis. Connect with David online. Instagram: @justdaviddavis Facebook: facebook.com/justdaviddavis Website: justdaviddavis.com/ TikTok: tiktok.com/@justdaviddavis", "David Davis" });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "Music_image", "ProfileId", "audio", "description", "title" },
                values: new object[] { 2, "https://res.cloudinary.com/duuconncq/image/upload/v1613598303/jkkshf0yiwrp5d3mz7ec.jpg", 1, "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613598562/zjxp5qcsetep7pyog0ki.mp3", "Don't cry to give up , cry to be successful", "Don't give up" });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "Music_image", "ProfileId", "audio", "description", "title" },
                values: new object[] { 3, "https://cdns-images.dzcdn.net/images/cover/77129041df87e78752bd3dc2cc841912/500x500.jpg", 1, "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1622012633/wbjs3c7yi4wnbuav3mjm.mp3", "Zodiac Songs: RENAE - Rome (Capricorn)", "RENAE - Rome" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
