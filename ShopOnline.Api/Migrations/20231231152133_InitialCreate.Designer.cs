﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.Api.Data;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    [DbContext(typeof(ShopOnlineDbContext))]
    [Migration("20231231152133_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopOnline.Api.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Qty")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "HP Victus 16 gaming laptop\r\nImmerse yourself in the world of gaming with the HP Victus 16 laptop, created by giving you an extra boost in every fight. The exceptional power of 13th Gen Intel® Core™ and advanced NVIDIA® graphics cards turn every game into an immersive adventure. Moreover, optimization solutions, effective system operation and an ergonomic keyboard will meet the needs of the most critical gamers.\r\n",
                            ImageURL = "/Images/Computers/Computer1.png",
                            Name = "HP Victus 16 i5-13500H/16GB/512/Win11x RTX4060 144Hz",
                            Price = 5500m,
                            Qty = 15
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "G4M3R are high-class computers, with full specifications clearly marked so that the potential customer knows exactly what he will receive. No blacklisted power supplies. No components of questionable quality.",
                            ImageURL = "/Images/Computers/Computer2.png",
                            Name = "G4M3R HERO i7-13700F/32GB/1TB/RTX4060Ti/W11x",
                            Price = 7800m,
                            Qty = 10
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "If you need a reliable tool for everyday work or remote learning, choose the Inspiron 15 3000 series. Experience more responsive, yet quieter performance with the latest Intel processors. Thanks to the Dell quality guarantee, you will have a solid and very efficient laptop at an affordable price. What more could you want?",
                            ImageURL = "/Images/Computers/Computer3.png",
                            Name = "Dell Inspiron 3520 i5-1235U/8GB/512/Win11 120Hz",
                            Price = 2499m,
                            Qty = 50
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "The small size and stylish casing of the Dell Vostro 3710 SFF desktop fit into any office. Efficiency sufficient for everyday work will allow you to handle even the most complex projects and thus efficiently achieve your goals. As a result, you will improve your efficiency and, thanks to energy-saving components, you will bring some savings to your company.",
                            ImageURL = "/Images/Computers/Computer4.png",
                            Name = "Dell Vostro 3710 SFF i5-12400/16GB/512/Win11P",
                            Price = 3099m,
                            Qty = 30
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Lenovo IdeaCentre 3-27 is a stylish and powerful home computer. Powered by an Intel Core processor, it's designed to get things done quickly. It's also great for entertainment - it's equipped with a high-quality audio system, powerful speakers and a dazzling 27-inch Full HD screen.\r\n",
                            ImageURL = "/Images/Computers/Computer5.png",
                            Name = "Lenovo IdeaCentre AIO 3-27 i5-12450H/16GB/1TB/Win11",
                            Price = 3999m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Get to know MX Master 3S - a new version of the iconic mouse. Feel how every moment at work becomes more precise, tangible and efficient. It's all thanks to Quiet Clicks switches and an 8000 DPI sensor that works even on glass. Ergonomic design ensures comfortable work. However, the battery life is up to 70 days when fully charged.\r\n",
                            ImageURL = "/Images/Mouse/Mouse1.png",
                            Name = "Logitech MX Master 3S Grafit",
                            Price = 479m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Meet SteelSeries Rival 5 - an ergonomic mouse with 9 programmable buttons. Designed for maximum speed, it will give you an advantage in games such as Battle Royale, FPS, MOBA, and MMO. Thanks to the extensive equipment, you will take your gaming to a higher level. Play precisely and intensely with the modern TrueMove Air sensor and Golden Micro IP54 switches. Feel the real lightness, lack of resistance and master the game without any problems.\r\n",
                            ImageURL = "/Images/Mouse/Mouse2.png",
                            Name = "SteelSeries Rival 5",
                            Price = 40m,
                            Qty = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "The Logitech G502 HERO gaming mouse is a powerful gaming mouse that offers a whole set of features for gamers. Advanced optical sensor for maximum tracking precision, customizable RGB lighting, custom gaming profiles and repositionable weights. All this makes the G502 HERO Gaming Mouse the right tool to take on the challenge.\r\n\r\nCheck what the product looks like in reality. Grab the photo below and drag it left or right to rotate the product or use the navigation buttons.",
                            ImageURL = "/Images/Mouse/Mouse3.png",
                            Name = "Logitech G502 HERO",
                            Price = 40m,
                            Qty = 300
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Discover a new level of gaming with the SteelSeries Rival 3 Wireless mouse. Game with the performance of a wired mouse thanks to modern technologies and get rid of limitations. SteelSeries Rival 3 Wireless will delight you with its speed, accuracy and rich equipment. Consistent quality of operation is guaranteed by mechanical switches with a durability of up to 60 million clicks, while the ergonomic design will allow you to deal with opponents for long hours.\r\n",
                            ImageURL = "/Images/Mouse/Mouse4.png",
                            Name = "SteelSeries Rival 3 Wireless",
                            Price = 600m,
                            Qty = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Silver Monkey Wireless Comfort Silent Mouse M70 is a wireless mouse that will improve your working comfort while traveling as well as in your home office. Equipped with quiet buttons, it reduces up to 90% of noise, allowing you and those around you to fully focus on your work, thus reducing the feeling of fatigue associated with persistent clicking sounds. Silver Monkey M70 was designed for your comfort. Perfect profile with a streamlined shape, textured side panels and optimal size - perfect for your dynamic lifestyle.\r\n",
                            ImageURL = "/Images/Mouse/Mouse5.png",
                            Name = "Silver Monkey M70 Wireless Comfort Mouse Black Silent",
                            Price = 500m,
                            Qty = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "The latest Rival 3 mouse from SteelSeries is the successor to the legendary Rival 110 mouse. This means that it is even better than its brilliant predecessor. The Rival 3 mouse is made of very durable materials, and at the same time its design is light, comfortable and ergonomic.\r\n\r\nConsistent quality of operation is guaranteed by mechanical switches with a durability of up to 60 million clicks. The PixArt sensor offers precision and true 1:1 tracking of the user's movements.\r\n\r\nMoreover, thanks to the internal memory, you can save polling rate, button mapping and up to 5 CPI settings directly on the device.\r\n",
                            ImageURL = "/Images/Mouse/Mouse6.png",
                            Name = "SteelSeries Rival 3",
                            Price = 100m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "The Move to iOS app will help you seamlessly transfer photos, contacts and other data to your new iPhone.",
                            ImageURL = "/Images/Phones/Phone1.png",
                            Name = "Apple iPhone 15 128GB Black",
                            Price = 5400m,
                            Qty = 212
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "What has been prepared for you in the new Xiaomi POCO X5 5G 256 GB Black? As usual, you can count on high quality and modern components. These include a 120 Hz AMOLED screen, a triple camera system, and an efficient processor. There are also many valuable functions waiting for you that will certainly have a positive impact on your user experience. All this accompanied by a large capacity 5000 mAh battery with a 33 W fast charging function.\r\n",
                            ImageURL = "/Images/Phones/Phone2.png",
                            Name = "Xiaomi POCO X5 5G 8/256GB Black",
                            Price = 1350m,
                            Qty = 112
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Discover the unknown with a device of incredible power. ASUS ROG Phone 6 512 GB black uses a powerful Qualcomm® Snapdragon® 8+ Gen 1 processor and 16 GB RAM. These parameters will ensure smooth action during every game. And you'll see everything on a 6.78-inch display. It has a refresh rate of 165 Hz, which will provide you with an excellent visual experience. During a fight, use the AirTrigger 6 system and the Armory Crate application. Moreover, a good temperature will also be maintained. Thanks to the GameCool 6 cooling system.\r\n",
                            ImageURL = "/Images/Phones/Phone3.png",
                            Name = "ASUS ROG Phone 6 16/512GB Phantom Black",
                            Price = 3100m,
                            Qty = 90
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Here's Motorola Moto E22. It is made of the highest quality materials. Additionally, it is slim and elegant, and the hydrophobic coating protects it against splashes. An efficient processor and a capacious battery will make it easier for you to be mobile. Take beautiful photos with the main camera and enjoy the quality of videos displayed on a large and bright screen.",
                            ImageURL = "/Images/Phones/Phone4.png",
                            Name = "Motorola moto e22 4/64GB Crystal Blue 90Hz",
                            Price = 459m,
                            Qty = 95
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "Super bright display in a durable design. The easy way to shoot video with true cinematic storytelling. Turbo-fast chip. And a huge jump in battery performance, invaluable for everyday use.\r\n",
                            ImageURL = "/Images/Phones/Phone5.png",
                            Name = "Apple iPhone 13 128GB Midnight",
                            Price = 3500m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Meet the king of mobile productivity. This is the new realme 9 Pro 128 GB green. It is equipped with a Snapdragon 695 processor. Thanks to it, every activity will be carried out smoothly. Play various videos and their quality will be high. Importantly, the display has a refresh rate of 120 Hz. Thanks to it, the smearing effect will never appear on the smartphone screen again. There are also cameras. Choose the right one and start taking interesting photos. Then you can show them off to your friends.\r\n",
                            ImageURL = "/Images/Phones/Phone6.png",
                            Name = "realme 9 Pro 8+128GB Aurora Green 120Hz",
                            Price = 999m,
                            Qty = 73
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "Razer Ornata V2 is an ergonomic gaming keyboard characterized by high quality, reliability and fast response time. These are the qualities that will make you successful. Its functionality and design are typically adapted to gaming. The Razer Ornata V2 keyboard will help you turn the tide of the game in your favor.\r\n",
                            ImageURL = "/Images/Keyboards/Keyboard1.png",
                            Name = "Razer Ornata V2",
                            Price = 100m,
                            Qty = 50
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "It is known that a long game can be tiring. Both for you and for the keyboard itself. XPG Summoner Mini has been optimized with ergonomics in mind and is suitable for long gaming sessions. Made of high-quality materials, it is characterized by higher durability and resistance to vigorous hitting of the keys. Choose XPG Summoner Mini and take command on the battlefield.\r\n",
                            ImageURL = "/Images/Keyboards/Keyboard2.png",
                            Name = "XPG Summoner Mini (Outemu Red)",
                            Price = 150m,
                            Qty = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Play and enjoy the many features of the Silver Monkey X Mandrill keyboard. Made of ABS plastic, it will ensure durability and resistance to damage. The cotton sheath of the cable prevents it from getting tangled and preventing you from using the keyboard freely. You can place the Mandrill in a comfortable and stable position thanks to the rubberized legs. It also has a wrist rest, the ability to lock the \"Windows\" key and a multimedia control knob. Rubber dome switches will make your every press comfortable and precise.\r\n\r\nRecord macros and press multiple keys. Anti-ghosting technology for 26 keys will allow you to enter data smoothly and accurately. In addition, the RGB backlight will illuminate your desk with millions of colors.\r\n",
                            ImageURL = "/Images/Keyboards/Keyboard3.png",
                            Name = "Silver Monkey X Mandrill",
                            Price = 200m,
                            Qty = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Get ready to game in the best way possible with the SteelSeries Apex 3 TKL keyboard. It was designed to combine modern technologies with useful gaming functionalities. Thanks to this, each game will provide you with an amazing experience. The keyboard is equipped with switches that reduce friction, ensuring above-average durability. Order your copy and get into the game.\r\n",
                            ImageURL = "/Images/Keyboards/Keyboard4.png",
                            Name = "SteelSeries Apex 3 TKL",
                            Price = 120m,
                            Qty = 120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Are you looking for a simple and comfortable office set for work or home? Choose the Silver Monkey S41 keyboard and mouse. Wireless operation will provide you with maximum comfort of use, regardless of what activity you perform. Thanks to this set, you will get rid of the tangle of cables on your desk. The quiet and low-profile keyboard will make typing intuitive and light. However, this small mouse will transfer every movement with extraordinary accuracy. The elegant and minimalist design will fit any computer workstation.\r\n",
                            ImageURL = "/Images/Keyboards/Keyboard5.png",
                            Name = "Silver Monkey S41 Wireless keyboard and mouse set",
                            Price = 200m,
                            Qty = 100
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Dell KB216-B QuietKey is a unique keyboard in terms of simplicity and comfort of use. Ensure proper comfort of work in the office or at home. The elegant design will fit perfectly into the space on your desk. Take care of proper ergonomics when spending long hours in front of the computer. Choose Dell KB216-B QuietKey and increase your productivity.\r\n",
                            ImageURL = "/Images/Keyboards/Keyboard6.png",
                            Name = "Dell KB216-B QuietKey USB",
                            Price = 50m,
                            Qty = 150
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-desktop",
                            Name = "Computers"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-mobile-phone",
                            Name = "Phones"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-computer-mouse",
                            Name = "Mouse"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-keyboard",
                            Name = "Keyboard"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Bob"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Sarah"
                        });
                });

            modelBuilder.Entity("ShopOnline.Api.Entities.Product", b =>
                {
                    b.HasOne("ShopOnline.Api.Entities.ProductCategory", "ProductCategory")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
