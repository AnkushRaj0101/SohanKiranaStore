﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SohanKiranaStore.Repository.DBContect;

#nullable disable

namespace SohanKiranaStore.Repository.Migrations
{
    [DbContext(typeof(SohanKiranaContext))]
    partial class SohanKiranaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SohanKiranaStore.Model.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Drinks and beverages",
                            Name = "Beverages"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Snacks and munchies",
                            Name = "Snacks"
                        });
                });

            modelBuilder.Entity("SohanKiranaStore.Model.Models.Description", b =>
                {
                    b.Property<int>("DescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Features")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("OtherProductInfo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("DescriptionId");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.ToTable("Descriptions");

                    b.HasData(
                        new
                        {
                            DescriptionId = 1,
                            Features = "Carbonated, Sweet",
                            OtherProductInfo = "Best served chilled",
                            ProductDescription = "Refreshing Coca Cola",
                            ProductId = 1
                        },
                        new
                        {
                            DescriptionId = 2,
                            Features = "Carbonated, Sweet",
                            OtherProductInfo = "Best served chilled",
                            ProductDescription = "Refreshing Pepsi",
                            ProductId = 2
                        },
                        new
                        {
                            DescriptionId = 3,
                            Features = "Crunchy, Salty",
                            OtherProductInfo = "Best enjoyed as a snack",
                            ProductDescription = "Crispy Lays Chips",
                            ProductId = 3
                        },
                        new
                        {
                            DescriptionId = 4,
                            Features = "Crunchy, Flavorful",
                            OtherProductInfo = "Perfect for parties",
                            ProductDescription = "Tasty Doritos",
                            ProductId = 4
                        });
                });

            modelBuilder.Entity("SohanKiranaStore.Model.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Name = "Coca Cola"
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Name = "Pepsi"
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 2,
                            Name = "Lays Chips"
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 2,
                            Name = "Doritos"
                        });
                });

            modelBuilder.Entity("SohanKiranaStore.Model.Models.ProductSize", b =>
                {
                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductId", "SizeId");

                    b.HasIndex("SizeId");

                    b.ToTable("ProductSize");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            SizeId = 1,
                            Price = 15.0m
                        },
                        new
                        {
                            ProductId = 1,
                            SizeId = 2,
                            Price = 10.0m
                        },
                        new
                        {
                            ProductId = 1,
                            SizeId = 3,
                            Price = 5.0m
                        },
                        new
                        {
                            ProductId = 2,
                            SizeId = 1,
                            Price = 15.0m
                        },
                        new
                        {
                            ProductId = 2,
                            SizeId = 2,
                            Price = 10.0m
                        },
                        new
                        {
                            ProductId = 2,
                            SizeId = 3,
                            Price = 5.0m
                        },
                        new
                        {
                            ProductId = 3,
                            SizeId = 4,
                            Price = 20.0m
                        },
                        new
                        {
                            ProductId = 3,
                            SizeId = 5,
                            Price = 10.0m
                        },
                        new
                        {
                            ProductId = 4,
                            SizeId = 4,
                            Price = 25.0m
                        },
                        new
                        {
                            ProductId = 4,
                            SizeId = 5,
                            Price = 12.5m
                        });
                });

            modelBuilder.Entity("SohanKiranaStore.Model.Models.Size", b =>
                {
                    b.Property<int>("SizeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("SizeId");

                    b.ToTable("Size");

                    b.HasData(
                        new
                        {
                            SizeId = 1,
                            Description = "1 Liter"
                        },
                        new
                        {
                            SizeId = 2,
                            Description = "500 ml"
                        },
                        new
                        {
                            SizeId = 3,
                            Description = "250 ml"
                        },
                        new
                        {
                            SizeId = 4,
                            Description = "1 Kg"
                        },
                        new
                        {
                            SizeId = 5,
                            Description = "500 grams"
                        });
                });

            modelBuilder.Entity("SohanKiranaStore.Model.Models.Description", b =>
                {
                    b.HasOne("SohanKiranaStore.Model.Models.Product", "Product")
                        .WithOne("Description")
                        .HasForeignKey("SohanKiranaStore.Model.Models.Description", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SohanKiranaStore.Model.Models.Product", b =>
                {
                    b.HasOne("SohanKiranaStore.Model.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("SohanKiranaStore.Model.Models.ProductSize", b =>
                {
                    b.HasOne("SohanKiranaStore.Model.Models.Product", "Product")
                        .WithMany("ProductSizes")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SohanKiranaStore.Model.Models.Size", "Size")
                        .WithMany("ProductSizes")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("SohanKiranaStore.Model.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("SohanKiranaStore.Model.Models.Product", b =>
                {
                    b.Navigation("Description")
                        .IsRequired();

                    b.Navigation("ProductSizes");
                });

            modelBuilder.Entity("SohanKiranaStore.Model.Models.Size", b =>
                {
                    b.Navigation("ProductSizes");
                });
#pragma warning restore 612, 618
        }
    }
}
