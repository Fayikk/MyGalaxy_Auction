using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Dtos
{
    public class UpdateVehicleDTO
    {
        public string BrandAndModel { get; set; }
        public int ManufacturingYear { get; set; }
        public string Color { get; set; }
        public decimal EngineCapacity { get; set; }
        public decimal Price { get; set; }

        public int Millage { get; set; }
        public string PlateNumber { get; set; }

        public double AuctionPrice { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime StartTime { get; set; } = DateTime.UtcNow;
        public DateTime EndTime { get; set; }
        public bool IsActive { get; set; } = true;
        public string Image { get; set; }
        public string SellerId { get; set; }
        public IFormFile? File { get; set; }



    }
}
