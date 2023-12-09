using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Abstraction
{
    public interface IPaymentHistoryService
    {
        Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDTO model);
        Task<ApiResponse> CheckIsStatusForAuction(string userId,int vehicleId);
    }
}
