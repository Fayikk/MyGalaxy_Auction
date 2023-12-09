using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Data_Access.Domain
{
    public class PaymentHistory
    {
        [Key]
        public int PaymentId { get; set; }
        public bool IsActive { get; set; }
        public DateTime PayDate { get; set; }
        public string ClientSecret { get; set; }
        public string StripePaymentIntentId { get; set; }   
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public int VehicleId { get; set; }
        [JsonIgnore]
        public Vehicle Vehicle { get; set; }
    }
}
