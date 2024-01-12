using Microsoft.EntityFrameworkCore;
using ShopOnline.Api.Entities;

namespace ShopOnline.Api.Data
{
    public class ShopOnlineDbContext:DbContext
    {
        public ShopOnlineDbContext(DbContextOptions<ShopOnlineDbContext> options) : base(options) 
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Products
            //Computers Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "HP Victus 16 i5-13500H/16GB/512/Win11x RTX4060 144Hz",
                Description = "HP Victus 16 gaming laptop\r\nImmerse yourself in the world of gaming with the HP Victus 16 laptop, created by giving you an extra boost in every fight. The exceptional power of 13th Gen Intel® Core™ and advanced NVIDIA® graphics cards turn every game into an immersive adventure. Moreover, optimization solutions, effective system operation and an ergonomic keyboard will meet the needs of the most critical gamers.\r\n",
                ImageURL = "/Images/Computers/Computer1.png",
                Price = 5500,
                Qty = 15,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "G4M3R HERO i7-13700F/32GB/1TB/RTX4060Ti/W11x",
                Description = "G4M3R are high-class computers, with full specifications clearly marked so that the potential customer knows exactly what he will receive. No blacklisted power supplies. No components of questionable quality.",
                ImageURL = "/Images/Computers/Computer2.png",
                Price = 7800,
                Qty = 10,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Dell Inspiron 3520 i5-1235U/8GB/512/Win11 120Hz",
                Description = "If you need a reliable tool for everyday work or remote learning, choose the Inspiron 15 3000 series. Experience more responsive, yet quieter performance with the latest Intel processors. Thanks to the Dell quality guarantee, you will have a solid and very efficient laptop at an affordable price. What more could you want?",
                ImageURL = "/Images/Computers/Computer3.png",
                Price = 2499,
                Qty = 50,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Dell Vostro 3710 SFF i5-12400/16GB/512/Win11P",
                Description = "The small size and stylish casing of the Dell Vostro 3710 SFF desktop fit into any office. Efficiency sufficient for everyday work will allow you to handle even the most complex projects and thus efficiently achieve your goals. As a result, you will improve your efficiency and, thanks to energy-saving components, you will bring some savings to your company.",
                ImageURL = "/Images/Computers/Computer4.png",
                Price = 3099,
                Qty = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Lenovo IdeaCentre AIO 3-27 i5-12450H/16GB/1TB/Win11",
                Description = "Lenovo IdeaCentre 3-27 is a stylish and powerful home computer. Powered by an Intel Core processor, it's designed to get things done quickly. It's also great for entertainment - it's equipped with a high-quality audio system, powerful speakers and a dazzling 27-inch Full HD screen.\r\n",
                ImageURL = "/Images/Computers/Computer5.png",
                Price = 3999,
                Qty = 20,
                CategoryId = 1

            });
            //Mouse Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Logitech MX Master 3S Grafit",
                Description = "Get to know MX Master 3S - a new version of the iconic mouse. Feel how every moment at work becomes more precise, tangible and efficient. It's all thanks to Quiet Clicks switches and an 8000 DPI sensor that works even on glass. Ergonomic design ensures comfortable work. However, the battery life is up to 70 days when fully charged.\r\n",
                ImageURL = "/Images/Mouse/Mouse1.png",
                Price = 479,
                Qty = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "SteelSeries Rival 5",
                Description = "Meet SteelSeries Rival 5 - an ergonomic mouse with 9 programmable buttons. Designed for maximum speed, it will give you an advantage in games such as Battle Royale, FPS, MOBA, and MMO. Thanks to the extensive equipment, you will take your gaming to a higher level. Play precisely and intensely with the modern TrueMove Air sensor and Golden Micro IP54 switches. Feel the real lightness, lack of resistance and master the game without any problems.\r\n",
                ImageURL = "/Images/Mouse/Mouse2.png",
                Price = 40,
                Qty = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Logitech G502 HERO",
                Description = "The Logitech G502 HERO gaming mouse is a powerful gaming mouse that offers a whole set of features for gamers. Advanced optical sensor for maximum tracking precision, customizable RGB lighting, custom gaming profiles and repositionable weights. All this makes the G502 HERO Gaming Mouse the right tool to take on the challenge.\r\n\r\nCheck what the product looks like in reality. Grab the photo below and drag it left or right to rotate the product or use the navigation buttons.",
                ImageURL = "/Images/Mouse/Mouse3.png",
                Price = 40,
                Qty = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "SteelSeries Rival 3 Wireless",
                Description = "Discover a new level of gaming with the SteelSeries Rival 3 Wireless mouse. Game with the performance of a wired mouse thanks to modern technologies and get rid of limitations. SteelSeries Rival 3 Wireless will delight you with its speed, accuracy and rich equipment. Consistent quality of operation is guaranteed by mechanical switches with a durability of up to 60 million clicks, while the ergonomic design will allow you to deal with opponents for long hours.\r\n",
                ImageURL = "/Images/Mouse/Mouse4.png",
                Price = 600,
                Qty = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Silver Monkey M70 Wireless Comfort Mouse Black Silent",
                Description = "Silver Monkey Wireless Comfort Silent Mouse M70 is a wireless mouse that will improve your working comfort while traveling as well as in your home office. Equipped with quiet buttons, it reduces up to 90% of noise, allowing you and those around you to fully focus on your work, thus reducing the feeling of fatigue associated with persistent clicking sounds. Silver Monkey M70 was designed for your comfort. Perfect profile with a streamlined shape, textured side panels and optimal size - perfect for your dynamic lifestyle.\r\n",
                ImageURL = "/Images/Mouse/Mouse5.png",
                Price = 500,
                Qty = 15,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "SteelSeries Rival 3",
                Description = "The latest Rival 3 mouse from SteelSeries is the successor to the legendary Rival 110 mouse. This means that it is even better than its brilliant predecessor. The Rival 3 mouse is made of very durable materials, and at the same time its design is light, comfortable and ergonomic.\r\n\r\nConsistent quality of operation is guaranteed by mechanical switches with a durability of up to 60 million clicks. The PixArt sensor offers precision and true 1:1 tracking of the user's movements.\r\n\r\nMoreover, thanks to the internal memory, you can save polling rate, button mapping and up to 5 CPI settings directly on the device.\r\n",
                ImageURL = "/Images/Mouse/Mouse6.png",
                Price = 100,
                Qty = 60,
                CategoryId = 3
            });
            //Phones Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Apple iPhone 15 128GB Black",
                Description = "The Move to iOS app will help you seamlessly transfer photos, contacts and other data to your new iPhone.",
                ImageURL = "/Images/Phones/Phone1.png",
                Price = 5400,
                Qty = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Xiaomi POCO X5 5G 8/256GB Black",
                Description = "What has been prepared for you in the new Xiaomi POCO X5 5G 256 GB Black? As usual, you can count on high quality and modern components. These include a 120 Hz AMOLED screen, a triple camera system, and an efficient processor. There are also many valuable functions waiting for you that will certainly have a positive impact on your user experience. All this accompanied by a large capacity 5000 mAh battery with a 33 W fast charging function.\r\n",
                ImageURL = "/Images/Phones/Phone2.png",
                Price = 1350,
                Qty = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "ASUS ROG Phone 6 16/512GB Phantom Black",
                Description = "Discover the unknown with a device of incredible power. ASUS ROG Phone 6 512 GB black uses a powerful Qualcomm® Snapdragon® 8+ Gen 1 processor and 16 GB RAM. These parameters will ensure smooth action during every game. And you'll see everything on a 6.78-inch display. It has a refresh rate of 165 Hz, which will provide you with an excellent visual experience. During a fight, use the AirTrigger 6 system and the Armory Crate application. Moreover, a good temperature will also be maintained. Thanks to the GameCool 6 cooling system.\r\n",
                ImageURL = "/Images/Phones/Phone3.png",
                Price = 3100,
                Qty = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Motorola moto e22 4/64GB Crystal Blue 90Hz",
                Description = "Here's Motorola Moto E22. It is made of the highest quality materials. Additionally, it is slim and elegant, and the hydrophobic coating protects it against splashes. An efficient processor and a capacious battery will make it easier for you to be mobile. Take beautiful photos with the main camera and enjoy the quality of videos displayed on a large and bright screen.",
                ImageURL = "/Images/Phones/Phone4.png",
                Price = 459,
                Qty = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Apple iPhone 13 128GB Midnight",
                Description = "Super bright display in a durable design. The easy way to shoot video with true cinematic storytelling. Turbo-fast chip. And a huge jump in battery performance, invaluable for everyday use.\r\n",
                ImageURL = "/Images/Phones/Phone5.png",
                Price = 3500,
                Qty = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "realme 9 Pro 8+128GB Aurora Green 120Hz",
                Description = "Meet the king of mobile productivity. This is the new realme 9 Pro 128 GB green. It is equipped with a Snapdragon 695 processor. Thanks to it, every activity will be carried out smoothly. Play various videos and their quality will be high. Importantly, the display has a refresh rate of 120 Hz. Thanks to it, the smearing effect will never appear on the smartphone screen again. There are also cameras. Choose the right one and start taking interesting photos. Then you can show them off to your friends.\r\n",
                ImageURL = "/Images/Phones/Phone6.png",
                Price = 999,
                Qty = 73,
                CategoryId = 2
            });
            //Keyboards Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Razer Ornata V2",
                Description = "Razer Ornata V2 is an ergonomic gaming keyboard characterized by high quality, reliability and fast response time. These are the qualities that will make you successful. Its functionality and design are typically adapted to gaming. The Razer Ornata V2 keyboard will help you turn the tide of the game in your favor.\r\n",
                ImageURL = "/Images/Keyboards/Keyboard1.png",
                Price = 100,
                Qty = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "XPG Summoner Mini (Outemu Red)",
                Description = "It is known that a long game can be tiring. Both for you and for the keyboard itself. XPG Summoner Mini has been optimized with ergonomics in mind and is suitable for long gaming sessions. Made of high-quality materials, it is characterized by higher durability and resistance to vigorous hitting of the keys. Choose XPG Summoner Mini and take command on the battlefield.\r\n",
                ImageURL = "/Images/Keyboards/Keyboard2.png",
                Price = 150,
                Qty = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Silver Monkey X Mandrill",
                Description = "Play and enjoy the many features of the Silver Monkey X Mandrill keyboard. Made of ABS plastic, it will ensure durability and resistance to damage. The cotton sheath of the cable prevents it from getting tangled and preventing you from using the keyboard freely. You can place the Mandrill in a comfortable and stable position thanks to the rubberized legs. It also has a wrist rest, the ability to lock the \"Windows\" key and a multimedia control knob. Rubber dome switches will make your every press comfortable and precise.\r\n\r\nRecord macros and press multiple keys. Anti-ghosting technology for 26 keys will allow you to enter data smoothly and accurately. In addition, the RGB backlight will illuminate your desk with millions of colors.\r\n",
                ImageURL = "/Images/Keyboards/Keyboard3.png",
                Price = 200,
                Qty = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "SteelSeries Apex 3 TKL",
                Description = "Get ready to game in the best way possible with the SteelSeries Apex 3 TKL keyboard. It was designed to combine modern technologies with useful gaming functionalities. Thanks to this, each game will provide you with an amazing experience. The keyboard is equipped with switches that reduce friction, ensuring above-average durability. Order your copy and get into the game.\r\n",
                ImageURL = "/Images/Keyboards/Keyboard4.png",
                Price = 120,
                Qty = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Silver Monkey S41 Wireless keyboard and mouse set",
                Description = "Are you looking for a simple and comfortable office set for work or home? Choose the Silver Monkey S41 keyboard and mouse. Wireless operation will provide you with maximum comfort of use, regardless of what activity you perform. Thanks to this set, you will get rid of the tangle of cables on your desk. The quiet and low-profile keyboard will make typing intuitive and light. However, this small mouse will transfer every movement with extraordinary accuracy. The elegant and minimalist design will fit any computer workstation.\r\n",
                ImageURL = "/Images/Keyboards/Keyboard5.png",
                Price = 200,
                Qty = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Dell KB216-B QuietKey USB",
                Description = "Dell KB216-B QuietKey is a unique keyboard in terms of simplicity and comfort of use. Ensure proper comfort of work in the office or at home. The elegant design will fit perfectly into the space on your desk. Take care of proper ergonomics when spending long hours in front of the computer. Choose Dell KB216-B QuietKey and increase your productivity.\r\n",
                ImageURL = "/Images/Keyboards/Keyboard6.png",
                Price = 50,
                Qty = 150,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Bob",

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Sarah",
            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 1,
                Name = "Computers",
                IconCSS = "fas fa-desktop"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 2,
                Name = "Phones",
                IconCSS = "fas fa-mobile-phone"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 3,
                Name = "Mouse",
                IconCSS = "fas fa-computer-mouse"
            });
            modelBuilder.Entity<ProductCategory>().HasData(new ProductCategory
            {
                Id = 4,
                Name = "Keyboard",
                IconCSS = "fas fa-keyboard"
            });

        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
