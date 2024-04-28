using Fnunez.TiendaExpress.Domain.BrandAggregate;
using Fnunez.TiendaExpress.Domain.CategoryAggregate;
using Fnunez.TiendaExpress.Domain.CustomerAggregate;
using Fnunez.TiendaExpress.Domain.CustomerAggregate.Entities;
using Fnunez.TiendaExpress.Domain.ProductAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Fnunez.TiendaExpress.Infrastructure.Persistence.Contexts;

public class ApplicationDbContextSeeder
{
    private readonly ILogger<ApplicationDbContextSeeder> _logger;
    private readonly ApplicationDbContext _context;
    #region Identities
    private readonly string _identityId1 = "1b9de6c3-521d-457d-a83e-8110f48533ea";
    private readonly string _identityId2 = "f194b3c8-8f54-498c-b54d-78f938a29d94";
    private readonly string _identityId3 = "76fc18ad-6412-47c8-b311-823ff7ecdc14";
    #endregion
    #region Customers
    private readonly string _customerId1 = "4fc97fe8-f214-4106-a86b-41cee442dd6a";
    private readonly string _customerId2 = "02ce97c8-08b2-489f-9523-28eb6c60da0f";
    private readonly string _customerId3 = "737aea2d-2295-453b-a545-4723c8df464c";
    #endregion
    #region CustomerShippingAddresses
    private readonly string _customerShippingAddressId1 = "ac153acf-daf5-4828-83c2-d8d72f55e141";
    private readonly string _customerShippingAddressId2 = "b97f707b-69b6-43e2-9425-2a066c3bda0e";
    private readonly string _customerShippingAddressId3 = "d0647a61-e00d-4a0e-8c3c-858bce171902";
    #endregion
    #region Brands
    private readonly string _brandId1 = "5fe1e92d-f498-4c21-ab04-c9a7af95135a";
    private readonly string _brandId2 = "befca3c3-3cc3-4227-a1e7-439422bf3b11";
    private readonly string _brandId3 = "69bd2185-368c-4df2-bf18-40d709900ebc";
    private readonly string _brandId4 = "a4cbcf16-ad78-4fe0-a2f1-899c71492f76";
    private readonly string _brandId5 = "7cb53929-2fd7-4370-992c-b89dcdc5ef28";
    private readonly string _brandId6 = "71b07e7c-ddb6-4ba9-9410-c4fc49584af2";
    private readonly string _brandId7 = "fa4ec293-4597-41ce-a511-238533d7cf6b";
    private readonly string _brandId8 = "db8cb83d-e02f-4a7e-9691-9b6ca8f985b9";
    private readonly string _brandId9 = "24aa4674-b30c-4189-90aa-67e3fa4bacf9";
    private readonly string _brandId10 = "7e1e7a87-31fa-4a25-ab1a-cb92da6e8a25";
    private readonly string _brandId11 = "024bf0bc-7c47-40d2-ada8-f33bfe66394b";
    private readonly string _brandId12 = "8a633566-bb70-4ce9-a03d-7212ee5fb066";
    private readonly string _brandId13 = "6fb0ac82-c488-4e2c-bd0a-e4ab8c1fc698";
    private readonly string _brandId14 = "6587bc29-bb2b-41a4-9e26-2d13bbda980a";
    private readonly string _brandId15 = "e5541a1c-05cf-4a8e-8db4-e7a04fdeae31";
    private readonly string _brandId16 = "1623896b-1b54-4fe3-a040-c5af8a8cfa5d";
    private readonly string _brandId17 = "dab0da31-9860-40a7-b54d-75833ac4b1e3";
    private readonly string _brandId18 = "3e40091b-d35b-4f41-9d70-bc76fbd11c91";
    private readonly string _brandId19 = "4b573e94-b1c1-431e-9ef7-53767d3286e5";
    private readonly string _brandId20 = "b0cb7959-0f61-4186-9c21-5ac5ed653d37";
    #endregion
    #region Categories
    private readonly string _categoryId1 = "1a6d63a3-a6ca-4f31-a9b5-aafd37f41fa6";
    private readonly string _categoryId2 = "f602701b-5479-4490-99fe-6c2ff6f50336";
    private readonly string _categoryId3 = "f351ab30-eeef-42fd-9b5c-d17dbca5f480";
    private readonly string _categoryId4 = "9978abc1-6fda-4635-8def-01d68c0591ed";
    private readonly string _categoryId5 = "7bbdb1fa-d225-4b64-9116-91082e9c188a";
    private readonly string _categoryId6 = "45381d50-00d9-4586-bb6a-8d6b448db9cd";
    private readonly string _categoryId7 = "a8e37dfb-e035-4d0f-9f66-c7866f7af231";
    private readonly string _categoryId8 = "d3e8b73e-5880-44aa-9717-1d4015a1630b";
    private readonly string _categoryId9 = "d8b938dc-4d32-4a8b-8350-af98f8251d1b";
    private readonly string _categoryId10 = "fe181b26-bc02-408d-a848-e46a86d1d270";
    #endregion
    #region Products
    private readonly string _productId1 = "32f0627f-5150-468e-896e-b9f1717bc728";
    private readonly string _productId2 = "cb7d9d68-5db7-4fed-94c5-ee185e63bfd2";
    private readonly string _productId3 = "d08aa00b-abb9-4e25-aba4-c95cac7afa39";
    private readonly string _productId4 = "b44d4921-bcbd-42c6-85fb-214ae08fd6c7";
    private readonly string _productId5 = "4b516ede-4b07-4dc1-8034-0b6e441d9e3d";
    private readonly string _productId6 = "244d8425-9704-49fc-9468-0dc0afc85cb1";
    private readonly string _productId7 = "537f5763-6ae3-4e58-98c2-ef5b96b2524d";
    private readonly string _productId8 = "c58590b4-fcdf-4e68-a06d-7373e793fa0b";
    private readonly string _productId9 = "25701b3f-b8e3-402c-ac35-0cb5a3d0f033";
    private readonly string _productId10 = "e5ade48e-130b-487f-8913-2cd3de628cb0";
    private readonly string _productId11 = "afe0edf1-e637-4f7a-a3d9-341abcd4d419";
    private readonly string _productId12 = "936fbf59-cf58-4b6a-9a45-4b68a96c9ea7";
    private readonly string _productId13 = "f2bc1fc1-edb4-4a3e-b1ed-c015dda71bce";
    private readonly string _productId14 = "e40cd518-18c6-47fa-b4c8-39c00beb740d";
    private readonly string _productId15 = "78ec726d-9416-41a6-b16a-a660c9c7d490";
    private readonly string _productId16 = "d2424ca7-be13-41cf-a35a-00002bcf51fc";
    private readonly string _productId17 = "68f30078-29de-43f6-82f6-4a79e4eb1bc9";
    private readonly string _productId18 = "06f401f6-860f-4d94-ba1b-90b1b7b94af4";
    private readonly string _productId19 = "09b147e5-d105-47a8-8a02-8c29bb8ca7b1";
    private readonly string _productId20 = "12d6e716-1ca1-427e-9dae-4f1e6930c0e6";
    #endregion

