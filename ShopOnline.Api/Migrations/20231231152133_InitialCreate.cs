using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-desktop", "Computers" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-mobile-phone", "Phones" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-computer-mouse", "Mouse" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-keyboard", "Keyboard" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Get to know MX Master 3S - a new version of the iconic mouse. Feel how every moment at work becomes more precise, tangible and efficient. It's all thanks to Quiet Clicks switches and an 8000 DPI sensor that works even on glass. Ergonomic design ensures comfortable work. However, the battery life is up to 70 days when fully charged.\r\n", "/Images/Mouse/Mouse1.png", "Logitech MX Master 3S Grafit", 479m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Meet SteelSeries Rival 5 - an ergonomic mouse with 9 programmable buttons. Designed for maximum speed, it will give you an advantage in games such as Battle Royale, FPS, MOBA, and MMO. Thanks to the extensive equipment, you will take your gaming to a higher level. Play precisely and intensely with the modern TrueMove Air sensor and Golden Micro IP54 switches. Feel the real lightness, lack of resistance and master the game without any problems.\r\n", "/Images/Mouse/Mouse2.png", "SteelSeries Rival 5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "The Logitech G502 HERO gaming mouse is a powerful gaming mouse that offers a whole set of features for gamers. Advanced optical sensor for maximum tracking precision, customizable RGB lighting, custom gaming profiles and repositionable weights. All this makes the G502 HERO Gaming Mouse the right tool to take on the challenge.\r\n\r\nCheck what the product looks like in reality. Grab the photo below and drag it left or right to rotate the product or use the navigation buttons.", "/Images/Mouse/Mouse3.png", "Logitech G502 HERO" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Discover a new level of gaming with the SteelSeries Rival 3 Wireless mouse. Game with the performance of a wired mouse thanks to modern technologies and get rid of limitations. SteelSeries Rival 3 Wireless will delight you with its speed, accuracy and rich equipment. Consistent quality of operation is guaranteed by mechanical switches with a durability of up to 60 million clicks, while the ergonomic design will allow you to deal with opponents for long hours.\r\n", "/Images/Mouse/Mouse4.png", "SteelSeries Rival 3 Wireless" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Silver Monkey Wireless Comfort Silent Mouse M70 is a wireless mouse that will improve your working comfort while traveling as well as in your home office. Equipped with quiet buttons, it reduces up to 90% of noise, allowing you and those around you to fully focus on your work, thus reducing the feeling of fatigue associated with persistent clicking sounds. Silver Monkey M70 was designed for your comfort. Perfect profile with a streamlined shape, textured side panels and optimal size - perfect for your dynamic lifestyle.\r\n", "/Images/Mouse/Mouse5.png", "Silver Monkey M70 Wireless Comfort Mouse Black Silent" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "The latest Rival 3 mouse from SteelSeries is the successor to the legendary Rival 110 mouse. This means that it is even better than its brilliant predecessor. The Rival 3 mouse is made of very durable materials, and at the same time its design is light, comfortable and ergonomic.\r\n\r\nConsistent quality of operation is guaranteed by mechanical switches with a durability of up to 60 million clicks. The PixArt sensor offers precision and true 1:1 tracking of the user's movements.\r\n\r\nMoreover, thanks to the internal memory, you can save polling rate, button mapping and up to 5 CPI settings directly on the device.\r\n", "/Images/Mouse/Mouse6.png", "SteelSeries Rival 3" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "The Move to iOS app will help you seamlessly transfer photos, contacts and other data to your new iPhone.", "/Images/Phones/Phone1.png", "Apple iPhone 15 128GB Black", 5400m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "What has been prepared for you in the new Xiaomi POCO X5 5G 256 GB Black? As usual, you can count on high quality and modern components. These include a 120 Hz AMOLED screen, a triple camera system, and an efficient processor. There are also many valuable functions waiting for you that will certainly have a positive impact on your user experience. All this accompanied by a large capacity 5000 mAh battery with a 33 W fast charging function.\r\n", "/Images/Phones/Phone2.png", "Xiaomi POCO X5 5G 8/256GB Black", 1350m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Discover the unknown with a device of incredible power. ASUS ROG Phone 6 512 GB black uses a powerful Qualcomm® Snapdragon® 8+ Gen 1 processor and 16 GB RAM. These parameters will ensure smooth action during every game. And you'll see everything on a 6.78-inch display. It has a refresh rate of 165 Hz, which will provide you with an excellent visual experience. During a fight, use the AirTrigger 6 system and the Armory Crate application. Moreover, a good temperature will also be maintained. Thanks to the GameCool 6 cooling system.\r\n", "/Images/Phones/Phone3.png", "ASUS ROG Phone 6 16/512GB Phantom Black", 3100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Here's Motorola Moto E22. It is made of the highest quality materials. Additionally, it is slim and elegant, and the hydrophobic coating protects it against splashes. An efficient processor and a capacious battery will make it easier for you to be mobile. Take beautiful photos with the main camera and enjoy the quality of videos displayed on a large and bright screen.", "/Images/Phones/Phone4.png", "Motorola moto e22 4/64GB Crystal Blue 90Hz", 459m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Super bright display in a durable design. The easy way to shoot video with true cinematic storytelling. Turbo-fast chip. And a huge jump in battery performance, invaluable for everyday use.\r\n", "/Images/Phones/Phone5.png", "Apple iPhone 13 128GB Midnight", 3500m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Meet the king of mobile productivity. This is the new realme 9 Pro 128 GB green. It is equipped with a Snapdragon 695 processor. Thanks to it, every activity will be carried out smoothly. Play various videos and their quality will be high. Importantly, the display has a refresh rate of 120 Hz. Thanks to it, the smearing effect will never appear on the smartphone screen again. There are also cameras. Choose the right one and start taking interesting photos. Then you can show them off to your friends.\r\n", "/Images/Phones/Phone6.png", "realme 9 Pro 8+128GB Aurora Green 120Hz", 999m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Razer Ornata V2 is an ergonomic gaming keyboard characterized by high quality, reliability and fast response time. These are the qualities that will make you successful. Its functionality and design are typically adapted to gaming. The Razer Ornata V2 keyboard will help you turn the tide of the game in your favor.\r\n", "/Images/Keyboards/Keyboard1.png", "Razer Ornata V2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "It is known that a long game can be tiring. Both for you and for the keyboard itself. XPG Summoner Mini has been optimized with ergonomics in mind and is suitable for long gaming sessions. Made of high-quality materials, it is characterized by higher durability and resistance to vigorous hitting of the keys. Choose XPG Summoner Mini and take command on the battlefield.\r\n", "/Images/Keyboards/Keyboard2.png", "XPG Summoner Mini (Outemu Red)" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Play and enjoy the many features of the Silver Monkey X Mandrill keyboard. Made of ABS plastic, it will ensure durability and resistance to damage. The cotton sheath of the cable prevents it from getting tangled and preventing you from using the keyboard freely. You can place the Mandrill in a comfortable and stable position thanks to the rubberized legs. It also has a wrist rest, the ability to lock the \"Windows\" key and a multimedia control knob. Rubber dome switches will make your every press comfortable and precise.\r\n\r\nRecord macros and press multiple keys. Anti-ghosting technology for 26 keys will allow you to enter data smoothly and accurately. In addition, the RGB backlight will illuminate your desk with millions of colors.\r\n", "/Images/Keyboards/Keyboard3.png", "Silver Monkey X Mandrill" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Get ready to game in the best way possible with the SteelSeries Apex 3 TKL keyboard. It was designed to combine modern technologies with useful gaming functionalities. Thanks to this, each game will provide you with an amazing experience. The keyboard is equipped with switches that reduce friction, ensuring above-average durability. Order your copy and get into the game.\r\n", "/Images/Keyboards/Keyboard4.png", "SteelSeries Apex 3 TKL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Are you looking for a simple and comfortable office set for work or home? Choose the Silver Monkey S41 keyboard and mouse. Wireless operation will provide you with maximum comfort of use, regardless of what activity you perform. Thanks to this set, you will get rid of the tangle of cables on your desk. The quiet and low-profile keyboard will make typing intuitive and light. However, this small mouse will transfer every movement with extraordinary accuracy. The elegant and minimalist design will fit any computer workstation.\r\n", "/Images/Keyboards/Keyboard5.png", "Silver Monkey S41 Wireless keyboard and mouse set" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Dell KB216-B QuietKey is a unique keyboard in terms of simplicity and comfort of use. Ensure proper comfort of work in the office or at home. The elegant design will fit perfectly into the space on your desk. Take care of proper ergonomics when spending long hours in front of the computer. Choose Dell KB216-B QuietKey and increase your productivity.\r\n", "/Images/Keyboards/Keyboard6.png", "Dell KB216-B QuietKey USB" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-spa", "Beauty" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-couch", "Furniture" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-video-camera", "Electronics" });

            migrationBuilder.UpdateData(
                table: "ProductCategories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IconCSS", "Name" },
                values: new object[] { "fas fa-shoe-prints", "Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", "Air Pods", 100m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", "On-ear Golden Headphones" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", "On-ear Black Headphones" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", "Sennheiser Digital Camera with Tripod" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", "Canon Digital Camera" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", "Nintendo Gameboy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", "Black Leather Office Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", "Pink Leather Office Chair", 50m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", "Lounge Chair", 70m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", "Silver Lounge Chair", 120m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", "Porcelain Table Lamp", 15m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageURL", "Name", "Price" },
                values: new object[] { "Office Table Lamp", "/Images/Furniture/Furniture7.png", "Office Table Lamp", 20m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", "Puma Sneakers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", "Colorful Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", "Blue Nike Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", "Colorful Hummel Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", "Red Nike Trainers" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageURL", "Name" },
                values: new object[] { "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", "Birkenstock Sandles" });
        }
    }
}
