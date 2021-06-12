using Microsoft.EntityFrameworkCore;
using Music_Website.Models;

namespace Music_Website.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<ProfileModel> Profiles { get; set; }

        public DbSet<MusicModel> Musics { get; set; }

        public DbSet<RateModel> Rate { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id = 1, username = "AAJ", Email = "AAJ@gmail.com" });
            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id = 2, username = "user2", Email = "user2@gmail.com" });
            modelBuilder.Entity<UserModel>().HasData(new UserModel { Id = 3, username = "user3", Email = "user3@gmail.com" });


            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { Id = 1, Name = "Kirsten Korosec", Image = "https://res.cloudinary.com/crunchbase-production/image/upload/c_thumb,h_256,w_256,f_auto,g_faces,z_0.7,q_auto:eco/tluillv6dybajfj7i0dq", Background_Image = "https://images.pexels.com/photos/946351/pexels-photo-946351.jpeg?w=500&h=650&auto=compress&cs=tinysrgb", UserId = 1 });
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { Id = 2, Name = "Devin Coldewey", Image = "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2014_01/95471/2503781351_7feef38a1a_b-95471.jpg", Background_Image = "https://images.pexels.com/photos/3692749/pexels-photo-3692749.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",  UserId = 2 });
            modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { Id = 3, Name = "Rebecca Bellan", Image = "https://www.monteirolobato.edu.br/public/assets/admin/images/avatars/avatar5_big.png", Background_Image = "https://images.pexels.com/photos/4500796/pexels-photo-4500796.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",  UserId = 3 });

            //Seeding Music
            modelBuilder.Entity<MusicModel>().HasData(new MusicModel { Id = 1, title = "David Davis", audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613571243/zwz1nov81nhkbnnj6e6i.mp3", Music_image = "https://m.media-amazon.com/images/I/514gcbVy-QL._SL500_.jpg", description = "The official music video for Ocean by David Davis. Connect with David online. Instagram: @justdaviddavis Facebook: facebook.com/justdaviddavis Website: justdaviddavis.com/ TikTok: tiktok.com/@justdaviddavis", ProfileId = 1 });
            modelBuilder.Entity<MusicModel>().HasData(new MusicModel { Id = 2, title = "Don't give up", audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613598562/zjxp5qcsetep7pyog0ki.mp3", Music_image = "https://res.cloudinary.com/duuconncq/image/upload/v1613598303/jkkshf0yiwrp5d3mz7ec.jpg", description = "Don't cry to give up , cry to be successful", ProfileId = 1 });
            modelBuilder.Entity<MusicModel>().HasData(new MusicModel { Id = 3, title = "RENAE - Rome", audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1622012633/wbjs3c7yi4wnbuav3mjm.mp3", Music_image = "https://cdns-images.dzcdn.net/images/cover/77129041df87e78752bd3dc2cc841912/500x500.jpg", description = "Zodiac Songs: RENAE - Rome (Capricorn)", ProfileId = 1 });
            modelBuilder.Entity<MusicModel>().HasData(new MusicModel { Id = 4, title = "Stars", audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613571243/zwz1nov81nhkbnnj6e6i.mp3", Music_image = "https://res.cloudinary.com/duuconncq/image/upload/v1622845572/img_4_uhkpiv.jpg", description = "Lovely life", ProfileId = 2 });

            //Seeding Rating
            modelBuilder.Entity<RateModel>().HasData(new RateModel { Id = 1, score = 3, MusicId = 1 });
            modelBuilder.Entity<RateModel>().HasData(new RateModel { Id = 2, score = 5, MusicId = 2 });
            modelBuilder.Entity<RateModel>().HasData(new RateModel { Id = 3, score = 4, MusicId = 3 });
            modelBuilder.Entity<RateModel>().HasData(new RateModel { Id = 4, score = 2, MusicId = 4 });


        }

        /*
                protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                    //Seeding user
                    UserModel user1 = new UserModel { Id = 1, username = "AAJ", Email = "AAJ@gmail.com" };
                    UserModel user2 = new UserModel { Id = 2, username = "user2", Email = "user2@gmail.com" };
                    UserModel user3 = new UserModel { Id = 3, username = "user3", Email = "user3@gmail.com" };
                    modelBuilder.Entity<UserModel>().HasData(user1);
                    modelBuilder.Entity<UserModel>().HasData(user2);
                    modelBuilder.Entity<UserModel>().HasData(user3);

                    modelBuilder.Entity<UserModel>(builder =>
                    {
                        builder.HasData(user1);
                        builder.OwnsOne(user => user.Profile).HasData(new ProfileModel
                        {
                            Id = 1,
                            Name = "Rebecca Bellan",
                            Image = "https://www.monteirolobato.edu.br/public/assets/admin/images/avatars/avatar5_big.png",
                            Background_Image = "https://images.pexels.com/photos/4500796/pexels-photo-4500796.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            UserId = user1.Id
                        });
                    });


                    //Seeding Profile
                    /*modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { ProfileId = 1, Name = "Kirsten Korosec", Image = "https://res.cloudinary.com/crunchbase-production/image/upload/c_thumb,h_256,w_256,f_auto,g_faces,z_0.7,q_auto:eco/tluillv6dybajfj7i0dq", Background_Image = "https://images.pexels.com/photos/946351/pexels-photo-946351.jpeg?w=500&h=650&auto=compress&cs=tinysrgb", UserId=user1.Id});
                    modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { ProfileId = 2, Name = "Devin Coldewey", Image = "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2014_01/95471/2503781351_7feef38a1a_b-95471.jpg", Background_Image = "https://images.pexels.com/photos/3692749/pexels-photo-3692749.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", User=user2, UserId=user2.Id});
                    modelBuilder.Entity<ProfileModel>().HasData(new ProfileModel { ProfileId = 3, Name = "Rebecca Bellan", Image = "https://www.monteirolobato.edu.br/public/assets/admin/images/avatars/avatar5_big.png", Background_Image = "https://images.pexels.com/photos/4500796/pexels-photo-4500796.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500", User=user3 , UserId=user3.Id});

    }

    //Seeding Music
    modelBuilder.Entity<MusicModel>().HasData(new MusicModel { Id = 1, title = "David Davis", audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613571243/zwz1nov81nhkbnnj6e6i.mp3", Music_image = "https://m.media-amazon.com/images/I/514gcbVy-QL._SL500_.jpg", description = "The official music video for Ocean by David Davis. Connect with David online. Instagram: @justdaviddavis Facebook: facebook.com/justdaviddavis Website: justdaviddavis.com/ TikTok: tiktok.com/@justdaviddavis", ProfileId = 1 });
                modelBuilder.Entity<MusicModel>().HasData(new MusicModel { Id = 2, title = "Don't give up", audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613598562/zjxp5qcsetep7pyog0ki.mp3", Music_image = "https://res.cloudinary.com/duuconncq/image/upload/v1613598303/jkkshf0yiwrp5d3mz7ec.jpg", description = "Don't cry to give up , cry to be successful", ProfileId = 1 });
                modelBuilder.Entity<MusicModel>().HasData(new MusicModel { Id = 3, title = "RENAE - Rome", audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1622012633/wbjs3c7yi4wnbuav3mjm.mp3", Music_image = "https://cdns-images.dzcdn.net/images/cover/77129041df87e78752bd3dc2cc841912/500x500.jpg", description = "Zodiac Songs: RENAE - Rome (Capricorn)", ProfileId = 1 });

                //Seeding Rating
                modelBuilder.Entity<RateModel>().HasData(new RateModel { Id = 1, score = 3, MusicId = 1 });
                modelBuilder.Entity<RateModel>().HasData(new RateModel { Id = 2, score = 5, MusicId = 2 });
                modelBuilder.Entity<RateModel>().HasData(new RateModel { Id = 3, score = 4, MusicId = 3 });

                //Seeding Music
                modelBuilder.Entity<MusicModel>().HasData(new MusicModel { Id = 4, title = "Stars", audio = "https://res.cloudinary.com/dhuxwxtfm/video/upload/v1613571243/zwz1nov81nhkbnnj6e6i.mp3", Music_image = "https://res.cloudinary.com/duuconncq/image/upload/v1622845572/img_4_uhkpiv.jpg", description = "Lovely life", ProfileId = 2 });

                //Seeding Rating
                modelBuilder.Entity<RateModel>().HasData(new RateModel { Id = 4, score = 2, MusicId = 4 });
            */
    }
}