    public ApplicationDbContextSeeder(
        ILogger<ApplicationDbContextSeeder> logger,
        ApplicationDbContext context)
    {
        _logger = logger;
        _context = context;
    }

    public async Task MigrateAsync()
    {
        try
        {
            if (_context.Database.IsNpgsql())
                await _context.Database.MigrateAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while initialising the database.");
            throw;
        }
    }

    public async Task SeedDataAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while seeding the database.");
            throw;
        }
    }

    private async Task TrySeedAsync()
    {
        if (!await _context.Brands.AnyAsync())
        {
            await _context.Brands.AddRangeAsync(GetBrands());
            await _context.SaveChangesAsync();
        }

        if (!await _context.Categories.AnyAsync())
        {
            await _context.Categories.AddRangeAsync(GetCategories());
            await _context.SaveChangesAsync();
        }

        if (!await _context.Products.AnyAsync())
        {
            await _context.Products.AddRangeAsync(GetProducts());
            await _context.SaveChangesAsync();
        }

        if (!await _context.Customers.AnyAsync())
        {
            await _context.Customers.AddRangeAsync(GetCustomers());
            await _context.SaveChangesAsync();
        }

        if (!await _context.CustomerShippingAddresses.AnyAsync())
        {
            await _context.CustomerShippingAddresses.AddRangeAsync(GetCustomerShippingAddresses());
            await _context.SaveChangesAsync();
        }
    }

    private IEnumerable<Brand> GetBrands()
    {
        return [
            new Brand(_brandId1, "NOANTA", _brandId1),
            new Brand(_brandId2, "Polly-Fil", _brandId2),
            new Brand(_brandId3, "ACCMOUNT", _brandId3),
            new Brand(_brandId4, "WITLIGHT", _brandId4),
            new Brand(_brandId5, "EVLA'S", _brandId5),
            new Brand(_brandId6, "Little Traveler", _brandId6),
            new Brand(_brandId7, "Himart", _brandId7),
            new Brand(_brandId8, "BEAKEY", _brandId8),
            new Brand(_brandId9, "Logitech", _brandId9),
            new Brand(_brandId10, "macard", _brandId10),
            new Brand(_brandId11, "AiTechny", _brandId11),
            new Brand(_brandId12, "Midland", _brandId12),
            new Brand(_brandId13, "Doparet", _brandId13),
            new Brand(_brandId14, "LDIIDII", _brandId14),
            new Brand(_brandId15, "YETI", _brandId15),
            new Brand(_brandId16, "Coleman", _brandId16),
            new Brand(_brandId17, "DEWALT", _brandId17),
            new Brand(_brandId18, "Makita", _brandId18),
            new Brand(_brandId19, "POPLAY", _brandId19),
            new Brand(_brandId20, "LEGO", _brandId20)
        ];
    }

    private IEnumerable<Category> GetCategories()
    {
        return [
            new Category(_categoryId1, "Arts & Crafts", "Arts & Crafts", _categoryId1),
            new Category(_categoryId2, "Automotive", "Automotive", _categoryId2),
            new Category(_categoryId3, "Baby", "Baby", _categoryId3),
            new Category(_categoryId4, "Beauty & Personal Care", "Beauty & Personal Care", _categoryId4),
            new Category(_categoryId5, "Computers", "Computers", _categoryId5),
            new Category(_categoryId6, "Electronics", "Electronics", _categoryId6),
            new Category(_categoryId7, "Pet Supplies", "Pet Supplies", _categoryId7),
            new Category(_categoryId8, "Sports & Outdoors", "Sports & Outdoors", _categoryId8),
            new Category(_categoryId9, "Tools & Home", "Tools & Home", _categoryId9),
            new Category(_categoryId10, "Toys & Games", "Toys & Games", _categoryId10)
        ];
    }

    private IEnumerable<Product> GetProducts()
    {
        return [
            new Product(
                _productId1,
                _brandId1,
                _categoryId1,
                "20 pcs. Large Eye Hand Sewing Needles - 1.5 inch Long in Needle Storage Tube with Needle Threader",
                "20 pieces Large Eye Hand Sewing Needles Sizes 1.5 inches.\nGreat for hand sewing, stitching, and other sewing projects.\nThe Set assembled of 20 steel needles and 1 metal threader.\nThe needles with large eye are durable, high quality, and easy-to-use.\nThe threader makes easy threading of any thickness.\nThese Big Eye Needles are individually-packaged, so they are great for storage, travel, and sharing with friends.",
                _productId1,
                6.99m,
                "32f0627f-5150-468e-896e-b9f1717bc728_AC_480,480.jpg",
                10
            ),
            new Product(
                _productId2,
                _brandId2,
                _categoryId1,
                "NOANTA Natural Macrame Cord 3mm x 109Yards, Beige Macrame Rope, Cotton Cord for Wall Hanging, Plant Hangers, Christmas Crafts, Knitting",
                "Made from Quality Cotton Fiber: People demand soft, durability, and strength for their macrame needs, and we keep sourcing the best raw material cotton fiber to help protect our brand; Great basis for all your home decor,chrismas decor or macrame projects.\nSoft, Durable, Easy to Work With: Our macrame cord is gently twisted but also strong enough, super soft to the touch to protect the hands, smooth, sturdy, and easy to work with.\nTons Of Uses : Plenty of ropes with tons of possibilities; You can use this cotton rope for macrame wall hanging, plant hangers, dream catcher, gardening, gift wrapping, packing material, jewelry and crafts, pets toys and more; Overall, good quality and useful for having around the house.\nMade from Quality Cotton Fiber: People demand soft, durability, and strength for their macrame needs, and we keep sourcing the best raw material cotton fiber to help protect our brand; Great basis for all your home decor or macrame projects.\n",
                _productId2,
                4.99m,
                "cb7d9d68-5db7-4fed-94c5-ee185e63bfd2_AC_415,480.jpg",
                10
            ),
            new Product(
                _productId3,
                _brandId3,
                _categoryId2,
                "Car Jump Starter, 3000A Peak Lithium Jump Starter Battery Pack for Up to 10.0L Gas or 8.0L Diesel Engine, Safe 12V Portable Battery Starter Power Pack with LED Screen & LED Light",
                "Powerful Jumping Performance: This 3000-Amp peak lithium car jump starter can start a vehicle(Up to 10.0L gas/ 8.0L Diesel Engine) in seconds, up to 60 times jump-start on a fully charge, suitable for car, truck, motorcycle, boat, RV or tractor and so on.\nPortable Power Supply: With dual USB 3.0 5V/3A, 9V/2A, 15V/1.5A output, this car starter battery pack can be used as a power bank to charge smartphone, iPad, and other USB devices.\nMulti-Protection: Acmount Jump starter uses design of Integrated Battery and Intelligent Clamps, which is fully insulated and safe enough. 10 types of protection include spark-proof, reverse-polarity protection to protect you from failure problems such as short circuits or sparks.\nLED Flashlight & Long Battery Life: The battery starter utilizes bright LED flashlight with 3 modes :Flash Light, Strobe Light, and SOS Light. When not in use, this car battery starter can hold power for about 24 months, always ready for help you.\nWhat U Will Get: Acmount P100 Jump Starter, Smart Jump Cables, USB Type-C Charging Cable, Storage Case, User Manual; 3-Year Warranty and Life time reliable Technical Support. Any questions about product, contact us and you will get a satisfactory solution.",
                _productId3,
                69.99m,
                "d08aa00b-abb9-4e25-aba4-c95cac7afa39_AU_480,410.jpg",
                10
            ),
            new Product(
                _productId4,
                _brandId4,
                _categoryId2,
                "Tire Inflator Air Compressor, Compatible with Dewalt 20v Max Battery WITLIGHT 160 PSI Cordless Portable Electric Air Pump with Digital Pressure Gauge for Car, Bike, Sport Ball (TOOL BARE) (Yellow)",
                "This portable air compressor is compatible with dewalt 20V max Lithium Battery. We sell tools only, NO BATTERY! We provide 5-year warranty and 24 / 7 customer service for the air compressor , so please contact us if you have any question about the product.\nPowerful & Fast Inflation: This tire inflator with powerful cylinder air pump provides a maximum pressure of 160 PSI and air flow of 12L/Min, which means it can inflate the 195/55/R15 car tire from 0 to 35psi within 3 minutes, faster than conventional car air pumps.\nAuto Shut off: The air pump has 3 optional units including PSI, BAR, KPA. Preset the desired pressure level by pressing the \"+\" and \"-\" buttons. The car air compressor will shut off automatically at the desired level. No worry about over-inflating.\nDigital Display & LED Lighting: The back-lit LCD screen shows real-time pressure and preset values, The LED light also allows you to inflate in the dark. The light will turn off automatically after 5 minutes no use.\nConvenient & Multi-Use: The portable air pump is cordless with compact design that weighs only 1.6lb, you can take it to help you anytime and anywhere. Comes with 3 nozzles for cars, motorcycles, bicycles, sport balls and inflatable pool toys, etc.",
                _productId4,
                29.99m,
                "b44d4921-bcbd-42c6-85fb-214ae08fd6c7_AU_474,480.jpg",
                10
            ),
            new Product(
                _productId5,
                _brandId5,
                _categoryId3,
                "EVLA'S Baby Food Maker, Healthy Homemade Baby Food in Minutes, Steamer, Blender, Baby Food Processor, Touch Screen Control, includes 6 Reusable Food Pouches for Storage or Travel, White",
                "FOOD BLENDER & STEAMER IN ONE: EVLA’S baby food maker steaming function allows you to cook ingredients well before blending, preserving their natural flavor, then puree and blend fruits, vegetables, and meats into a smooth, consistent texture.\nHIGH QUALITY, FOOD BLENDER & STEAMER: Safety is a top priority when it comes to our baby food processor. That's why we've crafted it from high-quality, food-grade materials that are safe and durable. It is BPA-free, ensuring that your baby's food is free from harmful chemicals and toxins.\nFAST & EASY HEALTHY BABY FOOD MAKER: With 3 easy steps, add water to water tank, add desired ingredients, touch screen start - preparing healthy homemade food for your growing little one cannot be simpler or easier. Our baby food maker not only saves time and money but also ensures that only the ingredients you want are added to your baby’s food.\nSIMPLE TOUCH SCREEN CONTROL: The intuitive touch screen controls of our baby food processor allow you to easily select your desired settings, making meal prep a breeze. With just a few taps, you can adjust the blending speed, temperature, and steaming time to suit your specific needs and preferences.\nSELF-CLEANING BABY FOOD MAKER: Our baby food processor is designed to be self-cleaning, saving you time and effort when it comes to cleaning up after mealtime. Simply add water and a drop of detergent, and the machine will do the rest, leaving you with a clean, hygienic appliance ready for the next use.",
                _productId5,
                124.97m,
                "4b516ede-4b07-4dc1-8034-0b6e441d9e3d_BA_480,462.jpg",
                10
            ),
            new Product(
                _productId6,
                _brandId6,
                _categoryId3,
                "Airplane Seat Extender for Kids - Footrest & Toddler Airplane Bed - Toddler Airplane Travel Essentials - Toddler Plane Seat Extender & Airplane Kids Bed - Up to 4 Years of Age",
                "100% Polyester.\nEnhanced Comfort for Parents and Child: Our toddler airplane seat extender is specifically designed for use as a comfortable footrest and bed for kids. The airplane bed for toddler provides additional support and space, allowing your child to relax, rest, and sleep better. Take the portable bed for kids along with you and alleviate the stress often faced during flight. Say goodbye to restless flights and hello to your newest baby airplane essentials!.\nStay Dry and Hassle-Free: The airplane toddler bed offers a cozy resting spot and safeguards against spills with its water-resistant feature. No more worries about liquid seeping through and compromising the seat's integrity. If you're seeking to enhance your toddler airplane travel essentials, this innovative and protective airplane bed for kids is your go-to solution!.\nCustomisable Design: Tailor your child's comfort with our adjustable toddler plane bed. With a length of 31\" and the ability to shorten it to 25.5 inches, this versatile travel with toddler must haves, seamlessly adapts to various aircraft and seat configurations. An ideal choice for your baby plane travel essentials.\nCompact and Portable: Traveling with bulky and cumbersome accessories can be a hassle, but our travel bed for baby, an essential among kid travel essentials, is designed with portability in mind. Packaged in a lightweight drawstring bag with a built-in hook for easy access and hands-free carrying. Simply attach the baby airplane bed to your travel backpack or hand luggage and enjoy hassle-free transportation.\nEffortless Setup: Transforming into a footrest or toddler flight bed has never been easier. With quick and secure installation, the included instruction manual offers two attachment options. Simply follow the guidelines for a proper setup and let you little one enjoy its kids plane bed. Elevate your air travel and include kids airplane essentials to ensure a smooth flight.",
                _productId6,
                34.99m,
                "244d8425-9704-49fc-9468-0dc0afc85cb1_BA_462,480.jpg",
                10
            ),
            new Product(
                _productId7,
                _brandId7,
                _categoryId4,
                "Hair Cutting Scissors Professional Home Haircutting Barber/Salon Thinning Shears Kit with Comb and Case for Men/Women (Sliver)",
                "Double the Cutting Possibilities - Two pairs of haircutting shears: one with straight blades and one with textured blades. You can give yourself a professional cut at home with this trimmers and cutters. Save money from going to salon.\nRegular Hair Cutting Scissors - This specialized high quality stainless steel Hair Cutting scissor is tempered with precise blades and hand-sharpened cutting edges to evenly trim hair with ease. Ideal for removing length, trimming and cutting layers.\nThinning Scissors - Blades are convex hollow ground for improved razor edge retention; thinning contains teeth on one blade and a smooth razor edge on second.Ideal for layering and adding texture to hairstyles.\nErgonomic Grip - It is a new design with blue adjustment tension to make it easier and more comfortable when you are cutting hair.\nPlease note that the scissors are NOT waterproof. Please don't use it with water. Package Included: 1 x Regular hair scissors; 1 x thinning scissor; 1x cleaning cloth; 1 x grooming comb; 2 x hairpins; 1 x free case.",
                _productId7,
                13.99m,
                "537f5763-6ae3-4e58-98c2-ef5b96b2524d_BP_458_480.jpg",
                10
            ),
            new Product(
                _productId8,
                _brandId8,
                _categoryId4,
                "BEAKEY 5 Pcs Makeup Sponge Set, Latex Free Makeup Sponges for Foundation, Multi-colored Boun Boun Sponges, Flawless for Liquid, Cream, and Powder",
                "HIGH-QUALITY BK BOUN BOUN SPONGES: This pack of 5 BEAKEY makeup sponges offers excellent quality and texture, providing a smooth makeup application, ideal for setting and baking makeup. Suitable for mothers day gifts.\nNON-LATEX AND GENTLE ON SKIN: These soft, lightweight, and non-latex big beauty sponges are gentle on sensitive skin and don't absorb too much product, working well with various types of foundation and setting powder.\nEASY TO USE AND CLEAN: Our foundation sponges are user-friendly and simple to clean, designed with perfect hardness, texture, and a teardrop shape for easy blending of cosmetics like concealer.\nDURABLE AND REUSABLE: Made with high-quality materials, these makeup sponges for foundation are designed for multiple uses while maintaining consistent performance.\nVIBRANT COLORS AND TRAVEL-FRIENDLY: Comes in a variety of nice colors, making it easy to differentiate between different makeup products, and their convenient size makes them perfect for travel.",
                _productId8,
                6.99m,
                "c58590b4-fcdf-4e68-a06d-7373e793fa0b_BP_480,480.jpg",
                10
            ),
            new Product(
                _productId9,
                 _brandId9,
                _categoryId5,
                "Logitech H390 Wired Headset for PC/Laptop, Stereo Headphones with Noise Cancelling Microphone, USB-A, in-Line Controls for Video Meetings, Music, Gaming and Beyond - Black",
                "Digital Stereo Sound: Fine-tuned drivers provide enhanced digital audio for music, calls, meetings and more.\nRotating Noise Canceling Mic: Minimizes unwanted background noise for clear conversations; the rotating boom arm can be tucked out of the way when you’re not using it.\nHandy In-line Controls: Simple in-line controls on the headset cable let you adjust the volume or mute calls without disruption.\nPlug-and-Play USB Computer Headset: Simply plug the USB-A connector into your computer and you’re ready to talk or listen without the need to install software.\nPadded Comfort: Comfortable headphones with adjustable headband features swivel-mounted, leatherette ear cushions for hours of comfort and is easy to clean.\nMove Freely With Long Cable: The 6.23 ft (1.9 m) USB A cable is just the right length to give you the freedom to stand up and stretch during long conversations.\nResponsible Packaging: H390 Logitech Headset uses FSC-certified paper for responsible packaging.",
                _productId9,
                20.00m,
                "25701b3f-b8e3-402c-ac35-0cb5a3d0f033_CO_360,460.jpg",
                10
            ),
            new Product(
                _productId10,
                _brandId10,
                _categoryId5,
                "Fastest WiFi Extender/Booster | Latest Release Up to 74% Faster | Broader Coverage Than Ever WiFi Extenders Signal Booster for Home | Internet Booster WiFi Repeater, w/Ethernet Port, Made for USA",
                "Up to 9K+Square Feet! Blast Through Barriers, Eliminate Dead Zone Zombies- Indoors and Outside: never get stuck behind thick walls, appliances and cement floors, Macard delivers ultra-stable bandwidth for online gaming, video conferences and even streaming 4K HD videos.\n45+ Devices, Zero Bog – House full of data hogs? Macard’s internet range booster with ethernet port eliminates the problems fast! Pumping out interference-free, lightning-fast data capabilities to all tablets, Fire Stick, Roku, smart speakers, Alexa devices for home, IP cameras and whatever the innerwebs invents next. Without bogging your own stream down.\nUSA standards – Bank Level Financial Security – With performance this powerful Wi-Fi Signal Booster pairs with our 2.4GHz processor to facilitate WEP/WPA/WPA 2 security protocols that make your local bank jealous. The ideal Wi-Fi extender for a houseful of kids who ‘download things they…ahem…shouldn’t’.\nCan You Push a Button? You’re set up! Single Tap WPS connects your device within a few seconds. No standing around waiting for ‘lights to activate’. Unbox. Plug in. Hold by router. Tap.\n5 Modes – Latest 2023 Advanced Upgrade: Whether you’re running a business, running to online class or simply streaming 45 devices, this 5 Mode wireless router gets it done. Take it home. Follow the directions. Choose router, repeater, access point, client or wisp mode and BOOM – you’re streaming faster, further and stronger than all your neighbors combined. Guaranteed to spread a satisfying smile across your face.",
                _productId10,
                35.99m,
                "e5ade48e-130b-487f-8913-2cd3de628cb0_CO_360,460.jpg",
                10
            ),
            new Product(
                _productId11,
                _brandId11,
                _categoryId6,
                "Digital Camera for Kids, 1080P FHD Camera, 44MP Point and Shoot Digital Camera for Pictures with 32GB Card, 16X Zoom, Compact Small Vintage Camera Gifts for Teens Kids Boys Girls(Pink)",
                "【High-Resolution Imaging & Easy Operation】AiTechny Digital Camera is equipped with a high-resolution CMOS sensor and an IPS color screen. With the capability to capture 44MP photos and record in smooth 1080p video, your memories come to life. Designed for kids, teens, and beginners, this point-and-shoot digital camera requires no intricate setup. Ideal for nurturing kids' interest in photography and crafting delightful moments with family and friends.\n【Practical & Fun】This digital camera for kids simplifies photography for your enjoyment. With a 16x digital zoom, you can capture every detail you desire. Fill light ensures your shots are well-lit and clear. Get creative with 20 unique filters and explore fun features like anti-shake and the self-timer. With a built-in microphone, it records crisp FHD 1080p video and doubles as a webcam. Whether you're recording daily moments, taking travel selfies, or vlogging, this camera has you covered.\n【Rechargeable & Portable】 No need to remove the battery for charging; simply use the included USB-C charging cable to charge your compact digital camera anytime, anywhere. With its long-lasting, high-capacity battery, this small digital camera allows you to shoot all day without worrying about running out of power. Its pocket-sized, lightweight design ensures it's always ready to accompany you on your travels or daily adventures.\n【Image Transfer & 32GB Card】Effortlessly transfer your images from the digital camera to your computer or smartphone. This cameras for pictures comes with a 32GB card, ensuring ample storage for preserving precious memories. Use the provided USB-C cable to swiftly download pictures and videos to your computer. Alternatively, you can utilize an card reader (not included) to transfer pictures and videos from the camera's card to your phone for convenient sharing on social media.\n【Exceptional Service & Perfect Gift】Backed by 12 months hassle-free promise- refund and replacement. But that's not all – Beautifully packaged, this vintage digital camera is the ideal gift for those special moments! Whether it's your child's first kids camera or a thoughtful surprise for a best friend, it's an excellent choice. Ideal for gifting on holidays like Christmas and Thanksgiving, as well as for birthdays, graduations, and Valentine's Day.",
                _productId11,
                45.99m,
                "afe0edf1-e637-4f7a-a3d9-341abcd4d419_EL_480,406.jpg",
                10
            ),
            new Product(
                _productId12,
                _brandId12,
                _categoryId6,
                "Midland- T51VP3 X-TALKER Spotting and Recovery Walkie-Talkie Long Range - FRS Two Way Radio for kids Caravanning with NOAA Weather Scan + Alert, 38 Privacy Codes - Black/Orange - 2 Pack",
                "2-way Radios: Experience license-free connectivity with our walkie-talkies operating on 22 FRS channels. Stay informed with channel scan, enjoy versatile applications, and rely on reliable and clear communication. These user-friendly devices are compact, portable, and offer enhanced privacy with 38 codes. With long-lasting battery life, expandable range, and the peace of mind they provide, stay connected effortlessly in any situation.\nCompact and Portable: Take these walkie-talkies with you wherever you go. Compact and lightweight, they can effortlessly accompany you on your adventures. Attach them to your belt using the convenient clips or slip them into your pocket for easy access. Compact size, they won't weigh you down or hinder your mobility. These walkie-talkies are designed to be your constant companions, no matter where you go. Having these walkie-talkies by your side ensures that communication is always within reach.\nPrivacy Codes: Take your communication to a new level of privacy and customization with the Midland X-TALKER Walkie-Talkies. You can enjoy confidential and uninterrupted conversations with 38 CTCSS Privacy Codes. The Continuous Tone-Coded Squelch System gives you up to 836 channel options to block other conversations. Choose the code that suits your needs, ensuring your conversations remain private and interference-free. This feature allows you to communicate securely and confidently.\nNOAA Weather Scan + Alert: NOAA Weather Scan will automatically scan through 10 available weather (WX) band channels and locks onto the strongest weather channel to alert you of severe weather updates. NOAA Weather Alert will sound an alarm indicating that there is a risk of severe weather in your area. NOAA Weather Radio will also be used to broadcast AMBER alerts for missing children.\nHands-Free: Experience the ultimate of hands-free communication with our walkie-talkies' eVOX technology while enjoying the peace of mind that comes with a complete package of accessories to ensure a seamless and user-friendly experience. Stay connected without lifting a finger. Our walkie-talkies feature Easy Voice and Sound Activation Transmission (eVOX) with 3 sensitivity levels, allowing you to communicate hands-free. Simply speak, and the walkie-talkie automatically transmits your voice.",
                _productId12,
                49.99m,
                "936fbf59-cf58-4b6a-9a45-4b68a96c9ea7_EL_468,480.jpg",
                10
            ),
            new Product(
                _productId13,
                _brandId13,
                _categoryId7,
                "Dog Shock Collar, Dog Training Collar with Remote 3300FT, Rechargeable Waterproof Electronic Training Collar for Large Medium Small Dogs 8-120 lbs with Beep Vibration and Safe Shock Modes",
                "Customizable electric dog collar modes: This shock collar for dogs is suitable for small, medium, and large dogs weighing 8-120 lbs. It offers humane beep, vibration, and adjustable shock levels to effectively train your pet. Ensure your furry friend learns proper behavior with Doparet shock collar.\n3300FT remote range: E collar for dogs training offers an impressive remote range of up to 3300ft, allowing for extensive outdoor training. It also has the capability to train up to 3 dogs simultaneously, making it suitable for households with multiple pets. Enjoy ample freedom and convenience in training your dogs with our dog training collar.\nLong-lasting battery life: The remote training collar boasts an extended battery life, reducing the frequency of recharging and ensuring convenience during outdoor activities like camping and hiking. Dog shock collars can be fully charged within 2 hours, offering 90 days of remote standby and 60 days of receiver standby, allowing for long-lasting usage.\nWaterproof and comfortable training collar design: Waterproof training collar for dogs and an adjustable collar size of 7 to 27 inches ensure safe and effective training in different weather conditions. Additionally, the dog shock collar for large dogs wireless minimizes strain on the dog's neck, providing both comfort and effectiveness during training session.\nOur user-friendly training collar is equipped with several convenient features to enhance the overall training experience for dog owners. These include a security lock, a dog finder light, and a clear digital screen. With these features, using the small large dog shock collar becomes easier, more efficient, and more enjoyable for both you and your furry companion.",
                _productId13,
                16.99m,
                "f2bc1fc1-edb4-4a3e-b1ed-c015dda71bce_PS_320,480.jpg",
                10
            ),
            new Product(
                _productId14,
                _brandId14,
                _categoryId7,
                "Dog Toothbrush Dog Tooth Brushing Kit 4Pack Dog Finger Toothbrush for Dog Teeth Cleaning&Dog Dental Care,Cat Toothbrush Dog Tooth Brush Puppy Toothbrush Pet Toothbrush",
                "【Loved By Dogs and Cats】LDIIDII dog finger toothbrush use 2023 original look and design is cute and colorful,make pet more willing to accept.The finger toothbrush for dogs cats will not cause irritation to the dog's mouth during use and has a good taste; dog toothbrush finger toothbrush is equipped with soft and wearable bristles,easy dog teeth cleaning,making dog dental care easier,dog teeth cleaning kit loved by dogs and cats pets,pet parents no longer worry about dog teeth cleaning.\n【Multifunctionality】Finger toothbrush for dogs cats can be used not only for dog teeth cleaning,but also for massaging gums and cleaning tongue.2023 new upgraded head large particles thimble massage gums,front finger pattern scraping tongue plate design,clean tongue;internal non-slip design,more snug fingers.dog finger toothbrush large breed is more flexible to use,you can control the strength as needed.Dog finger toothbrush is the essential pet supplies for dogs.\n【Safe for Pet】Dog toothbrushes are made of high quality food grade silicone, BPA free, soft texture, non-toxic and harmless, high temperature resistant, safe for pet, will not cause any harm to your pet, ensure your pet's teeth health and better brushing experience. finger brush for dogs teeth is easy to clean, put in storage box after washing,can keep the dog finger toothbrush clean.\n【Convenient and Easy to Use】LDIIDII finger toothbrush for dogs cats has a humane design with a comfortable finger sleeve that fits easily on the finger and is easy to use.puppy toothbrush for small dogs has soft and dense bristles,making it easier to control and Clean hard to reach areas and for sensitive pets,the cat toothbrush cat finger toothbrush is gentle enough to make cat teeth cleaning and cat dental care easier.\n【Happy Time with Your Dog and Cat Pets】Dog teeth cleaning and dog dental care are good for your dog's longevity and health, regular use of puppy toothbrush for small dogs can effectively freshen breath, clean dog teeth, prevent oral diseases and maintain oral The effect of using puppy toothbrush and toothpaste together is even better.\n【Wide Applicability & Many Colors Available】 Pet toothbrush small dog toothbrush is suitable for all kinds of pets, including dogs, cats, rabbits, etc. dog toothbrush kit is especially suitable for all kinds of dog breeds, including small dogs, medium dogs and large dogs. dog finger toothbrush small breed breed is available in a variety of colors, puppy tooth brushing kit can meet the needs of different consumers.\n【Reusable】 Dog finger toothbrush small breed can be reused, just rinse it off with water. It is durable and can save the purchase cost. Compared to disposable small dog tooth brushing kit and teeth cleaners, dog tooth brushing kit small dog is more economically priced!.",
                _productId14,
                6.97m,
                "e40cd518-18c6-47fa-b4c8-39c00beb740d_PS_480,467.jpg",
                10
            ),
            new Product(
                _productId15,
                _brandId15,
                _categoryId8,
                "YETI Rambler Jr. 12 oz Kids Bottle, with Straw Cap",
                "YETI kids need a bottle that can keep up. Introducing Rambler Jr. - a small-and-mighty kids bottle over-engineered for your little wild ones.\nDishwasher Safe - As a well-deserved convenience to you, we made sure both the bottle and cap are dishwasher safe (because one less chore sounds nice).\n18/8Stainless Steel - Withstands all dents and drops and BPA-Free so they can safely sip without a worry in the world.\nNo Sweat Design - Keeps their hands dry - critical when summiting the jungle gym, and the Duracoat color won’t crack or peel.\nStraw Cap - Ultra leak & shatter-resistant ideal for impromptu rowdiness. Recess is no match for the Straw Cap.",
                _productId15,
                25.00m,
                "78ec726d-9416-41a6-b16a-a660c9c7d490_SO_227,480.jpg",
                10
            ),
            new Product(
                _productId16,
                _brandId16,
                _categoryId8,
                "Coleman Chiller JUG 1 GAL 6001 Ocean C6",
                "COLEMAN 2158645 CHILLER JUG 1 GAL 6001 OCEAN C6.",
                _productId16,
                10.56m,
                "d2424ca7-be13-41cf-a35a-00002bcf51fc_SO_314,480.jpg",
                10
            ),
            new Product(
                _productId17,
                _brandId17,
                _categoryId9,
                "DEWALT 20V MAX Power Tool Combo Kit, 10-Tool Cordless Power Tool Set with 2 Batteries and Charger (DCK1020D2)",
                "DCD771 in the cordless drill combo kit has a high speed transmission that delivers two speeds (0-450 & 1,500 rpm) for a range of fastening and drilling applications.\nDCF885 in the cordless tools combo kit offers 1-handed loading for its 1/4-inch hex chuck that accepts 1-inch bit tips.\nDCS381 with keyless blade clamp as one of the essential construction tools allows for quick blade change without touching blade or reciprocating shaft.\nDCL040 is a bright flashlight to illuminate your work area with LED output of 110 lumens.\nDCE100 has Max Air Flow of 100CFM.\nDCS393 with 6-1/2-inch carbide blade can cut 2x4's at a 45-degree angle in a single pass.\nDCR006 runs off DEWALT 12V/20V MAX* battery packs and has Bluetooth 4.0.\nDCG412 has an 8,000 rpm motor that provides high power for cutting and grinding applications.\nDCS355 has a Quick-Change accessory system that allows blades and attachments to be changed quickly without wrenches.\nDCV517 has a Gore HEPA wet/dry filter which traps 99.97% of dust at 0.3 microns.",
                _productId17,
                844.99m,
                "68f30078-29de-43f6-82f6-4a79e4eb1bc9_TH_480,394.jpg",
                10
            ),
            new Product(
                _productId18,
                _brandId18,
                _categoryId9,
                "Makita XT269T 18V LXT Lithium-Ion Brushless Cordless 2-Pc. Combo Kit (5.0Ah)",
                "Efficient BL Brushless motor is electronically controlled to optimize battery energy use for up to 50% longer run time per charge.\nThe BL Brushless motor eliminates carbon brushes, enabling the BL motor to run cooler and more efficiently for longer life.\nThe electronically-controlled BL Brushless motor efficiently uses energy to match torque and RPM to the changing demands of the application.\nVariable 2-speed 1/2\" Hammer Driver-Drill (0-500 & 0-2, 000 RPM) with BL Brushless motor delivers 530 in pounds. Of max torque; weighs only 4.2 pounds with battery.\nVariable speed impact driver (0-3, 400 RPM & 0-3, 600 IPM) with BL Brushless motor delivers 1, 500 pounds of max torque; weighs only 3.3 pounds with battery.",
                _productId18,
                309.00m,
                "06f401f6-860f-4d94-ba1b-90b1b7b94af4_TH_480,331.jpg",
                10
            ),
            new Product(
                _productId19,
                _brandId19,
                _categoryId10,
                "POPLAY Rubber Chicken/Squeeze Chicken, Decompressive/Vent Toy, Prank Novelty Toy, Silly Novelty Party Favors for Kids, Adults, Dogs, Family Games,Keep Your Chicken Quiet Easter Goodie",
                "❤Material: Made from durable rubber, can withstand countless of fun squeezing.\n❤Convenient Design - Our rubber chicken is separated design. if the upper body falls during the dog's play, don't feel panicked, body separation can be installed immediately。It is simple and practical. If you have any questions during use, you can contact us at any time. we recall the excellent after-sales service to reward you.❤Easy to play: Just squeeze it and let it squawk and make a lot of fun.This Practical Joke Rubber Chicken is a Classic Gag That Never Goes Out of Style.\n❤Function: How a good decompressive / vent toys. When you are feeling stressed, you can press it by its shrieks for decompression.\n❤Great Gift: Perfect for kids, adults and also a perfect toys for your dog.Squeeze chicken will make everybody laugh. Nobody can resist the Rubber Chicken!",
                _productId19,
                6.99m,
                "09b147e5-d105-47a8-8a02-8c29bb8ca7b1_TG_109,480.jpg",
                10
            ),
            new Product(
                _productId20,
                _brandId20,
                _categoryId10,
                "LEGO Minecraft The Armory Building Set, Includes Popular Minecraft Figures Alex and Armorsmith, Action Toy for Gamers and Kids, Gift for Boys and Girls 7 Years Old and Up, 21252",
                "Versatile LEGO Minecraft building set – This 203 piece hands-on Minecraft armory and adventure toy for kids offers boys and girls ages 7 and up a gateway to creative Minecraft adventures.\nAction hero toys – Includes Minecraft Alex and Armorsmith minifigures, 3 buildable environments and Minecraft armor with a golden axe, 2 swords, 2 shields and an enchanted trident.\n3-part building toy for kids – Includes a workplace with an anvil, furnace, grindstone and cauldron, an armor display room with a chest, and a Minecraft Nether portal with swinging doors.\nRare terracotta tiles – This authentically detailed LEGO Minecraft building kit includes terracotta tiles, which are highly prized by Minecraft players.\nGift for 6-year-olds and up – Treat Minecraft players to this hands-on, building-and-action toy featuring Minecraft characters in a biome packed with play-and-display possibilities.\nPlaysets combine for more fun – The Minecraft Armory can be played with independently or integrated with other LEGO Minecraft toy sets, particularly The Nether Portal Ambush (21295), sold separately.\nMinecraft made real – LEGO Minecraft sets give kids a different way to enjoy the popular video game, with mobs, scenes and features brought to life with the hands-on creativity of LEGO bricks.",
                _productId20,
                9.99m,
                "12d6e716-1ca1-427e-9dae-4f1e6930c0e6_TG_479,480.jpg",
                10
            )
        ];
    }

    private IEnumerable<Customer> GetCustomers()
    {
        return [
            new Customer(
                _customerId1,
                _identityId1,
                "Francisco",
                "Nuñez",
                "francisco@nunez.ninja"
            ),
            new Customer(
                _customerId2,
                _identityId2,
                "Galilea",
                "Genesis",
                "galilea@nunez.ninja"
            ),
            new Customer(
                _customerId3,
                _identityId3,
                "Maria",
                "Gonzalez",
                "maria@nunez.ninja"
            )
        ];
    }

    private IEnumerable<CustomerShippingAddress> GetCustomerShippingAddresses()
    {
        return [
            new CustomerShippingAddress(
                _customerShippingAddressId1,
                _customerId1,
                true,
                "Francisco",
                "Nuñez",
                "Av. Santiago #15",
                "Tijuana",
                "Baja California",
                "Mexico",
                "22005",
                "52",
                "6641568435",
                null
            ),
            new CustomerShippingAddress(
                _customerShippingAddressId2,
                _customerId2,
                true,
                "Galilea",
                "Genesis",
                "Matamoros #8856",
                "Tijuana",
                "Baja California",
                "Mexico",
                "22041",
                "52",
                "6645635251",
                null
            ),
            new CustomerShippingAddress(
                _customerShippingAddressId3,
                _customerId3,
                true,
                "Maria",
                "Gonzalez",
                "Portillo Marquez #300",
                "Tijuana",
                "Baja California",
                "Mexico",
                "22000",
                "52",
                "7441026532",
                "201"
            )
        ];
    }
}