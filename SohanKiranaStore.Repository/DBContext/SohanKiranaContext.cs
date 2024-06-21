using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;
using SohanKiranaStore.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SohanKiranaStore.Repository.DBContect
{
    public class SohanKiranaContext : DbContext
    {
        public SohanKiranaContext(DbContextOptions<SohanKiranaContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<CategoryImage> CategoryImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Description> Descriptions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure many-to-many relationship
            modelBuilder.Entity<ProductSize>()
                .HasKey(ps => new { ps.ProductId, ps.SizeId });

            modelBuilder.Entity<ProductSize>()
                .HasOne(ps => ps.Product)
                .WithMany(p => p.ProductSizes)
                .HasForeignKey(ps => ps.ProductId);

            modelBuilder.Entity<ProductSize>()
                .HasOne(ps => ps.Size)
                .WithMany(s => s.ProductSizes)
                .HasForeignKey(ps => ps.SizeId);

            // Seed data for Categories
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    Name = "Beverages",
                    Description = "Drinks and beverages",
                    CreatedBy = DateTime.UtcNow,
                    UpdatedBy = DateTime.UtcNow
                },
                new Category
                {
                    Id = 2,
                    Name = "Snacks",
                    Description = "Snacks and munchies",
                    CreatedBy = DateTime.UtcNow,
                    UpdatedBy = DateTime.UtcNow
                }
            );

            // Seed data for Sizes
            modelBuilder.Entity<Size>().HasData(
                new Size { SizeId = 1, Description = "1 Liter" },
                new Size { SizeId = 2, Description = "500 ml" },
                new Size { SizeId = 3, Description = "250 ml" },
                new Size { SizeId = 4, Description = "1 Kg" },
                new Size { SizeId = 5, Description = "500 grams" }
            );

            // Seed data for Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "Coca Cola",
                    CategoryId = 1,
                    CreatedBy = DateTime.UtcNow,
                    UpdatedBy = DateTime.UtcNow
                },
                new Product
                {
                    ProductId = 2,
                    Name = "Pepsi",
                    CategoryId = 1,
                    CreatedBy = DateTime.UtcNow,
                    UpdatedBy = DateTime.UtcNow
                },
                new Product
                {
                    ProductId = 3,
                    Name = "Lays Chips",
                    CategoryId = 2,
                    CreatedBy = DateTime.UtcNow,
                    UpdatedBy = DateTime.UtcNow
                },
                new Product
                {
                    ProductId = 4,
                    Name = "Doritos",
                    CategoryId = 2,
                    CreatedBy = DateTime.UtcNow,
                    UpdatedBy = DateTime.UtcNow
                }
            );

            // Seed data for Descriptions
            modelBuilder.Entity<Description>().HasData(
                new Description
                {
                    DescriptionId = 1,
                    ProductId = 1,
                    ProductDescription = "Refreshing Coca Cola",
                    Features = "Carbonated, Sweet",
                    OtherProductInfo = "Best served chilled"
                },
                new Description
                {
                    DescriptionId = 2,
                    ProductId = 2,
                    ProductDescription = "Refreshing Pepsi",
                    Features = "Carbonated, Sweet",
                    OtherProductInfo = "Best served chilled"
                },
                new Description
                {
                    DescriptionId = 3,
                    ProductId = 3,
                    ProductDescription = "Crispy Lays Chips",
                    Features = "Crunchy, Salty",
                    OtherProductInfo = "Best enjoyed as a snack"
                },
                new Description
                {
                    DescriptionId = 4,
                    ProductId = 4,
                    ProductDescription = "Tasty Doritos",
                    Features = "Crunchy, Flavorful",
                    OtherProductInfo = "Perfect for parties"
                }
            );

            // Seed data for ProductSizes
            modelBuilder.Entity<ProductSize>().HasData(
                new ProductSize
                {
                    ProductId = 1,
                    SizeId = 1,
                    Price = 15.0M,
                    NetPrice = 15.0M,
                    Discount = 0,
                    Status = "Available"
                },
                new ProductSize
                {
                    ProductId = 1,
                    SizeId = 2,
                    Price = 10.0M,
                    NetPrice = 10.0M,
                    Discount = 0,
                    Status = "Available"
                },
                new ProductSize
                {
                    ProductId = 1,
                    SizeId = 3,
                    Price = 5.0M,
                    NetPrice = 5.0M,
                    Discount = 0,
                    Status = "Available"
                },
                new ProductSize
                {
                    ProductId = 2,
                    SizeId = 1,
                    Price = 15.0M,
                    NetPrice = 15.0M,
                    Discount = 0,
                    Status = "Available"
                },
                new ProductSize
                {
                    ProductId = 2,
                    SizeId = 2,
                    Price = 10.0M,
                    NetPrice = 10.0M,
                    Discount = 0,
                    Status = "Available"
                },
                new ProductSize
                {
                    ProductId = 2,
                    SizeId = 3,
                    Price = 5.0M,
                    NetPrice = 5.0M,
                    Discount = 0,
                    Status = "Available"
                },
                new ProductSize
                {
                    ProductId = 3,
                    SizeId = 4,
                    Price = 20.0M,
                    NetPrice = 20.0M,
                    Discount = 0,
                    Status = "Available"
                },
                new ProductSize
                {
                    ProductId = 3,
                    SizeId = 5,
                    Price = 10.0M,
                    NetPrice = 10.0M,
                    Discount = 0,
                    Status = "Available"
                },
                new ProductSize
                {
                    ProductId = 4,
                    SizeId = 4,
                    Price = 25.0M,
                    NetPrice = 25.0M,
                    Discount = 0,
                    Status = "Available"
                },
                new ProductSize
                {
                    ProductId = 4,
                    SizeId = 5,
                    Price = 12.5M,
                    NetPrice = 12.5M,
                    Discount = 0,
                    Status = "Available"
                }
            );
        }
    }
}
