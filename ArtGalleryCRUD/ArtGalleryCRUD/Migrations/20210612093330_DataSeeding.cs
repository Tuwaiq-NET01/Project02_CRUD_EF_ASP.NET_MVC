using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGalleryCRUD.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ArtId", "ArtBio", "ArtImg", "ArtName" },
                values: new object[,]
                {
                    { 1, "Originally from a small town in the south of Italy Angelo Accardi moved to Napoli to study fine arts at the Art Academy of Naples. Shortly after, in the early 90s, he set up his personal studio close to his childhood home to embark on his pursuit of painting and sculpture. In the course of his artistic development, Accardi has been on a constant search for new sensations using mixed media to depictfigures against differing social backgrounds.", "https://www.angeloaccardi.com/wp-content/uploads/sites/11/2017/12/acardi-620x620-home.jpg", "Angelo Accardi" },
                    { 2, "Trained and educated as an artist in the south of France, Benharrouche went on to become a distinguished professor of drawing and painting at Nice´s Academie Paganini. His influences include masters such as Chagall, Picasso, and Miro, yet Benharrouche’s personal style comes through in each of his compositions with much strength, balance and harmony. Deeply spiritual, Yoel Benharrouche establishes a sincere connection with his audience. His vibrant palette and mystical contemplation explore both the historical and spiritual world of Israel. He paints his surroundings with a lyrical quality that has landed him among the elite artists of the world, exploring the duality between the material and the mystical world.", "https://www.eden-gallery.com/wp-content/uploads/sites/15/2017/09/yoel-benharrouche-at-the-studio-105-1-683x1024.jpg", "Benharrouche" },
                    { 3, "Born in California in 1965, Tommy studied art history at Santa Monica College in the United States, later on, studying architecture and interior design. His passion for aesthetics drove Tommy to dabble in different fields of design, like high-end furniture and silversmith work, eventually evolving into a painter and artist. Over the years, Tommy became an upscale interior designer, designing projects for high-end clientele.", "https://d2vg5otv6yjmj3.cloudfront.net/wp-content/uploads/2015/12/tommy.jpg", "Tommy Shenkar" }
                });

            migrationBuilder.InsertData(
                table: "Buyers",
                columns: new[] { "ByrID", "ByrMail", "ByrName", "ByrPhone" },
                values: new object[,]
                {
                    { 5, "vic@dns.com", "vicku", 2345678 },
                    { 4, "ram@dns.com", "Ramii", 3456789 },
                    { 6, "rs@dns.com", "rose", 3548765 },
                    { 2, "mir@dns.com", "Mirry", 9345677 },
                    { 1, "Jack@dns.com", "Jack", 9665964 },
                    { 3, "elsi@dns.com", "Elias", 4567899 }
                });

            migrationBuilder.InsertData(
                table: "Galleries",
                columns: new[] { "GlrId", "GlrImg", "GlrLocation", "GlrName" },
                values: new object[,]
                {
                    { 8, "https://imgmediagumlet.lbb.in/media/2019/04/5cbdad06b62ad10704e9f804_1555934470151.jpg?fm=webp&w=750&h=500&dpr=1", "London", "Gallery Chemould3" },
                    { 1, "https://imgmediagumlet.lbb.in/media/2019/03/5c9b5aeac394967ce2d1f1f3_1553685226709.jpg?fm=webp&w=750&h=500&dpr=1", " Mumbai", "Volte" },
                    { 2, "https://imgmediagumlet.lbb.in/media/2019/04/5cbdad06b62ad10704e9f804_1555934470151.jpg?fm=webp&w=750&h=500&dpr=1", "London", "Gallery Chemould" },
                    { 3, "https://gulfbusiness.com/wp-content/uploads/2021/02/Website-Grosvenor-Gallery-London-Art-Dubai-Modern-March-20-Art-Dubai-2019-Courtesy-of-Photo-Solutions-3-1.jpg", "Dubai", "Art Dubai" },
                    { 4, "https://imgmediagumlet.lbb.in/media/2019/03/5c9b5aeac394967ce2d1f1f3_1553685226709.jpg?fm=webp&w=750&h=500&dpr=1", "Mumbai", "Volte2" },
                    { 5, "https://imgmediagumlet.lbb.in/media/2019/04/5cbdad06b62ad10704e9f804_1555934470151.jpg?fm=webp&w=750&h=500&dpr=1", "London", "Gallery Chemould2" },
                    { 6, "https://gulfbusiness.com/wp-content/uploads/2021/02/Website-Grosvenor-Gallery-London-Art-Dubai-Modern-March-20-Art-Dubai-2019-Courtesy-of-Photo-Solutions-3-1.jpg", "Dubai", "Art Dubai2" },
                    { 7, "https://imgmediagumlet.lbb.in/media/2019/03/5c9b5aeac394967ce2d1f1f3_1553685226709.jpg?fm=webp&w=750&h=500&dpr=1", "Mumbai", "Volte3" },
                    { 9, "https://gulfbusiness.com/wp-content/uploads/2021/02/Website-Grosvenor-Gallery-London-Art-Dubai-Modern-March-20-Art-Dubai-2019-Courtesy-of-Photo-Solutions-3-1.jpg", "Dubai", "Art Dubai3" }
                });

            migrationBuilder.InsertData(
                table: "Paintings",
                columns: new[] { "PntId", "ArtistId", "BuyerId", "GalleryId", "PntImg", "PntName", "PntOverview", "PntPrice" },
                values: new object[,]
                {
                    { 1, 1, 2, 1, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/AngeloAccardi-StandingTogether.1_1_1100x.jpg?v=1596095563", "STANDING TOGETHER", "3D Multilayered Papercut 108x143 cm | 42x56 in Limited Edition", 10400.0 },
                    { 2, 1, 3, 2, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/AngeloAccardi-LookingDown.1_1_1100x.jpg?v=1606219907", "LOOKING DOWN", "3D Multilayered Papercut 80x100 cm | 31x39 in Limited Edition", 8300.0 },
                    { 3, 1, 2, 3, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/AngeloAccardi-AbbeyRoad.1_860x.jpg?v=1596111743", "ABBEY ROAD", "3D Multilayered Papercut 56x75 cm | 22x29 in Limited Edition", 5200.0 },
                    { 4, 2, 4, 4, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/Lescordesdemoname-2_1_1100x.jpg?v=1606229671", "LES CORDES DE MON AME", "Lacquer on metal 30x24 cm | 11x9 in Limited Editio", 1600.0 },
                    { 5, 2, 5, 5, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/BouquetduParadis-2_1_1100x.jpg?v=1605538407", "BOUQUET DU PARADIS", "Lacquer on Metal 30x24 cm | 11x9 in Limited Edition", 2600.0 },
                    { 6, 2, 2, 6, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/Sensiblecommelesfleurs-2_1_1100x.jpg?v=1606403544", "SENSIBLE COMME LES FLEURS", "Lacquer on metal 30x24 cm | 11x9 in Limited Editio", 4600.0 },
                    { 7, 3, 6, 7, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/COVERGIRLMarilyn_1_1100x.jpg?v=1606836043", "COVER GIRL MARILYN MONROE", "Mixed Media Painting 120x76 cm | 47x29 in", 5170.0 },
                    { 8, 3, 1, 8, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/JUSTAMOUSE__1_1100x.jpg?v=1606833970", "JUST A MOUSE", "Mixed Media Painting 40x67 cm | 15x26 in", 5188.0 },
                    { 9, 3, 2, 9, "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/THELASTSTAR__1_1100x.jpg?v=1606833845", "THE LAST STAR", "Mixed Media Painting 175x95 cm | 68x37 in", 4600.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Paintings",
                keyColumn: "PntId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ArtId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Buyers",
                keyColumn: "ByrID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Galleries",
                keyColumn: "GlrId",
                keyValue: 9);
        }
    }
}
