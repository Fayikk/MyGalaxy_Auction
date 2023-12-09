using AutoMapper;
using MyGalaxy_Auction_Business.Dtos;
using MyGalaxy_Auction_Data_Access.Domain;
using MyGalaxy_Auction_Data_Access.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGalaxy_Auction_Business.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateVehicleDTO, Vehicle>().ReverseMap();
            CreateMap<UpdateVehicleDTO, Vehicle>().ReverseMap();
            CreateMap<CreateBidDTO, Bid>().ReverseMap();
            CreateMap<UpdateBidDTO, Bid>().ReverseMap();    
            CreateMap<CreatePaymentHistoryDTO, PaymentHistory>().ReverseMap();

        }
    }
}
