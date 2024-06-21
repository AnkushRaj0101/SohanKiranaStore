using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SohanKiranaStore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SohankiranastoreInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    CreatedBy = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    SizeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.SizeId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CategoryImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ImageData = table.Column<byte[]>(type: "longblob", nullable: false),
                    ImageType = table.Column<string>(type: "longtext", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryImages_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedBy = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Descriptions",
                columns: table => new
                {
                    DescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProductDescription = table.Column<string>(type: "longtext", nullable: true),
                    Features = table.Column<string>(type: "longtext", nullable: true),
                    OtherProductInfo = table.Column<string>(type: "longtext", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Descriptions", x => x.DescriptionId);
                    table.ForeignKey(
                        name: "FK_Descriptions_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductSize",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSize", x => new { x.ProductId, x.SizeId });
                    table.ForeignKey(
                        name: "FK_ProductSize_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSize_Size_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Size",
                        principalColumn: "SizeId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedBy", "Description", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1034), "Drinks and beverages", "Beverages", new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1037) },
                    { 2, new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1039), "Snacks and munchies", "Snacks", new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1039) }
                });

            migrationBuilder.InsertData(
                table: "Size",
                columns: new[] { "SizeId", "Description" },
                values: new object[,]
                {
                    { 1, "1 Liter" },
                    { 2, "500 ml" },
                    { 3, "250 ml" },
                    { 4, "1 Kg" },
                    { 5, "500 grams" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CreatedBy", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1133), "Coca Cola", new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1134) },
                    { 2, 1, new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1135), "Pepsi", new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1135) },
                    { 3, 2, new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1136), "Lays Chips", new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1136) },
                    { 4, 2, new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1137), "Doritos", new DateTime(2024, 6, 20, 13, 32, 49, 846, DateTimeKind.Utc).AddTicks(1137) }
                });

            migrationBuilder.InsertData(
                table: "Descriptions",
                columns: new[] { "DescriptionId", "Features", "OtherProductInfo", "ProductDescription", "ProductId" },
                values: new object[,]
                {
                    { 1, "Carbonated, Sweet", "Best served chilled", "Refreshing Coca Cola", 1 },
                    { 2, "Carbonated, Sweet", "Best served chilled", "Refreshing Pepsi", 2 },
                    { 3, "Crunchy, Salty", "Best enjoyed as a snack", "Crispy Lays Chips", 3 },
                    { 4, "Crunchy, Flavorful", "Perfect for parties", "Tasty Doritos", 4 }
                });

            migrationBuilder.InsertData(
                table: "ProductSize",
                columns: new[] { "ProductId", "SizeId", "Discount", "NetPrice", "Price", "Status" },
                values: new object[,]
                {
                    { 1, 1, 0, 15.0m, 15.0m, "Available" },
                    { 1, 2, 0, 10.0m, 10.0m, "Available" },
                    { 1, 3, 0, 5.0m, 5.0m, "Available" },
                    { 2, 1, 0, 15.0m, 15.0m, "Available" },
                    { 2, 2, 0, 10.0m, 10.0m, "Available" },
                    { 2, 3, 0, 5.0m, 5.0m, "Available" },
                    { 3, 4, 0, 20.0m, 20.0m, "Available" },
                    { 3, 5, 0, 10.0m, 10.0m, "Available" },
                    { 4, 4, 0, 25.0m, 25.0m, "Available" },
                    { 4, 5, 0, 12.5m, 12.5m, "Available" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryImages_CategoryId",
                table: "CategoryImages",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Descriptions_ProductId",
                table: "Descriptions",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSize_SizeId",
                table: "ProductSize",
                column: "SizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryImages");

            migrationBuilder.DropTable(
                name: "Descriptions");

            migrationBuilder.DropTable(
                name: "ProductSize");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Size");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
