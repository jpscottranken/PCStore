using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PCStore.Migrations
{
    /// <inheritdoc />
    public partial class CompleteProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderTotal = table.Column<double>(type: "float", nullable: true),
                    OrderPlaced = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderDetailId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "IsProductInStock", "IsProductOnSale", "ProductDescription", "ProductImageThumbnailURL", "ProductImageURL", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 31, 1, true, false, "With the fast-moving technology changes, GIGABYTE always follows the latest trends and provides customers with advanced features and latest technologies. GIGABYTE motherboards are equipped with upgraded power solution, latest storage standards and outstanding connectivity to enable optimized performance for gaming.", "/images/product31.jpg", "/images/product31.jpg", "GIGABYTE Intel Z790 MOtherboard", 249.99000000000001 },
                    { 32, 1, true, false, "AMD B650 Motherboard with support for AMD Ryzen 7000 Series Processors. ", "/images/product32.jpg", "/images/product32.jpg", "ASRock B650 LiveMixer ATX Motherboard", 229.99000000000001 },
                    { 33, 1, true, false, "With built in gaming WiFi and support for AMD Ryzen 7000 processors, the ASUS ROG STRIX B650-A Motherboard gives you all you need to up your game.", "/images/product33.jpg", "/images/product33.jpg", "ASUS ROG STRIX B650-A Motherboard", 279.99000000000001 },
                    { 34, 1, true, false, "With the fast-moving technology changes, GIGABYTE always follows the latest trends and provides customers with advanced features and latest technologies. GIGABYTE motherboards are equipped with upgraded power solution, latest storage standards and outstanding connectivity to enable optimized performance for gaming.", "/images/product34.jpg", "/images/product34.jpg", "GIGABYTE B550 Aorus Elite Motherboard", 189.99000000000001 },
                    { 35, 1, true, false, "AMD B650 Motherboard that supports AMD Ryzen 7000 Series Processors. Comes with lightning fast WiFi so you never have to worry about slowing down.", "/images/product35.jpg", "/images/product35.jpg", "MSI MPG B650 Edge Wifi Motherboard", 259.99000000000001 },
                    { 36, 2, true, false, "The world's most advanced PC Processor. Take on any game with the pure speed of AMD Ryzen™ 5 7600X desktop processor.", "/images/product36.jpg", "/images/product36.jpg", "AMD Ryzen 5 7600X", 249.99000000000001 },
                    { 37, 2, true, false, "Get the processor that is beautifully balanced for serious PC enthusiasts with “Zen 3” architecture1. With 8 cores, 16 threads, boost clocks of up to 4.6GHz2 and 36MB of total cache, the AMD Ryzen™ 7 5700X gives you the competitive edge.", "/images/product37.jpg", "/images/product37.jpg", "AMD Ryzen 7 5700X", 178.99000000000001 },
                    { 38, 2, true, false, "Compete with confidence or get immersed in new worlds with a revolutionary processor architecture that focuses on what matters most – gaming.", "/images/product38.jpg", "/images/product38.jpg", "Intel Core i5 12600KF", 217.99000000000001 },
                    { 39, 2, true, false, "Experience the speed of AMD Ryzen™ 7 7700X desktop processor. Build a rig with the winning performance you need to dominate the games you love.", "/images/product39.jpg", "/images/product39.jpg", "AMD Ryzen 7 7700X", 399.99000000000001 },
                    { 40, 2, true, false, "Be unstoppable with the unprecedented speed of the AMD Ryzen™ 5000 G-Series desktop processors, whether you’re playing the latest games, designing the next skyscraper, or crunching scientific data. With AMD Ryzen™ desktop processors, you’re in the lead.", "/images/product40.jpg", "/images/product40.jpg", "AMD Ryzen 5 5600G", 259.99000000000001 },
                    { 41, 2, true, false, "Featuring 6 cores (12 threads), 4.40 GHz Max Turbo frequency, and based on Intel's new micro architecture, the Core i5-12400 is a stellar gaming and multi-tasking processor with best-in-class price-performance ratio.", "/images/product41.jpg", "/images/product41.jpg", "Intel Core i5 12400", 161.99000000000001 },
                    { 42, 3, true, false, "Get plenty of memory that will seamlessly integrate with your Intel or AMD-based SODIMM-compaible system.", "/images/product42.jpg", "/images/product42.jpg", "Mushkin Enhanced Redline 96GB RAM", 269.99000000000001 },
                    { 43, 3, true, false, "Modeled after a stealth aircraft, the T-FORCE DELTA RGB DDR5 delivers a refreshing visual experience and continues to offer the 120° ultra-wide lighting and clean geometric silhouette found in the DELTA RGB DDR4.", "/images/product43.jpg", "/images/product43.jpg", "Team T-Force Delta RGB 32GB RAM", 104.98999999999999 },
                    { 44, 3, true, false, "For the T-FORCE VULCAN DDR5, TEAMGROUP has adopted a gorgeous streamlines design with multi-angular to overall outline for visual aesthetics and showcase VULCAN DDR5's unique features, delivering a sleek OC gaming memory that packs a powerful performance.", "/images/product44.jpg", "/images/product44.jpg", "Team T-Force Vulcan 32GB RAM", 94.989999999999995 },
                    { 45, 3, true, false, "SPECTRIX D35G's composed and understated triangular outline is specifically designed for gamers with unique personalities.", "/images/product45.jpg", "/images/product45.jpg", "XPG Spectra RBG 16GB RAM", 47.990000000000002 },
                    { 46, 4, true, false, "The ZOTAC GAMING GeForce RTX 4070 Twin Edge is a compact and powerful graphics card, featuring the NVIDIA Ada Lovelace architecture and an aerodynamic-inspired design.", "/images/product46.jpg", "/images/product46.jpg", "ZOTAC Gaming GeForce RTX 4070 Twin Edge", 549.99000000000001 },
                    { 47, 4, true, false, "With high speeds and a sleek design that will elevate any build, you can't want for more than what the PELADN Radeon 5500XT video card can offer you.", "/images/product47.jpg", "/images/product47.jpg", "PELADN Radeon 5500XT 8GB Video Card", 199.99000000000001 },
                    { 48, 4, true, false, "Two fans that provide strong cooling performance and make your gaming rig stay cool. It’s optimized for delivering excellent gaming experience with stylish and streamlined design.", "/images/product48.jpg", "/images/product48.jpg", "ASRock Challenger Radeon RX 7700XT 12GB Video Card", 449.99000000000001 },
                    { 49, 4, true, false, "Experience unparalleled performance with the ASUS TUF Gaming GeForce RTX 3070 V2 video graphics card. With a boost clock of 1845 MHz, there is not equal in performance.", "/images/product49.jpg", "/images/product49.jpg", "ASUS TUF Gaming GeForce RTX 3070 V2", 629.99000000000001 },
                    { 50, 4, true, false, "ASUS Dual GeForce RTX™ 3050 OC Edition 8 GB GDDR6 with two powerful Axial-tech fans and a 2-slot design for broad compatibility.", "/images/product50.jpg", "/images/product50.jpg", "ASUS Dual GeForce RTX 3050", 259.99000000000001 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 50);
        }
    }
}
