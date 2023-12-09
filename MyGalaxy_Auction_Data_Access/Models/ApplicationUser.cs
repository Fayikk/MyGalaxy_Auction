using Microsoft.AspNetCore.Identity;
using MyGalaxy_Auction_Data_Access.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Data_Access.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public string? ProfilePicture { get; set; }
        public DateTime DateOfBirth { get; set; }

        public ICollection<PaymentHistory> PaymentHistories { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Bid> Bids { get; set; }

    }
}
