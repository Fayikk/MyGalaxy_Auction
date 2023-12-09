using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyGalaxy_Auction_Data_Access.Domain;
using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Data_Access.Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Bid> Bids { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        public DbSet<PaymentHistory> PaymentHistories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Vehicle>().HasData(

                                new Vehicle
                                {
                                    VehicleId = 1,
                                    BrandAndModel = "Toyota Camry",
                                    ManufacturingYear = 2020,
                                    Color = "Silver",
                                    EngineCapacity = 2.5m,
                                    Price = 25000.00m,
                                    Millage = 15000,
                                    PlateNumber = "34AA21",
                                    AuctionPrice = 200.0,
                                    AdditionalInformation = "Excellent condition, single owner",
                                    StartTime = DateTime.Now,
                                    EndTime = DateTime.Now.AddDays(48),
                                    IsActive = true,
                                    Image = "https://i.gaw.to/content/photos/39/21/392165_2020_Toyota_Camry.jpg",
                                    SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"
                                },
                    new Vehicle
                    {
                        VehicleId = 2,

                        BrandAndModel = "Honda Civic",
                        ManufacturingYear = 2019,
                        Color = "Blue",
                        EngineCapacity = 1.8m,
                        Price = 18000.00m,
                        Millage = 20000,
                        PlateNumber = "34AA21",
                        AuctionPrice = 200.0,
                        AdditionalInformation = "Good condition, one previous owner",
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddDays(24),
                        IsActive = false,
                        Image = "https://i.pinimg.com/originals/4f/b7/96/4fb796d99758f4889338c69efc74dbfe.jpg",
                        SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"
                    },
                    new Vehicle
                    {
                        VehicleId = 3,

                        BrandAndModel = "Ford F-150",
                        ManufacturingYear = 2018,
                        Color = "Red",
                        EngineCapacity = 5.0m,
                        Price = 28000.00m,
                        Millage = 25000,
                        PlateNumber = "34AA21",
                        AuctionPrice = 200.0,
                        AdditionalInformation = "Low mileage, well-maintained",
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddDays(72),
                        IsActive = true,
                        Image = "https://www.autopartmax.com/images/cUpload/FORD%20Truck-F150%20Raptor.jpg",
                        SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                    },
                    new Vehicle
                    {
                        VehicleId = 4,

                        BrandAndModel = "Nissan Altima",
                        ManufacturingYear = 2017,
                        Color = "Black",
                        EngineCapacity = 2.5m,
                        Price = 16000.00m,
                        Millage = 30000,
                        PlateNumber = "34AA21",
                        AuctionPrice = 200.0,
                        AdditionalInformation = "Great condition, low mileage",
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddDays(48),
                        IsActive = true,
                        Image = "https://www.jonathanmotorcars.com/imagetag/631/3/l/Used-2017-Nissan-Altima-25-SV-Premium.jpg",
                        SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                    },
                    new Vehicle
                    {
                        VehicleId = 5,

                        BrandAndModel = "Chevrolet Malibu",
                        ManufacturingYear = 2017,
                        Color = "Silver",
                        EngineCapacity = 2.4m,
                        Price = 15500.00m,
                        Millage = 28000,
                        AuctionPrice = 200.0,
                        PlateNumber = "34AA21",
                        AdditionalInformation = "Well-maintained, single owner",
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddDays(72),
                        IsActive = true,
                        Image = "https://cdn.carbuzz.com/gallery-images/2016-chevrolet-malibu-carbuzz-489817-1600.jpg",
                        SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                    },
                    new Vehicle
                    {
                        VehicleId = 6,

                        BrandAndModel = "Ferrari 488 GTB",
                        ManufacturingYear = 2022,
                        Color = "Red",
                        EngineCapacity = 3.9m,
                        Price = 300000.00m,
                        PlateNumber = "34AA21",
                        Millage = 1000,
                        AuctionPrice = 200.0,
                        AdditionalInformation = "Like new, low mileage",
                        StartTime = DateTime.Now,
                        EndTime = DateTime.Now.AddDays(48),
                        IsActive = true,
                        Image = "https://i.pinimg.com/originals/93/2e/fb/932efb625cc97155497cfabd53a57d71.jpg",
                        SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                    },
                        new Vehicle
                        {
                            VehicleId = 7,

                            BrandAndModel = "Lamborghini Huracan",
                            ManufacturingYear = 2021,
                            Color = "Yellow",
                            EngineCapacity = 5.2m,
                            PlateNumber = "34AA21",
                            Price = 280000.00m,
                            Millage = 2000,
                            AuctionPrice = 0.0,
                            AdditionalInformation = "Excellent condition, one owner",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(72),
                            IsActive = true,
                            Image = "https://w.forfun.com/fetch/03/033f1bda44fe68f0aaa4db19f84a2e54.jpeg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 8,
                            BrandAndModel = "Porsche 911",
                            ManufacturingYear = 2020,
                            Color = "White",
                            EngineCapacity = 3.0m,
                            Price = 180000.00m,
                            PlateNumber = "34AA21",
                            Millage = 5000,
                            AuctionPrice = 0.0,
                            AdditionalInformation = "Low mileage, well-maintained",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(48),
                            IsActive = true,
                            Image = "https://avatars.mds.yandex.net/get-autoru-vos/6209275/1ee5dfabd4030a68195d9ac37ebf08b2/1200x900",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 9,
                            BrandAndModel = "Aston Martin DB11",
                            ManufacturingYear = 2019,
                            Color = "Black",
                            EngineCapacity = 5.2m,
                            Price = 250000.00m,
                            Millage = 6000,
                            AuctionPrice = 0.0,
                            PlateNumber = "34AA21",
                            AdditionalInformation = "Excellent condition, low mileage",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(72),
                            IsActive = true,
                            Image = "https://images.hgmsites.net/hug/2018-aston-martin-db11_100630564_h.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 10,
                            BrandAndModel = "McLaren 720S",
                            ManufacturingYear = 2021,
                            Color = "Orange",
                            EngineCapacity = 4.0m,
                            Price = 280000.00m,
                            Millage = 4000,
                            PlateNumber = "34AA21",
                            AuctionPrice = 0.0,
                            AdditionalInformation = "Like new, low mileage",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(48),
                            IsActive = true,
                            Image = "https://www.mclarencf.com/imagetag/42/main/l/New-2020-McLaren-720S-Spider.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 11,
                            BrandAndModel = "Bugatti Chiron",
                            ManufacturingYear = 2018,
                            Color = "Blue",
                            EngineCapacity = 8.0m,
                            Price = 350000.00m,
                            Millage = 3000,
                            PlateNumber = "34AA21",
                            AuctionPrice = 0.0,
                            AdditionalInformation = "Rare, collector's item",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(72),
                            IsActive = true,
                            Image = "https://coolwallpapers.me/picsup/5650604-bugatti-chiron-wallpapers.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 12,
                            BrandAndModel = "Koenigsegg Jesko",
                            ManufacturingYear = 2022,
                            Color = "Silver",
                            EngineCapacity = 5.0m,
                            Price = 400000.00m,
                            PlateNumber = "34AA21",
                            Millage = 1500,
                            AuctionPrice = 0.0,
                            AdditionalInformation = "High-performance masterpiece",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(48),
                            IsActive = true,
                            Image = "https://wallpapercave.com/wp/wp5031567.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 13,
                            BrandAndModel = "Ferrari SF90 Stradale",
                            ManufacturingYear = 2021,
                            Color = "Red",
                            EngineCapacity = 4.0m,
                            PlateNumber = "34AA21",
                            Price = 275000.00m,
                            Millage = 2000,
                            AuctionPrice = 0.0,
                            AdditionalInformation = "Hybrid supercar, low mileage",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(72),
                            IsActive = true,
                            Image = "https://4kwallpapers.com/images/wallpapers/novitec-ferrari-sf90-stradale-2022-5k-8k-2880x1800-8481.jpeg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 14,
                            BrandAndModel = "Pagani Huayra",
                            ManufacturingYear = 2020,
                            Color = "Green",
                            EngineCapacity = 6.0m,
                            Price = 320000.00m,
                            PlateNumber = "34AA21",
                            Millage = 2500,
                            AuctionPrice = 0.0,
                            AdditionalInformation = "Exotic masterpiece, low mileage",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(48),
                            IsActive = true,
                            Image = "https://www.motorionline.com/wp-content/gallery/pagani-huayra-nc/Pagani-Huayra-NC-1.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 15,
                            BrandAndModel = "Lexus LC 500",
                            ManufacturingYear = 2019,
                            Color = "Black",
                            EngineCapacity = 5.0m,
                            Price = 60000.00m,
                            PlateNumber = "34AA21",
                            Millage = 5000,
                            AuctionPrice = 0.0,
                            AdditionalInformation = "Luxury sports coupe",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(72),
                            IsActive = true,
                            Image = "https://wallpapercave.com/wp/wp6603188.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 16,
                            BrandAndModel = "Tesla Model S",
                            ManufacturingYear = 2022,
                            Color = "Blue",
                            EngineCapacity = 0.0m,  // Elektrikli araç, motor kapasitesi yok
                            Price = 90000.00m,
                            Millage = 1500,
                            PlateNumber = "34AA21",
                            AuctionPrice = 0.0,
                            AdditionalInformation = "High-performance electric car",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(72),
                            IsActive = true,
                            Image = "https://i.pinimg.com/originals/8f/b4/3b/8fb43b750028af047cbb0308c0e46014.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 17,
                            BrandAndModel = "Audi R8",
                            ManufacturingYear = 2021,
                            Color = "Silver",
                            EngineCapacity = 5.2m,
                            Price = 120000.00m,
                            PlateNumber = "34AA21",
                            Millage = 3000,
                            AuctionPrice = 0.0,
                            AdditionalInformation = "Luxury sports car, low mileage",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(48),
                            IsActive = true,
                            Image = "https://wallpapercave.com/wp/wp8343229.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 18,
                            BrandAndModel = "Mercedes-AMG GT",
                            ManufacturingYear = 2020,
                            Color = "Black",
                            EngineCapacity = 4.0m,
                            Price = 110000.00m,
                            PlateNumber = "34AA21",
                            Millage = 4000,
                            AuctionPrice = 0.0,
                            AdditionalInformation = "High-performance luxury car",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(72),
                            IsActive = true,
                            Image = "https://images.hdqwalls.com/download/mercedes-benz-sls-amg-yellow-5k-hv-3840x2400.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 19,
                            BrandAndModel = "Nissan GT-R",
                            ManufacturingYear = 2021,
                            Color = "Blue",
                            EngineCapacity = 3.8m,
                            PlateNumber = "34AA21",
                            Price = 95000.00m,
                            Millage = 2500,
                            AuctionPrice = 0.0,
                            AdditionalInformation = "High-performance Japanese sports car",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(48),
                            IsActive = true,
                            Image = "https://i.pinimg.com/originals/e9/75/81/e97581a73660b583b1d982ef23607c24.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {

                            VehicleId = 20,
                            BrandAndModel = "Ford Mustang Shelby GT500",
                            ManufacturingYear = 2022,
                            Color = "Red",
                            EngineCapacity = 5.2m,
                            Price = 75000.00m,
                            PlateNumber = "34AA21",
                            Millage = 1500,
                            AuctionPrice = 0.0,
                            AdditionalInformation = "High-performance American muscle car",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(72),
                            IsActive = true,
                            Image = "https://www.mustangspecs.com/wp-content/uploads/2022/09/carpixel.net-2022-shelby-gt500-mustang-heritage-edition-106565-hd.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"

                        },
                        new Vehicle
                        {
                            VehicleId = 21,
                            BrandAndModel = "Porsche Cayman GT4",
                            ManufacturingYear = 2021,
                            Color = "Yellow",
                            EngineCapacity = 4.0m,
                            Price = 95000.00m,
                            Millage = 3500,
                            PlateNumber = "34AA21",
                            AuctionPrice = 0.0,
                            AdditionalInformation = "Sports car with exceptional handling",
                            StartTime = DateTime.Now,
                            EndTime = DateTime.Now.AddDays(48),
                            IsActive = true,
                            Image = "https://media.porsche.com/mediakit/718-cayman-gt4-rs/00-photos/media-drive/718-Cayman-GT4-RS-GT-silbermetallic-S-GO1306/image-thumb__47840__mk2-modal-item/porschecayman_estoril07005_high_1.jpg",
                            SellerId = "13a518ee-a2e2-4448-8166-3e7caf553a45"
                        }


                );
        }


    }
}
