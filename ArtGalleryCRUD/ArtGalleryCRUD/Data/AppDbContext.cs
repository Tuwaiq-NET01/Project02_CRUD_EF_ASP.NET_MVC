using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtGalleryCRUD.Models;

namespace ArtGalleryCRUD.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // seedding
            modelBuilder.Entity<ArtistModel>().HasData(new ArtistModel { ArtId = 1, ArtName = "Angelo Accardi", ArtImg = "https://www.angeloaccardi.com/wp-content/uploads/sites/11/2017/12/acardi-620x620-home.jpg", ArtBio = "Originally from a small town in the south of Italy Angelo Accardi moved to Napoli to study fine arts at the Art Academy of Naples. Shortly after, in the early 90s, he set up his personal studio close to his childhood home to embark on his pursuit of painting and sculpture. In the course of his artistic development, Accardi has been on a constant search for new sensations using mixed media to depictfigures against differing social backgrounds." });
            modelBuilder.Entity<ArtistModel>().HasData(new ArtistModel { ArtId = 2, ArtName = "Benharrouche", ArtImg = "https://www.eden-gallery.com/wp-content/uploads/sites/15/2017/09/yoel-benharrouche-at-the-studio-105-1-683x1024.jpg", ArtBio = "Trained and educated as an artist in the south of France, Benharrouche went on to become a distinguished professor of drawing and painting at Nice´s Academie Paganini. His influences include masters such as Chagall, Picasso, and Miro, yet Benharrouche’s personal style comes through in each of his compositions with much strength, balance and harmony. Deeply spiritual, Yoel Benharrouche establishes a sincere connection with his audience. His vibrant palette and mystical contemplation explore both the historical and spiritual world of Israel. He paints his surroundings with a lyrical quality that has landed him among the elite artists of the world, exploring the duality between the material and the mystical world." });
            modelBuilder.Entity<ArtistModel>().HasData(new ArtistModel { ArtId = 3, ArtName = "Tommy Shenkar", ArtImg = "https://d2vg5otv6yjmj3.cloudfront.net/wp-content/uploads/2015/12/tommy.jpg", ArtBio = "Born in California in 1965, Tommy studied art history at Santa Monica College in the United States, later on, studying architecture and interior design. His passion for aesthetics drove Tommy to dabble in different fields of design, like high-end furniture and silversmith work, eventually evolving into a painter and artist. Over the years, Tommy became an upscale interior designer, designing projects for high-end clientele." });
            modelBuilder.Entity<BuyerModel>().HasData(new BuyerModel { ByrID = 1, ByrName = "Jack", ByrMail = "Jack@dns.com", ByrPhone = 9665964 });
            modelBuilder.Entity<BuyerModel>().HasData(new BuyerModel { ByrID = 2, ByrName = "Mirry", ByrMail = "mir@dns.com", ByrPhone = 9345677 });
            modelBuilder.Entity<BuyerModel>().HasData(new BuyerModel { ByrID = 3, ByrName = "Elias", ByrMail = "elsi@dns.com", ByrPhone = 4567899 });
            modelBuilder.Entity<BuyerModel>().HasData(new BuyerModel { ByrID = 4, ByrName = "Ramii", ByrMail = "ram@dns.com", ByrPhone = 3456789 });
            modelBuilder.Entity<BuyerModel>().HasData(new BuyerModel { ByrID = 5, ByrName = "vicku", ByrMail = "vic@dns.com", ByrPhone = 2345678 });
            modelBuilder.Entity<BuyerModel>().HasData(new BuyerModel { ByrID = 6, ByrName = "rose", ByrMail = "rs@dns.com", ByrPhone = 3548765 });
            modelBuilder.Entity<GalleryModel>().HasData(new GalleryModel { GlrId = 1, GlrName = "Volte", GlrImg = "https://imgmediagumlet.lbb.in/media/2019/03/5c9b5aeac394967ce2d1f1f3_1553685226709.jpg?fm=webp&w=750&h=500&dpr=1", GlrLocation = " Mumbai" });
            modelBuilder.Entity<GalleryModel>().HasData(new GalleryModel { GlrId = 2, GlrName = "Gallery Chemould", GlrImg = "https://imgmediagumlet.lbb.in/media/2019/04/5cbdad06b62ad10704e9f804_1555934470151.jpg?fm=webp&w=750&h=500&dpr=1", GlrLocation = "London" });
            modelBuilder.Entity<GalleryModel>().HasData(new GalleryModel { GlrId = 3, GlrName = "Art Dubai", GlrImg = "https://gulfbusiness.com/wp-content/uploads/2021/02/Website-Grosvenor-Gallery-London-Art-Dubai-Modern-March-20-Art-Dubai-2019-Courtesy-of-Photo-Solutions-3-1.jpg", GlrLocation = "Dubai" });
            modelBuilder.Entity<GalleryModel>().HasData(new GalleryModel { GlrId = 4, GlrName = "Volte2", GlrImg = "https://imgmediagumlet.lbb.in/media/2019/03/5c9b5aeac394967ce2d1f1f3_1553685226709.jpg?fm=webp&w=750&h=500&dpr=1", GlrLocation = "Mumbai" });
            modelBuilder.Entity<GalleryModel>().HasData(new GalleryModel { GlrId = 5, GlrName = "Gallery Chemould2", GlrImg = "https://imgmediagumlet.lbb.in/media/2019/04/5cbdad06b62ad10704e9f804_1555934470151.jpg?fm=webp&w=750&h=500&dpr=1", GlrLocation = "London" });
            modelBuilder.Entity<GalleryModel>().HasData(new GalleryModel { GlrId = 6, GlrName = "Art Dubai2", GlrImg = "https://gulfbusiness.com/wp-content/uploads/2021/02/Website-Grosvenor-Gallery-London-Art-Dubai-Modern-March-20-Art-Dubai-2019-Courtesy-of-Photo-Solutions-3-1.jpg", GlrLocation = "Dubai" });
            modelBuilder.Entity<GalleryModel>().HasData(new GalleryModel { GlrId = 7, GlrName = "Volte3", GlrImg = "https://imgmediagumlet.lbb.in/media/2019/03/5c9b5aeac394967ce2d1f1f3_1553685226709.jpg?fm=webp&w=750&h=500&dpr=1", GlrLocation = "Mumbai" });
            modelBuilder.Entity<GalleryModel>().HasData(new GalleryModel { GlrId = 8, GlrName = "Gallery Chemould3", GlrImg = "https://imgmediagumlet.lbb.in/media/2019/04/5cbdad06b62ad10704e9f804_1555934470151.jpg?fm=webp&w=750&h=500&dpr=1", GlrLocation = "London" });
            modelBuilder.Entity<GalleryModel>().HasData(new GalleryModel { GlrId = 9, GlrName = "Art Dubai3", GlrImg = "https://gulfbusiness.com/wp-content/uploads/2021/02/Website-Grosvenor-Gallery-London-Art-Dubai-Modern-March-20-Art-Dubai-2019-Courtesy-of-Photo-Solutions-3-1.jpg", GlrLocation = "Dubai" });


            modelBuilder.Entity<PaintingModel>().HasData(new PaintingModel { PntId = 1, PntName = "STANDING TOGETHER", PntImg = "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/AngeloAccardi-StandingTogether.1_1_1100x.jpg?v=1596095563", PntOverview = "3D Multilayered Papercut 108x143 cm | 42x56 in Limited Edition", PntPrice = 10400 });
            modelBuilder.Entity<PaintingModel>().HasData(new PaintingModel { PntId = 2, PntName = "LOOKING DOWN", PntImg = "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/AngeloAccardi-LookingDown.1_1_1100x.jpg?v=1606219907", PntOverview = "3D Multilayered Papercut 80x100 cm | 31x39 in Limited Edition", PntPrice = 8300 });
            modelBuilder.Entity<PaintingModel>().HasData(new PaintingModel { PntId = 3, PntName = "ABBEY ROAD", PntImg = "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/AngeloAccardi-AbbeyRoad.1_860x.jpg?v=1596111743", PntOverview = "3D Multilayered Papercut 56x75 cm | 22x29 in Limited Edition", PntPrice = 5200 });

            modelBuilder.Entity<PaintingModel>().HasData(new PaintingModel { PntId = 4, PntName = "LES CORDES DE MON AME", PntImg = "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/Lescordesdemoname-2_1_1100x.jpg?v=1606229671", PntOverview = "Lacquer on metal 30x24 cm | 11x9 in Limited Editio", PntPrice = 1600 });
            modelBuilder.Entity<PaintingModel>().HasData(new PaintingModel { PntId = 5, PntName = "BOUQUET DU PARADIS", PntImg = "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/BouquetduParadis-2_1_1100x.jpg?v=1605538407", PntOverview = "Lacquer on Metal 30x24 cm | 11x9 in Limited Edition", PntPrice = 2600});
            modelBuilder.Entity<PaintingModel>().HasData(new PaintingModel { PntId = 6, PntName = "SENSIBLE COMME LES FLEURS", PntImg = "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/Sensiblecommelesfleurs-2_1_1100x.jpg?v=1606403544", PntOverview = "Lacquer on metal 30x24 cm | 11x9 in Limited Editio", PntPrice = 4600 });

            modelBuilder.Entity<PaintingModel>().HasData(new PaintingModel { PntId = 7, PntName = "COVER GIRL MARILYN MONROE", PntImg = "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/COVERGIRLMarilyn_1_1100x.jpg?v=1606836043", PntOverview = "Mixed Media Painting 120x76 cm | 47x29 in", PntPrice = 5170});
            modelBuilder.Entity<PaintingModel>().HasData(new PaintingModel { PntId = 8, PntName = "JUST A MOUSE", PntImg = "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/JUSTAMOUSE__1_1100x.jpg?v=1606833970", PntOverview = "Mixed Media Painting 40x67 cm | 15x26 in", PntPrice = 5188 });
            modelBuilder.Entity<PaintingModel>().HasData(new PaintingModel { PntId = 9, PntName = "THE LAST STAR", PntImg = "https://cdn.shopify.com/s/files/1/0436/1171/7792/products/THELASTSTAR__1_1100x.jpg?v=1606833845", PntOverview = "Mixed Media Painting 175x95 cm | 68x37 in", PntPrice = 4600});






        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<GalleryModel> Galleries { get; set; }
        public DbSet<ArtistModel> Artists { get; set; }
        public DbSet<BuyerModel> Buyers { get; set; }
        public DbSet<PaintingModel> Paintings { get; set; }
    }
}
