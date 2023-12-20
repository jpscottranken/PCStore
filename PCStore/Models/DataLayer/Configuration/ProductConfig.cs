using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PCStore.Models.DomainModels;

namespace PCStore.Models.DataLayer.Configuration
{
    internal class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            // seed data
            builder.HasData(
                new Product
                {
                    ProductId = 1,
                    ProductName = "ASUS ROG Maximus Z790 Hero",
                    ProductDescription = "Buffed and ready with more power, robust cooling, and flexible I/O to scale up your rig at will. The ROG Maximus Z790 Hero puts it all at your disposal together with an arsenal of features and utilities to truly express the PC builder, overclocker, and gaming hero in you.",
                    ProductPrice = 609.99,
                    ProductImageURL = "/images/product01.jpg",
                    ProductImageThumbnailURL = "/images/product01.jpg",
                    IsProductOnSale = true,
                    IsProductInStock = true,
                    CategoryID = 1
                },
                new Product
                {
                    ProductId = 2,
                    ProductName = "MSI MAG B550 Tomahawk",
                    ProductDescription = "Featurign Core Boost Technology, 6 layer PCB, and the highest quality power delivery components, the MSI MAG B550 Tomahawk gives you unmatched performance at an unbeatable price.",
                    ProductPrice = 169.99,
                    ProductImageURL = "/images/product02.jpg",
                    ProductImageThumbnailURL = "/images/product02.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 1
                },
                new Product
                {
                    ProductId = 3,
                    ProductName = "ASUS ROG Strix Z690-E",
                    ProductDescription = "ROG Strix Z690-E Gaming Wi-Fi puts 12th Gen Intel® Core™ processors at center stage, with beefed-up power delivery, cooling, cutting-edge connectivity options, and a range of accoutrements that effortlessly propel builds to maximum performance. This series flagship is your ticket to next-level gaming.",
                    ProductPrice = 279.99,
                    ProductImageURL = "/images/product03.jpg",
                    ProductImageThumbnailURL = "/images/product03.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 1
                },
                new Product
                {
                    ProductId = 4,
                    ProductName = "AMD Ryzen 9 5900X",
                    ProductDescription = "Get the competitive edge with 12 cores, 24 threads, boost clocks of up to 4.8GHz2 and 70MB of cache.",
                    ProductPrice = 549.99,
                    ProductImageURL = "/images/product04.jpg",
                    ProductImageThumbnailURL = "/images/product04.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 2
                },
                new Product
                {
                    ProductId = 5,
                    ProductName = "Intel Core i7-12700K",
                    ProductDescription = "Blazing-fast clock speeds and a revolutionary core architecture allow you to seamlessly chat, stream and record without sacrificing gameplay.",
                    ProductPrice = 449.99,
                    ProductImageURL = "/images/product05.jpg",
                    ProductImageThumbnailURL = "/images/product05.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 2
                },
                new Product
                {
                    ProductId = 6,
                    ProductName = "Intel Core i9-12700K",
                    ProductDescription = "With the highest clock speeds and a groundbreaking new architecture, you’ll be able to push your gameplay to new heights while secondary apps run seamlessly in the background.",
                    ProductPrice = 649.99,
                    ProductImageURL = "/images/product06.jpg",
                    ProductImageThumbnailURL = "/images/product06.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 2
                },
                new Product
                {
                    ProductId = 7,
                    ProductName = "G.SKILL Ripjaws V Series 32 GB",
                    ProductDescription = "As the latest addition to the classic RipJaws family, RipJaws V series DDR4 memory is designed for sleek aesthetics and performance. Ripjaws V is the ideal choice for building a new performance system or for DRAM memory upgrade.",
                    ProductPrice = 64.99,
                    ProductImageURL = "/images/product07.jpg",
                    ProductImageThumbnailURL = "/images/product07.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 3
                },
                new Product
                {
                    ProductId = 8,
                    ProductName = "Nemix Ram 32GB Kit",
                    ProductDescription = "Speed up loading times, boost system responsiveness, and improve your computers ability to handle greater workloads with Nemix Ram's 32GB kit.",
                    ProductPrice = 97.99,
                    ProductImageURL = "/images/product08.jpg",
                    ProductImageThumbnailURL = "/images/product08.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 3
                },
                new Product
                {
                    ProductId = 9,
                    ProductName = "Corsair Vengeance LPX 16GB",
                    ProductDescription = "VENGEANCE LPX memory is designed for high-performance overclocking. Whether you're breaking your own records or you're simply building a dream gaming rig, you can count on CORSAIR memory.",
                    ProductPrice = 51.99,
                    ProductImageURL = "/images/product09.jpg",
                    ProductImageThumbnailURL = "/images/product09.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 3
                },
                new Product
                {
                    ProductId = 10,
                    ProductName = "MSI Ventus GeForce RTX 3060",
                    ProductDescription = "Granting peak performance at an affordable price, the best selling MSI Ventus GeForce RTX 3060 is a must have for newcomers and enthusiasts alike.",
                    ProductPrice = 289.99,
                    ProductImageURL = "/images/product10.jpg",
                    ProductImageThumbnailURL = "/images/product10.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 4
                },
                new Product
                {
                    ProductId = 11,
                    ProductName = "GIGABYTE Gaming OC GeForce 3070",
                    ProductDescription = "Looking to power up your rig? Look no further than the GIGABYTE Gaming OC RTX 3070. Offering NVIDIA multiprocessors, Windforce cooling systems, and a 1815 MHz core clock, this card offers unparalleled performance.",
                    ProductPrice = 569.99,
                    ProductImageURL = "/images/product11.jpg",
                    ProductImageThumbnailURL = "/images/product11.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 4
                },
                new Product
                {
                    ProductId = 12,
                    ProductName = "ASRock Radeon RX 6700 XT",
                    ProductDescription = "Get equipped to play the newest games at the highest settings with 12GB of GDDR6 memory and 40 enhanced compute units delivering 1440p gaming at ultra settings with smooth framerates and maximum visual settings.",
                    ProductPrice = 329.99,
                    ProductImageURL = "/images/product12.jpg",
                    ProductImageThumbnailURL = "/images/product12.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 4
                },
                new Product
                {
                    ProductId = 13,
                    ProductName = "Seagate IronWolf 12TB NAS Harddrive Internal HDD",
                    ProductDescription = "Purpose built for multi-user NAS environments, Seagate IronWolf drives are perfect for teams needing to store more and work faster.",
                    ProductPrice = 359.99,
                    ProductImageURL = "/images/product13.jpg",
                    ProductImageThumbnailURL = "/images/product13.jpg",
                    IsProductOnSale = true,
                    IsProductInStock = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductId = 14,
                    ProductName = "WD Blue 500GB Desktop Hard Disk Drive",
                    ProductDescription = "Perfect for reliable, everyday computing with Western Digital quality and reliability.",
                    ProductPrice = 59.99,
                    ProductImageURL = "/images/product14.jpg",
                    ProductImageThumbnailURL = "/images/product14.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductId = 15,
                    ProductName = "Seagate BarraCude 8TB SATA Internal Hard Drive",
                    ProductDescription = "Cost effective storage for laptop or desktop computers. Store all your games, music, movies and more with up to 8TB of storage.",
                    ProductPrice = 189.99,
                    ProductImageURL = "/images/product15.jpg",
                    ProductImageThumbnailURL = "/images/product15.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductId = 16,
                    ProductName = "UnionSine 1TB Ultra Slim Portable External Hard Drive",
                    ProductDescription = "Compatible with PC, desktop, laptop, Xbox One, and PS4. Plug and play - no software to install and ready to use.",
                    ProductPrice = 55.99,
                    ProductImageURL = "/images/product16.jpg",
                    ProductImageThumbnailURL = "/images/product16.jpg",
                    IsProductOnSale = true,
                    IsProductInStock = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductId = 17,
                    ProductName = "Seagate 18TB Exos Enterprise Hard Drive HDD",
                    ProductDescription = "With massive capacity and innovative technology advancements, this Exos X18 enterprise hard drive is engineered to address the needs of the hyperscale storage market.",
                    ProductPrice = 399.99,
                    ProductImageURL = "/images/product17.jpg",
                    ProductImageThumbnailURL = "/images/product17.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductId = 18,
                    ProductName = "Samsung T7 Shield 4TB External Solid State Drive",
                    ProductDescription = "Compatible with all of your devices, the T7 Shield features read/write speeds of up to 1,000 MB/s and a durable design to resist wear and damage.",
                    ProductPrice = 249.99,
                    ProductImageURL = "/images/product18.jpg",
                    ProductImageThumbnailURL = "/images/product18.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductId = 19,
                    ProductName = "T-Force Cardea 1TB NVME Internal Solid State Drive",
                    ProductDescription = "With excellent performance including read speeds of up to $5,000MB/s, this drive enhances the speed and performance of your entire system.",
                    ProductPrice = 74.99,
                    ProductImageURL = "/images/product19.jpg",
                    ProductImageThumbnailURL = "/images/product19.jpg",
                    IsProductOnSale = true,
                    IsProductInStock = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductId = 20,
                    ProductName = "Crucial T700 2TB NVME Internal Solid State Drive",
                    ProductDescription = "With blistering speeds of up to 12,000MB/s, experience performance like you never have before. Perfect for the ultimate gaming and creative computer.",
                    ProductPrice = 295.99,
                    ProductImageURL = "/images/product20.jpg",
                    ProductImageThumbnailURL = "/images/product20.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductId = 21,
                    ProductName = "KingSpec 1TB NVME Internal Solid State Drive",
                    ProductDescription = "KingSpec NVME SSD is the ideal data storage solution for your desktop or laptop, drastically improving performace and efficiency.",
                    ProductPrice = 121.99,
                    ProductImageURL = "/images/product21.jpg",
                    ProductImageThumbnailURL = "/images/product21.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 5
                },
                new Product
                {
                    ProductId = 22,
                    ProductName = "Corsair iCUE RGB Elite Triple Fan Kit Black",
                    ProductDescription = "Keep your system looking and running cool with the premier RBG lighting fans on the market.",
                    ProductPrice = 51.99,
                    ProductImageURL = "/images/product22.jpg",
                    ProductImageThumbnailURL = "/images/product22.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 6
                },
                new Product
                {
                    ProductId = 23,
                    ProductName = "Corsair iCUE RGB Elite Triple Fan Kit White",
                    ProductDescription = "Keep your system looking and running cool with the premier RBG lighting fans on the market.",
                    ProductPrice = 79.99,
                    ProductImageURL = "/images/product23.jpg",
                    ProductImageThumbnailURL = "/images/product23.jpg",
                    IsProductOnSale = true,
                    IsProductInStock = true,
                    CategoryID = 6
                },
                new Product
                {
                    ProductId = 24,
                    ProductName = "Noctua Premium Quiet Fan - Brown",
                    ProductDescription = "Premium quiet fan with advanced flow channels and acoustic optimisation for quiet cooling.",
                    ProductPrice = 23.95,
                    ProductImageURL = "/images/product24.jpg",
                    ProductImageThumbnailURL = "/images/product24.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 6
                },
                new Product
                {
                    ProductId = 25,
                    ProductName = "GIGABYTE G27Q 27 inch 144Hz 1440p Gaming Monitor",
                    ProductDescription = "The final component of your gaming system. A good monitor elevates the performance of all of your PC components. GIGABYTE gaming monitors offer the best boost in the business.",
                    ProductPrice = 249.99,
                    ProductImageURL = "/images/product25.jpg",
                    ProductImageThumbnailURL = "/images/product25.jpg",
                    IsProductOnSale = true,
                    IsProductInStock = true,
                    CategoryID = 6
                },
                new Product
                {
                    ProductId = 26,
                    ProductName = "ASUS 32 inch 1440p G-Sync Gaming Monitor",
                    ProductDescription = "32 Inch display with ultrafast 175Hz refresh rate designed for the best gameplay. G-Sync compatibility offers seamless, tear-free experiences by default.",
                    ProductPrice = 529.99,
                    ProductImageURL = "/images/product26.jpg",
                    ProductImageThumbnailURL = "/images/product26.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 6
                },
                new Product
                {
                    ProductId = 27,
                    ProductName = "Z-EDGE U27P4K 27 inch IPS 4K Monitor",
                    ProductDescription = "Ultra HD 3840 x 2160 Resultion and a 178 degree wide viewing angle offer unparalleled viewing experience.",
                    ProductPrice = 249.99,
                    ProductImageURL = "/images/product27.jpg",
                    ProductImageThumbnailURL = "/images/product27.jpg",
                    IsProductOnSale = false,
                    IsProductInStock = true,
                    CategoryID = 6
                },
               new Product
               {
                   ProductId = 28,
                   ProductName = "Logitech MK710 Wireless Keyboard and Mouse Combo",
                   ProductDescription = "With rapid response and a sleek, stylish design, the MK710 is perfect for home desktops. Features up to three-year battery life.",
                   ProductPrice = 79.99,
                   ProductImageURL = "/images/product28.jpg",
                   ProductImageThumbnailURL = "/images/product28.jpg",
                   IsProductOnSale = true,
                   IsProductInStock = true,
                   CategoryID = 6
               },
               new Product
               {
                   ProductId = 29,
                   ProductName = "Logitech Pebble 2 Combo Wireless Keyboard and Mouse",
                   ProductDescription = "Made with recycled plastic, Pebble 2's minimalist, slim design makes for an iconic and portable accessory. Pairs with up to three devices via bluetooth.",
                   ProductPrice = 59.99,
                   ProductImageURL = "/images/product29.jpg",
                   ProductImageThumbnailURL = "/images/product29.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 6
               },
               new Product
               {
                   ProductId = 30,
                   ProductName = "Rosewill NEON K42 Wired Mechanical Gaming Keyboard",
                   ProductDescription = "Experience the feel of a mechanical keyboard with the responsiveness of a membrane keyboard. Features accurate feedback, reduced noise, and enhanced comfort.",
                   ProductPrice = 49.99,
                   ProductImageURL = "/images/product30.jpg",
                   ProductImageThumbnailURL = "/images/product30.jpg",
                   IsProductOnSale = true,
                   IsProductInStock = true,
                   CategoryID = 6
               },
               new Product
               {
                   ProductId = 31,
                   ProductName = "GIGABYTE Intel Z790 MOtherboard",
                   ProductDescription = "With the fast-moving technology changes, GIGABYTE always follows the latest trends and provides customers with advanced features and latest technologies. GIGABYTE motherboards are equipped with upgraded power solution, latest storage standards and outstanding connectivity to enable optimized performance for gaming.",
                   ProductPrice = 249.99,
                   ProductImageURL = "/images/product31.jpg",
                   ProductImageThumbnailURL = "/images/product31.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 1
               },
               new Product
               {
                   ProductId = 32,
                   ProductName = "ASRock B650 LiveMixer ATX Motherboard",
                   ProductDescription = "AMD B650 Motherboard with support for AMD Ryzen 7000 Series Processors. ",
                   ProductPrice = 229.99,
                   ProductImageURL = "/images/product32.jpg",
                   ProductImageThumbnailURL = "/images/product32.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 1
               },
               new Product
               {
                   ProductId = 33,
                   ProductName = "ASUS ROG STRIX B650-A Motherboard",
                   ProductDescription = "With built in gaming WiFi and support for AMD Ryzen 7000 processors, the ASUS ROG STRIX B650-A Motherboard gives you all you need to up your game.",
                   ProductPrice = 279.99,
                   ProductImageURL = "/images/product33.jpg",
                   ProductImageThumbnailURL = "/images/product33.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 1
               },
               new Product
               {
                   ProductId = 34,
                   ProductName = "GIGABYTE B550 Aorus Elite Motherboard",
                   ProductDescription = "With the fast-moving technology changes, GIGABYTE always follows the latest trends and provides customers with advanced features and latest technologies. GIGABYTE motherboards are equipped with upgraded power solution, latest storage standards and outstanding connectivity to enable optimized performance for gaming.",
                   ProductPrice = 189.99,
                   ProductImageURL = "/images/product34.jpg",
                   ProductImageThumbnailURL = "/images/product34.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 1
               },
               new Product
               {
                   ProductId = 35,
                   ProductName = "MSI MPG B650 Edge Wifi Motherboard",
                   ProductDescription = "AMD B650 Motherboard that supports AMD Ryzen 7000 Series Processors. Comes with lightning fast WiFi so you never have to worry about slowing down.",
                   ProductPrice = 259.99,
                   ProductImageURL = "/images/product35.jpg",
                   ProductImageThumbnailURL = "/images/product35.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 1
               },
               new Product
               {
                   ProductId = 36,
                   ProductName = "AMD Ryzen 5 7600X",
                   ProductDescription = "The world's most advanced PC Processor. Take on any game with the pure speed of AMD Ryzen™ 5 7600X desktop processor.",
                   ProductPrice = 249.99,
                   ProductImageURL = "/images/product36.jpg",
                   ProductImageThumbnailURL = "/images/product36.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 2
               },
               new Product
               {
                   ProductId = 37,
                   ProductName = "AMD Ryzen 7 5700X",
                   ProductDescription = "Get the processor that is beautifully balanced for serious PC enthusiasts with “Zen 3” architecture1. With 8 cores, 16 threads, boost clocks of up to 4.6GHz2 and 36MB of total cache, the AMD Ryzen™ 7 5700X gives you the competitive edge.",
                   ProductPrice = 178.99,
                   ProductImageURL = "/images/product37.jpg",
                   ProductImageThumbnailURL = "/images/product37.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 2
               },
               new Product
               {
                   ProductId = 38,
                   ProductName = "Intel Core i5 12600KF",
                   ProductDescription = "Compete with confidence or get immersed in new worlds with a revolutionary processor architecture that focuses on what matters most – gaming.",
                   ProductPrice = 217.99,
                   ProductImageURL = "/images/product38.jpg",
                   ProductImageThumbnailURL = "/images/product38.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 2
               },
               new Product
               {
                   ProductId = 39,
                   ProductName = "AMD Ryzen 7 7700X",
                   ProductDescription = "Experience the speed of AMD Ryzen™ 7 7700X desktop processor. Build a rig with the winning performance you need to dominate the games you love.",
                   ProductPrice = 399.99,
                   ProductImageURL = "/images/product39.jpg",
                   ProductImageThumbnailURL = "/images/product39.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 2
               },
               new Product
               {
                   ProductId = 40,
                   ProductName = "AMD Ryzen 5 5600G",
                   ProductDescription = "Be unstoppable with the unprecedented speed of the AMD Ryzen™ 5000 G-Series desktop processors, whether you’re playing the latest games, designing the next skyscraper, or crunching scientific data. With AMD Ryzen™ desktop processors, you’re in the lead.",
                   ProductPrice = 259.99,
                   ProductImageURL = "/images/product40.jpg",
                   ProductImageThumbnailURL = "/images/product40.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 2
               },
               new Product
               {
                   ProductId = 41,
                   ProductName = "Intel Core i5 12400",
                   ProductDescription = "Featuring 6 cores (12 threads), 4.40 GHz Max Turbo frequency, and based on Intel's new micro architecture, the Core i5-12400 is a stellar gaming and multi-tasking processor with best-in-class price-performance ratio.",
                   ProductPrice = 161.99,
                   ProductImageURL = "/images/product41.jpg",
                   ProductImageThumbnailURL = "/images/product41.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 2
               },
               new Product
               {
                   ProductId = 42,
                   ProductName = "Mushkin Enhanced Redline 96GB RAM",
                   ProductDescription = "Get plenty of memory that will seamlessly integrate with your Intel or AMD-based SODIMM-compaible system.",
                   ProductPrice = 269.99,
                   ProductImageURL = "/images/product42.jpg",
                   ProductImageThumbnailURL = "/images/product42.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 3
               },
               new Product
               {
                   ProductId = 43,
                   ProductName = "Team T-Force Delta RGB 32GB RAM",
                   ProductDescription = "Modeled after a stealth aircraft, the T-FORCE DELTA RGB DDR5 delivers a refreshing visual experience and continues to offer the 120° ultra-wide lighting and clean geometric silhouette found in the DELTA RGB DDR4.",
                   ProductPrice = 104.99,
                   ProductImageURL = "/images/product43.jpg",
                   ProductImageThumbnailURL = "/images/product43.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 3
               },
               new Product
               {
                   ProductId = 44,
                   ProductName = "Team T-Force Vulcan 32GB RAM",
                   ProductDescription = "For the T-FORCE VULCAN DDR5, TEAMGROUP has adopted a gorgeous streamlines design with multi-angular to overall outline for visual aesthetics and showcase VULCAN DDR5's unique features, delivering a sleek OC gaming memory that packs a powerful performance.",
                   ProductPrice = 94.99,
                   ProductImageURL = "/images/product44.jpg",
                   ProductImageThumbnailURL = "/images/product44.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 3
               },
               new Product
               {
                   ProductId = 45,
                   ProductName = "XPG Spectra RBG 16GB RAM",
                   ProductDescription = "SPECTRIX D35G's composed and understated triangular outline is specifically designed for gamers with unique personalities.",
                   ProductPrice = 47.99,
                   ProductImageURL = "/images/product45.jpg",
                   ProductImageThumbnailURL = "/images/product45.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 3
               },
               new Product
               {
                   ProductId = 46,
                   ProductName = "ZOTAC Gaming GeForce RTX 4070 Twin Edge",
                   ProductDescription = "The ZOTAC GAMING GeForce RTX 4070 Twin Edge is a compact and powerful graphics card, featuring the NVIDIA Ada Lovelace architecture and an aerodynamic-inspired design.",
                   ProductPrice = 549.99,
                   ProductImageURL = "/images/product46.jpg",
                   ProductImageThumbnailURL = "/images/product46.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 4
               },
               new Product
               {
                   ProductId = 47,
                   ProductName = "PELADN Radeon 5500XT 8GB Video Card",
                   ProductDescription = "With high speeds and a sleek design that will elevate any build, you can't want for more than what the PELADN Radeon 5500XT video card can offer you.",
                   ProductPrice = 199.99,
                   ProductImageURL = "/images/product47.jpg",
                   ProductImageThumbnailURL = "/images/product47.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 4
               },
               new Product
               {
                   ProductId = 48,
                   ProductName = "ASRock Challenger Radeon RX 7700XT 12GB Video Card",
                   ProductDescription = "Two fans that provide strong cooling performance and make your gaming rig stay cool. It’s optimized for delivering excellent gaming experience with stylish and streamlined design.",
                   ProductPrice = 449.99,
                   ProductImageURL = "/images/product48.jpg",
                   ProductImageThumbnailURL = "/images/product48.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 4
               },
               new Product
               {
                   ProductId = 49,
                   ProductName = "ASUS TUF Gaming GeForce RTX 3070 V2",
                   ProductDescription = "Experience unparalleled performance with the ASUS TUF Gaming GeForce RTX 3070 V2 video graphics card. With a boost clock of 1845 MHz, there is not equal in performance.",
                   ProductPrice = 629.99,
                   ProductImageURL = "/images/product49.jpg",
                   ProductImageThumbnailURL = "/images/product49.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 4
               },
               new Product
               {
                   ProductId = 50,
                   ProductName = "ASUS Dual GeForce RTX 3050",
                   ProductDescription = "ASUS Dual GeForce RTX™ 3050 OC Edition 8 GB GDDR6 with two powerful Axial-tech fans and a 2-slot design for broad compatibility.",
                   ProductPrice = 259.99,
                   ProductImageURL = "/images/product50.jpg",
                   ProductImageThumbnailURL = "/images/product50.jpg",
                   IsProductOnSale = false,
                   IsProductInStock = true,
                   CategoryID = 4
               }
            );
        }
    }
}
