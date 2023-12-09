using MyGalaxy_Auction_Data_Access.Domain;
using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Dtos
{
    public class CreateBidDTO
    {
        public decimal BidAmount { get; set; }
        public string? UserId { get; set; }
        public int VehicleId { get; set; }
    }
}
