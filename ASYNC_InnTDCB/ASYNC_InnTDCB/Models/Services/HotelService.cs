using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASYNC_InnTDCB.Models.Interfaces;
using ASYNC_InnTDCB.Properties.Data;
using Microsoft.EntityFrameworkCore;

namespace ASYNC_InnTDCB.Models.Services
{
    public class HotelService : IHotelManager
    {
        private ASYNCinnDbContext _context;

        public HotelService(ASYNCinnDbContext context)
        {
            _context = context;
        }
        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);

            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task<List<Hotel>> GetAllHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        public async Task<Hotel> GetHotelByID(int hotelID)
        {
            Hotel hotel = await _context.Hotels.FindAsync(hotelID);
            return hotel;
        }

        public async Task RemoveHotel(int hotelID)
        {
            Hotel hotel = await GetHotelByID(hotelID);
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateHotel(int hotelID, Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
