﻿// <auto-generated />
using System;
using BookStoreCRUDApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStoreCRUDApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210612073703_BookAuthorTable")]
    partial class BookAuthorTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStoreCRUDApp.Models.AuthorModel", b =>
                {
                    b.Property<int>("AuthorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AuthorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorFirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorID");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorID = 1,
                            AuthorEmail = "Andrea@mail.com",
                            AuthorFirstName = "Andrea",
                            AuthorLastName = "Arbasi",
                            Notes = "This author has written great"
                        },
                        new
                        {
                            AuthorID = 2,
                            AuthorEmail = "Jan@mail.com",
                            AuthorFirstName = "Jan",
                            AuthorLastName = "Wengro",
                            Notes = "This author has written great"
                        },
                        new
                        {
                            AuthorID = 3,
                            AuthorEmail = "Pon@mail.com",
                            AuthorFirstName = "Pon",
                            AuthorLastName = "Pattren",
                            Notes = "This author has written great"
                        },
                        new
                        {
                            AuthorID = 4,
                            AuthorEmail = "Alexander@mail.com",
                            AuthorFirstName = " Alexander",
                            AuthorLastName = "Jony",
                            Notes = "This author has written great"
                        },
                        new
                        {
                            AuthorID = 5,
                            AuthorEmail = "Mikel@mail.com",
                            AuthorFirstName = "Mikel",
                            AuthorLastName = "Jon",
                            Notes = "This author has written great"
                        },
                        new
                        {
                            AuthorID = 6,
                            AuthorEmail = "Murray@mail.com",
                            AuthorFirstName = " Murray",
                            AuthorLastName = "Silverstein",
                            Notes = "This author has written great"
                        });
                });

            modelBuilder.Entity("BookStoreCRUDApp.Models.BookModel", b =>
                {
                    b.Property<int>("BookID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BookStoreModelIdBookStore")
                        .HasColumnType("int");

                    b.Property<int>("IdBookStore")
                        .HasColumnType("int");

                    b.Property<int>("NoPage")
                        .HasColumnType("int");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookID");

                    b.HasIndex("BookStoreModelIdBookStore");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookID = 1,
                            IdBookStore = 1,
                            NoPage = 530,
                            Notes = "Good Book !",
                            Price = 103.5f,
                            Title = "Opertaing System"
                        },
                        new
                        {
                            BookID = 2,
                            IdBookStore = 1,
                            NoPage = 400,
                            Notes = "boring book",
                            Price = 99.5f,
                            Title = "Data Structure"
                        },
                        new
                        {
                            BookID = 3,
                            IdBookStore = 1,
                            NoPage = 500,
                            Notes = "Interesting book",
                            Price = 300.5f,
                            Title = "Software Testing"
                        },
                        new
                        {
                            BookID = 4,
                            IdBookStore = 2,
                            NoPage = 300,
                            Notes = "boring book",
                            Price = 200.9f,
                            Title = "Design Pattren"
                        },
                        new
                        {
                            BookID = 5,
                            IdBookStore = 2,
                            NoPage = 250,
                            Notes = "A very useful book",
                            Price = 90.5f,
                            Title = "Learn How To Learn"
                        },
                        new
                        {
                            BookID = 6,
                            IdBookStore = 2,
                            NoPage = 100,
                            Notes = "Interesting book",
                            Price = 88.5f,
                            Title = "Act Like A Success"
                        });
                });

            modelBuilder.Entity("BookStoreCRUDApp.Models.BookStoreModel", b =>
                {
                    b.Property<int>("IdBookStore")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmailOfBookStore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameOfBookStore")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdBookStore");

                    b.ToTable("BookStore");

                    b.HasData(
                        new
                        {
                            IdBookStore = 1,
                            EmailOfBookStore = "bs-r@mail.com",
                            Location = "Al-Hamra-Riyadh",
                            NameOfBookStore = " Jarir",
                            Telephone = "011984430"
                        },
                        new
                        {
                            IdBookStore = 2,
                            EmailOfBookStore = "bs-j@mail.com",
                            Location = "Al-Manar-Jeddah",
                            NameOfBookStore = " Jarir",
                            Telephone = "01488994"
                        });
                });

            modelBuilder.Entity("BookStoreCRUDApp.Models.Book_Author", b =>
                {
                    b.Property<int>("BAId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorID")
                        .HasColumnType("int");

                    b.Property<int?>("AuthorModelAuthorID")
                        .HasColumnType("int");

                    b.Property<int>("BookID")
                        .HasColumnType("int");

                    b.Property<int?>("BookModelBookID")
                        .HasColumnType("int");

                    b.HasKey("BAId");

                    b.HasIndex("AuthorModelAuthorID");

                    b.HasIndex("BookModelBookID");

                    b.ToTable("BookAuthor");
                });

            modelBuilder.Entity("BookStoreCRUDApp.Models.BookModel", b =>
                {
                    b.HasOne("BookStoreCRUDApp.Models.BookStoreModel", null)
                        .WithMany("BookModel")
                        .HasForeignKey("BookStoreModelIdBookStore");
                });

            modelBuilder.Entity("BookStoreCRUDApp.Models.Book_Author", b =>
                {
                    b.HasOne("BookStoreCRUDApp.Models.AuthorModel", null)
                        .WithMany("BookAuthor")
                        .HasForeignKey("AuthorModelAuthorID");

                    b.HasOne("BookStoreCRUDApp.Models.BookModel", null)
                        .WithMany("BookAuthor")
                        .HasForeignKey("BookModelBookID");
                });
#pragma warning restore 612, 618
        }
    }
}
