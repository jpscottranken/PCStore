using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PCStore.Migrations
{
    /// <inheritdoc />
    public partial class InitialSetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductImageURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductImageThumbnailURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsProductOnSale = table.Column<bool>(type: "bit", nullable: false),
                    IsProductInStock = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingCartItems",
                columns: table => new
                {
                    ShoppingCartItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShoppingCartId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingCartItems", x => x.ShoppingCartItemId);
                    table.ForeignKey(
                        name: "FK_ShoppingCartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 1, "", "Motherboard" },
                    { 2, "", "Processor" },
                    { 3, "", "Memory" },
                    { 4, "", "Video Graphics Card" },
                    { 5, "", "Case" },
                    { 6, "", "Power Supply" },
                    { 7, "", "Storage" },
                    { 8, "", "Accessory" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "IsProductInStock", "IsProductOnSale", "ProductDescription", "ProductImageThumbnailURL", "ProductImageURL", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 1, 1, true, true, "Buffed and ready with more power, robust cooling, and flexible I/O to scale up your rig at will. The ROG Maximus Z790 Hero puts it all at your disposal together with an arsenal of features and utilities to truly express the PC builder, overclocker, and gaming hero in you.", "/images/product01.jpg", "/images/product01.jpg", "ASUS ROG Maximus Z790 Hero", 609.99000000000001 },
                    { 2, 1, true, false, "Featurign Core Boost Technology, 6 layer PCB, and the highest quality power delivery components, the MSI MAG B550 Tomahawk gives you unmatched performance at an unbeatable price.", "/images/product02.jpg", "/images/product02.jpg", "MSI MAG B550 Tomahawk", 169.99000000000001 },
                    { 3, 1, true, false, "ROG Strix Z690-E Gaming Wi-Fi puts 12th Gen Intel® Core™ processors at center stage, with beefed-up power delivery, cooling, cutting-edge connectivity options, and a range of accoutrements that effortlessly propel builds to maximum performance. This series flagship is your ticket to next-level gaming.", "/images/product03.jpg", "/images/product03.jpg", "ASUS ROG Strix Z690-E", 279.99000000000001 },
                    { 4, 2, true, false, "Get the competitive edge with 12 cores, 24 threads, boost clocks of up to 4.8GHz2 and 70MB of cache.", "/images/product04.jpg", "/images/product04.jpg", "AMD Ryzen 9 5900X", 549.99000000000001 },
                    { 5, 2, true, false, "Blazing-fast clock speeds and a revolutionary core architecture allow you to seamlessly chat, stream and record without sacrificing gameplay.", "/images/product05.jpg", "/images/product05.jpg", "Intel Core i7-12700K", 449.99000000000001 },
                    { 6, 2, true, false, "With the highest clock speeds and a groundbreaking new architecture, you’ll be able to push your gameplay to new heights while secondary apps run seamlessly in the background.", "/images/product06.jpg", "/images/product06.jpg", "Intel Core i9-12700K", 649.99000000000001 },
                    { 7, 3, true, false, "As the latest addition to the classic RipJaws family, RipJaws V series DDR4 memory is designed for sleek aesthetics and performance. Ripjaws V is the ideal choice for building a new performance system or for DRAM memory upgrade.", "/images/product07.jpg", "/images/product07.jpg", "G.SKILL Ripjaws V Series 32 GB", 64.989999999999995 },
                    { 8, 3, true, false, "Speed up loading times, boost system responsiveness, and improve your computers ability to handle greater workloads with Nemix Ram's 32GB kit.", "/images/product08.jpg", "/images/product08.jpg", "Nemix Ram 32GB Kit", 97.989999999999995 },
                    { 9, 3, true, false, "VENGEANCE LPX memory is designed for high-performance overclocking. Whether you're breaking your own records or you're simply building a dream gaming rig, you can count on CORSAIR memory.", "/images/product09.jpg", "/images/product09.jpg", "Corsair Vengeance LPX 16GB", 51.990000000000002 },
                    { 10, 4, true, false, "Granting peak performance at an affordable price, the best selling MSI Ventus GeForce RTX 3060 is a must have for newcomers and enthusiasts alike.", "/images/product10.jpg", "/images/product10.jpg", "MSI Ventus GeForce RTX 3060", 289.99000000000001 },
                    { 11, 4, true, false, "Looking to power up your rig? Look no further than the GIGABYTE Gaming OC RTX 3070. Offering NVIDIA multiprocessors, Windforce cooling systems, and a 1815 MHz core clock, this card offers unparalleled performance.", "/images/product11.jpg", "/images/product11.jpg", "GIGABYTE Gaming OC GeForce 3070", 569.99000000000001 },
                    { 12, 4, true, false, "Get equipped to play the newest games at the highest settings with 12GB of GDDR6 memory and 40 enhanced compute units delivering 1440p gaming at ultra settings with smooth framerates and maximum visual settings.", "/images/product12.jpg", "/images/product12.jpg", "ASRock Radeon RX 6700 XT", 329.99000000000001 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingCartItems_ProductId",
                table: "ShoppingCartItems",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
