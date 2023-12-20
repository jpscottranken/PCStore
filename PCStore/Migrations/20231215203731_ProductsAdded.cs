using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PCStore.Migrations
{
    /// <inheritdoc />
    public partial class ProductsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CategoryName",
                value: "Storage");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CategoryName",
                value: "Accessory");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "IsProductInStock", "IsProductOnSale", "ProductDescription", "ProductImageThumbnailURL", "ProductImageURL", "ProductName", "ProductPrice" },
                values: new object[,]
                {
                    { 13, 5, true, true, "Purpose built for multi-user NAS environments, Seagate IronWolf drives are perfect for teams needing to store more and work faster.", "/images/product13.jpg", "/images/product13.jpg", "Seagate IronWolf 12TB NAS Harddrive Internal HDD", 359.99000000000001 },
                    { 14, 5, true, false, "Perfect for reliable, everyday computing with Western Digital quality and reliability.", "/images/product14.jpg", "/images/product14.jpg", "WD Blue 500GB Desktop Hard Disk Drive", 59.990000000000002 },
                    { 15, 5, true, false, "Cost effective storage for laptop or desktop computers. Store all your games, music, movies and more with up to 8TB of storage.", "/images/product15.jpg", "/images/product15.jpg", "Seagate BarraCude 8TB SATA Internal Hard Drive", 189.99000000000001 },
                    { 16, 5, true, true, "Compatible with PC, desktop, laptop, Xbox One, and PS4. Plug and play - no software to install and ready to use.", "/images/product16.jpg", "/images/product16.jpg", "UnionSine 1TB Ultra Slim Portable External Hard Drive", 55.990000000000002 },
                    { 17, 5, true, false, "With massive capacity and innovative technology advancements, this Exos X18 enterprise hard drive is engineered to address the needs of the hyperscale storage market.", "/images/product17.jpg", "/images/product17.jpg", "Seagate 18TB Exos Enterprise Hard Drive HDD", 399.99000000000001 },
                    { 18, 5, true, false, "Compatible with all of your devices, the T7 Shield features read/write speeds of up to 1,000 MB/s and a durable design to resist wear and damage.", "/images/product18.jpg", "/images/product18.jpg", "Samsung T7 Shield 4TB External Solid State Drive", 249.99000000000001 },
                    { 19, 5, true, true, "With excellent performance including read speeds of up to $5,000MB/s, this drive enhances the speed and performance of your entire system.", "/images/product19.jpg", "/images/product19.jpg", "T-Force Cardea 1TB NVME Internal Solid State Drive", 74.989999999999995 },
                    { 20, 5, true, false, "With blistering speeds of up to 12,000MB/s, experience performance like you never have before. Perfect for the ultimate gaming and creative computer.", "/images/product20.jpg", "/images/product20.jpg", "Crucial T700 2TB NVME Internal Solid State Drive", 295.99000000000001 },
                    { 21, 5, true, false, "KingSpec NVME SSD is the ideal data storage solution for your desktop or laptop, drastically improving performace and efficiency.", "/images/product21.jpg", "/images/product21.jpg", "KingSpec 1TB NVME Internal Solid State Drive", 121.98999999999999 },
                    { 22, 6, true, false, "Keep your system looking and running cool with the premier RBG lighting fans on the market.", "/images/product22.jpg", "/images/product22.jpg", "Corsair iCUE RGB Elite Triple Fan Kit Black", 51.990000000000002 },
                    { 23, 6, true, true, "Keep your system looking and running cool with the premier RBG lighting fans on the market.", "/images/product23.jpg", "/images/product23.jpg", "Corsair iCUE RGB Elite Triple Fan Kit White", 79.989999999999995 },
                    { 24, 6, true, false, "Premium quiet fan with advanced flow channels and acoustic optimisation for quiet cooling.", "/images/product24.jpg", "/images/product24.jpg", "Noctua Premium Quiet Fan - Brown", 23.949999999999999 },
                    { 25, 6, true, true, "The final component of your gaming system. A good monitor elevates the performance of all of your PC components. GIGABYTE gaming monitors offer the best boost in the business.", "/images/product25.jpg", "/images/product25.jpg", "GIGABYTE G27Q 27 inch 144Hz 1440p Gaming Monitor", 249.99000000000001 },
                    { 26, 6, true, false, "32 Inch display with ultrafast 175Hz refresh rate designed for the best gameplay. G-Sync compatibility offers seamless, tear-free experiences by default.", "/images/product26.jpg", "/images/product26.jpg", "ASUS 32 inch 1440p G-Sync Gaming Monitor", 529.99000000000001 },
                    { 27, 6, true, false, "Ultra HD 3840 x 2160 Resultion and a 178 degree wide viewing angle offer unparalleled viewing experience.", "/images/product27.jpg", "/images/product27.jpg", "Z-EDGE U27P4K 27 inch IPS 4K Monitor", 249.99000000000001 },
                    { 28, 6, true, true, "With rapid response and a sleek, stylish design, the MK710 is perfect for home desktops. Features up to three-year battery life.", "/images/product28.jpg", "/images/product28.jpg", "Logitech MK710 Wireless Keyboard and Mouse Combo", 79.989999999999995 },
                    { 29, 6, true, false, "Made with recycled plastic, Pebble 2's minimalist, slim design makes for an iconic and portable accessory. Pairs with up to three devices via bluetooth.", "/images/product29.jpg", "/images/product29.jpg", "Logitech Pebble 2 Combo Wireless Keyboard and Mouse", 59.990000000000002 },
                    { 30, 6, true, true, "Experience the feel of a mechanical keyboard with the responsiveness of a membrane keyboard. Features accurate feedback, reduced noise, and enhanced comfort.", "/images/product30.jpg", "/images/product30.jpg", "Rosewill NEON K42 Wired Mechanical Gaming Keyboard", 49.990000000000002 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5,
                column: "CategoryName",
                value: "Case");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 6,
                column: "CategoryName",
                value: "Power Supply");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescription", "CategoryName" },
                values: new object[,]
                {
                    { 7, "", "Storage" },
                    { 8, "", "Accessory" }
                });
        }
    }
}
