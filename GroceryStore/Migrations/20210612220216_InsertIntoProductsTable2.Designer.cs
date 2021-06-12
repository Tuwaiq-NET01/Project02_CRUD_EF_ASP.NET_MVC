﻿// <auto-generated />
using GroceryStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GroceryStore.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20210612220216_InsertIntoProductsTable2")]
    partial class InsertIntoProductsTable2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GroceryStore.Models.Branch", b =>
                {
                    b.Property<int>("BranchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BranchId");

                    b.ToTable("Branches");

                    b.HasData(
                        new
                        {
                            BranchId = 1,
                            Address = "Riyadh",
                            Name = "Norah Grocery"
                        },
                        new
                        {
                            BranchId = 2,
                            Address = "Dammam",
                            Name = "Norah Grocery"
                        },
                        new
                        {
                            BranchId = 3,
                            Address = "Jeddah",
                            Name = "Norah Grocery"
                        });
                });

            modelBuilder.Entity("GroceryStore.Models.BranchProduct", b =>
                {
                    b.Property<int>("BranchId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("BranchId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("BranchProduct");

                    b.HasData(
                        new
                        {
                            BranchId = 1,
                            ProductId = 1
                        },
                        new
                        {
                            BranchId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            BranchId = 3,
                            ProductId = 2
                        },
                        new
                        {
                            BranchId = 2,
                            ProductId = 2
                        },
                        new
                        {
                            BranchId = 2,
                            ProductId = 3
                        },
                        new
                        {
                            BranchId = 1,
                            ProductId = 2
                        });
                });

            modelBuilder.Entity("GroceryStore.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "Jeddah, Al Marwah, Saeed Albasri street",
                            Email = "norah@outlook.sa",
                            FirstName = "Norah",
                            LastName = "Almutairi",
                            Phone = "0534355512"
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "Riyadh, Al Narjis, Alsalamah street",
                            Email = "Maha@outlook.sa",
                            FirstName = "Maha",
                            LastName = "Alzahrani",
                            Phone = "0565355519"
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "Dammam, Al Rawdah, Malik Ibn Jubair street",
                            Email = "Mona@outlook.sa",
                            FirstName = "Mona",
                            LastName = "Alghamdi",
                            Phone = "0535366514"
                        });
                });

            modelBuilder.Entity("GroceryStore.Models.CustomerProduct", b =>
                {
                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("CustomerId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerProduct");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            ProductId = 2
                        },
                        new
                        {
                            CustomerId = 2,
                            ProductId = 1
                        },
                        new
                        {
                            CustomerId = 2,
                            ProductId = 2
                        },
                        new
                        {
                            CustomerId = 3,
                            ProductId = 1
                        },
                        new
                        {
                            CustomerId = 3,
                            ProductId = 2
                        },
                        new
                        {
                            CustomerId = 3,
                            ProductId = 3
                        });
                });

            modelBuilder.Entity("GroceryStore.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Image = "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/170x165/9df78eab33525d08d6e5fb8d27136e95/1/3/132.jpg",
                            Name = "Apple",
                            Price = 1.5f
                        },
                        new
                        {
                            ProductId = 2,
                            Image = "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/340x330/9df78eab33525d08d6e5fb8d27136e95/o/r/orange-2.jpg",
                            Name = "Orange",
                            Price = 1.5f
                        },
                        new
                        {
                            ProductId = 3,
                            Image = "https://www.othaimmarkets.com/media/catalog/product/cache/4/small_image/340x330/9df78eab33525d08d6e5fb8d27136e95/5/0/500_0.jpg",
                            Name = "Banana",
                            Price = 3.5f
                        });
                });

            modelBuilder.Entity("GroceryStore.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CustomerId = 1,
                            Password = "sfs34",
                            UserName = "Norah123"
                        },
                        new
                        {
                            Id = 2,
                            CustomerId = 2,
                            Password = "maha222",
                            UserName = "Mahaaz"
                        },
                        new
                        {
                            Id = 3,
                            CustomerId = 3,
                            Password = "Moon66",
                            UserName = "Moon"
                        });
                });

            modelBuilder.Entity("GroceryStore.Models.BranchProduct", b =>
                {
                    b.HasOne("GroceryStore.Models.Branch", "Branch")
                        .WithMany("BranchProduct")
                        .HasForeignKey("BranchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroceryStore.Models.Product", "Product")
                        .WithMany("BranchProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Branch");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GroceryStore.Models.CustomerProduct", b =>
                {
                    b.HasOne("GroceryStore.Models.Customer", "Customer")
                        .WithMany("CustomerProduct")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GroceryStore.Models.Product", "Product")
                        .WithMany("CustomerProduct")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("GroceryStore.Models.User", b =>
                {
                    b.HasOne("GroceryStore.Models.Customer", "Customer")
                        .WithOne("User")
                        .HasForeignKey("GroceryStore.Models.User", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("GroceryStore.Models.Branch", b =>
                {
                    b.Navigation("BranchProduct");
                });

            modelBuilder.Entity("GroceryStore.Models.Customer", b =>
                {
                    b.Navigation("CustomerProduct");

                    b.Navigation("User");
                });

            modelBuilder.Entity("GroceryStore.Models.Product", b =>
                {
                    b.Navigation("BranchProduct");

                    b.Navigation("CustomerProduct");
                });
#pragma warning restore 612, 618
        }
    }
}
