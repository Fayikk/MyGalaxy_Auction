using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public class VehicleService : IVehicleService
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private ApiResponse _response;
        public VehicleService(ApplicationDbContext context,ApiResponse response,IMapper mapper)
        {
            _response = response;
            _context = context;
            _mapper = mapper;
        }

        public async Task<ApiResponse> ChangeVehicleStatus(int vehicleId)
        {
            var result = await _context.Vehicles.FindAsync(vehicleId);
            if (result == null)
            {
                _response.isSuccess = false;
                return _response;
            }
            result.IsActive = false;
            _response.isSuccess =true;
            await _context.SaveChangesAsync();  
            return _response;
        }

        public async Task<ApiResponse> CreateVehicle(CreateVehicleDTO model)
        {
            if (model != null)
            {
                var objDTO = _mapper.Map<Vehicle>(model);
                if (objDTO!=null)
                {
                     _context.Vehicles.Add(objDTO);
                    if (await _context.SaveChangesAsync() > 0)
                    {
                        _response.isSuccess = true;
                        _response.Result = model;
                        _response.StatusCode = System.Net.HttpStatusCode.Created;
                        return _response;   
                    }
                }
            }
            _response.isSuccess = false;
            _response.ErrorMessages.Add("Ooops! Something went wrong");
            return _response;
        }

        public async Task<ApiResponse> DeleteVehicle(int vehicleId)
        {
            var result = await _context.Vehicles.FindAsync(vehicleId);
            if (result != null)
            {
                _context.Vehicles.Remove(result);
                if (await _context.SaveChangesAsync() > 0)
                {
                    _response.isSuccess = true;
                    return _response;
                }
            }
            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> GetVehicleById(int vehicleId)
        {
            var result = await _context.Vehicles.Include(x=>x.Seller).Include(x=>x.Bids).FirstOrDefaultAsync(x => x.VehicleId == vehicleId);
            if (result != null)
            {
                _response.Result = result;
                _response.isSuccess = true;
                return _response;
            }
            _response.isSuccess= false; return _response;
        }

        public async Task<ApiResponse> GetVehicles()
        {
            var vehicle = await _context.Vehicles.Include(x=>x.Seller).ToListAsync();
            if (vehicle!=null)
            {
                _response.isSuccess = true;
                _response.Result = vehicle;
                return _response;
            }
            _response.isSuccess = false;
            return _response;
        }

        public async Task<ApiResponse> UpdateVehicleResponse(int vehicleId, UpdateVehicleDTO model)
        {
            var result = await _context.Vehicles.FindAsync(vehicleId);
            if (result!=null)
            {
                Vehicle objDTO = _mapper.Map(model, result);
                if (await _context.SaveChangesAsync()>0)
                {
                    _response.isSuccess = true;
                    _response.Result = objDTO;
                    return _response;
                }
            }
            _response.isSuccess = false;
            return _response;
        }
    }
}
