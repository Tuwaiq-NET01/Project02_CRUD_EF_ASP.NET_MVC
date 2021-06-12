﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Music_Website.Data;

namespace Music_Website.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210612013507_seedingprofile")]
    partial class seedingprofile
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Music_Website.Models.MusicModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Music_image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileId")
                        .HasColumnType("int");

                    b.Property<string>("audio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("Musics");
                });

            modelBuilder.Entity("Music_Website.Models.ProfileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Background_Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Background_Image = "https://images.pexels.com/photos/946351/pexels-photo-946351.jpeg?w=500&h=650&auto=compress&cs=tinysrgb",
                            Image = "https://res.cloudinary.com/crunchbase-production/image/upload/c_thumb,h_256,w_256,f_auto,g_faces,z_0.7,q_auto:eco/tluillv6dybajfj7i0dq",
                            Name = "Kirsten Korosec",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Background_Image = "https://images.pexels.com/photos/3692749/pexels-photo-3692749.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            Image = "https://media-cldnry.s-nbcnews.com/image/upload/newscms/2014_01/95471/2503781351_7feef38a1a_b-95471.jpg",
                            Name = "Devin Coldewey",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Background_Image = "https://images.pexels.com/photos/4500796/pexels-photo-4500796.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500",
                            Image = "https://www.monteirolobato.edu.br/public/assets/admin/images/avatars/avatar5_big.png",
                            Name = "Rebecca Bellan",
                            UserId = 3
                        });
                });

            modelBuilder.Entity("Music_Website.Models.RateModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MusicId")
                        .HasColumnType("int");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MusicId")
                        .IsUnique();

                    b.ToTable("Rate");
                });

            modelBuilder.Entity("Music_Website.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "AAJ@gmail.com",
                            username = "AAJ"
                        },
                        new
                        {
                            Id = 2,
                            Email = "user2@gmail.com",
                            username = "user2"
                        },
                        new
                        {
                            Id = 3,
                            Email = "user3@gmail.com",
                            username = "user3"
                        });
                });

            modelBuilder.Entity("Music_Website.Models.MusicModel", b =>
                {
                    b.HasOne("Music_Website.Models.ProfileModel", "Profile")
                        .WithMany("Musics")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Music_Website.Models.ProfileModel", b =>
                {
                    b.HasOne("Music_Website.Models.UserModel", "User")
                        .WithOne("Profile")
                        .HasForeignKey("Music_Website.Models.ProfileModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Music_Website.Models.RateModel", b =>
                {
                    b.HasOne("Music_Website.Models.MusicModel", "Music")
                        .WithOne("Rate")
                        .HasForeignKey("Music_Website.Models.RateModel", "MusicId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
