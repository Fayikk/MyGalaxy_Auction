using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MyGalaxy_Auction_Business.Abstraction;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Core.Models;
using MyGalaxy_Auction_Data_Access.Context;
using MyGalaxy_Auction_Data_Access.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Concrete
{
    public class PaymentHistoryService : IPaymentHistoryService
    {
        private ApiResponse _response;
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        public PaymentHistoryService(ApiResponse response,ApplicationDbContext context,IMapper mapper)
        {
            _response = response;
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResponse> CheckIsStatusForAuction(string userId, int vehicleId)
        {
            var response = await _context.PaymentHistories.Where(x => x.UserId == userId && x.VehicleId == vehicleId && x.IsActive == true).FirstOrDefaultAsync();
            if (response != null)
            {
                _response.isSuccess = true;
                _response.Result = response;
                return _response;
            }
            _response.isSuccess = false;
            return _response;   
        }

        public async Task<ApiResponse> CreatePaymentHistory(CreatePaymentHistoryDTO model)
        {
            if (model == null)
            {
                _response.isSuccess = false;
                _response.ErrorMessages.Add("Model is not include some fields");
                return _response;
            }
            else
            {
                var objDTO = _mapper.Map<PaymentHistory>(model);
                objDTO.PayDate = DateTime.Now;
                objDTO.IsActive = true;
                 _context.PaymentHistories.Add(objDTO);
                if (await _context.SaveChangesAsync()>0)
                {
                    _response.isSuccess = true;
                    _response.Result = model;
                    return _response;   
                
                }
                _response.isSuccess = false;
                _response.ErrorMessages.Add("Ooops! something went wrong!");
                return _response;

            }


        }
    }
}
