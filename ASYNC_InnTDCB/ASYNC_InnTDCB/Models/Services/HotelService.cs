using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASYNC_InnTDCB.DTO;
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
            //NEWCODE
            return _context.Hotels.Include(x => x.HotelRooms)
                                           .ThenInclude(x => x.Room)
                                           .ThenInclude(x => x.RoomAmenities)
                                           .ThenInclude(x => x.Amenities)
                                           .ToList();

            //OLDCODE
            //return await _context.Hotels.ToListAsync();
        }

        /// <summary>
        /// Get a hotel by ID
        /// </summary>
        /// <param name="hotelID"></param>
        /// <returns></returns>
        public async Task<HotelDTO> GetHotelByID(int hotelID)
        {
            //OLDCODE : return type is switched to HotelDTO from Hotel
            //Hotel hotel = await _context.Hotels.FindAsync(hotelID);
            //return hotel;

            //NEWCODE
            Hotel hotel = new Hotel();
            HotelDTO hoteldto = new HotelDTO();

            hotel = _context.Hotels.Find(hotelID);
            hoteldto.Name = hotel.Name;
            hoteldto.PhoneNumber = hotel.Phone;
            hoteldto.City = hotel.City;

            var hotelRooms = await _context.HotelRooms.Where(x => x.HotelID == hotelID)
                .Include(x => x.Room)
                .ThenInclude(x => x.RoomAmenities)
                .ThenInclude(x => x.Amenities)
                .ToListAsync();

            List<HotelRoomDTO> room = new List<HotelRoomDTO>();

            foreach(var hr in hotelRooms)
            {
                HotelRoomDTO rm = new HotelRoomDTO();
                rm.Rate = hr.Rate;
                rm.RoomNumber = hr.RoomNumber;
                RoomDTO rdto = new RoomDTO
                {
                    Layout = hr.Room.Layout.ToString(),
                    Name = hr.Room.Name
                };
                room.Add(rm);
                
            }
            hoteldto.Rooms = room;
            return hoteldto;
        }

        /// <summary>
        /// Delete a hotel
        /// </summary>
        /// <param name="hotelID"></param>
        /// <returns></returns>
        /// TODO She commented RemoveHotel because it is using hotel not hotelDTO.
        /// So I think we gotta Query it to delete the specified data?
        public async Task RemoveHotel(int hotelID)
        {
            //Hotel hotel = await GetHotelByID(hotelID);
            //_context.Hotels.Remove(hotel);
            //await _context.SaveChangesAsync();

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
