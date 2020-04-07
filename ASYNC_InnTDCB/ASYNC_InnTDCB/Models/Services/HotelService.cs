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

        /// <summary>
        /// Connecting DB to CRUD
        /// </summary>
        /// <param name="context"></param>
        public HotelService(ASYNCinnDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create a Hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        public async Task<Hotel> CreateHotel(Hotel hotel)
        {
            _context.Hotels.Add(hotel);

            await _context.SaveChangesAsync();
            return hotel;
        }

        /// <summary>
        /// Get all hotels
        /// </summary>
        /// <returns></returns>
        public async Task<List<Hotel>> GetAllHotels()
        {
            return await _context.Hotels.ToListAsync();
        }

        /// <summary>
        /// Get a hotel by ID
        /// </summary>
        /// <param name="hotelID"></param>
        /// <returns></returns>
        public async Task<Hotel> GetHotelByID(int hotelID)
        {
            Hotel hotel = await _context.Hotels.FindAsync(hotelID);
            return hotel;
        }

        /// <summary>
        /// Delete a hotel
        /// </summary>
        /// <param name="hotelID"></param>
        /// <returns></returns>
        public async Task RemoveHotel(int hotelID)
        {
            Hotel hotel = await GetHotelByID(hotelID);
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();

        }

        /// <summary>
        /// Update a hotel
        /// </summary>
        /// <param name="hotelID"></param>
        /// <param name="hotel"></param>
        /// <returns></returns>
        public async Task UpdateHotel(int hotelID, Hotel hotel)
        {
            _context.Entry(hotel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
