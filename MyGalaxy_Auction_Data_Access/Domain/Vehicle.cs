using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Data_Access.Domain
{
    public class Vehicle
    {
        [Key]
        public int VehicleId { get; set; }
        public string  BrandAndModel { get; set; }
        public int ManufacturingYear { get; set; }
        public string Color { get; set; }
        public decimal EngineCapacity { get; set; }
        public decimal Price { get; set; }

        public int Millage { get; set; }
        public string PlateNumber { get; set; }

        public double AuctionPrice { get; set; }
        public string AdditionalInformation { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsActive { get; set; }
        public string Image { get; set; }
        public string SellerId { get; set; }
        [JsonIgnore]
        [ForeignKey("SellerId")]
        public ApplicationUser Seller { get; set; }

        public virtual List<Bid> Bids { get; set; } 

        public  PaymentHistory? Payment { get; set; }


    }
}
