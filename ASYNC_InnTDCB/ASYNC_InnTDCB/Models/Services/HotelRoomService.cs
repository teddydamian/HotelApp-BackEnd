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
    public class HotelRoomService : IHotelRoomManager
    {


        private readonly ASYNCinnDbContext _context;

        public HotelRoomService(ASYNCinnDbContext context)
        {
            _context = context;
        }

        public async Task<HotelRoom> CreateHotelRoom(HotelRoom hotelroom)
        {
            _context.HotelRooms.Add(hotelroom);            await _context.SaveChangesAsync();            return hotelroom;
        }

        public Task DeleteHotelRoom(int hotelID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<HotelRoom>> GetAllHotelRooms(int hotelID)
        {
            //return _context.HotelRooms.Include(x => x.Hotel)
            //                          .ThenInclude(x => x.HotelRooms)
            //                          .ThenInclude(x => x.Room)
            //                          .ThenInclude(x => x.RoomAmenities)
            //                          .ThenInclude(x => x.Amenities)
            //                          .ToList();

            List<HotelRoom> hotelRooms = await _context.HotelRooms.Where(x => x.HotelID == hotelID).ToListAsync();            return hotelRooms;
        }

        public async Task<HotelRoom> GetHotelRoomByRoomNumber(int hotelID, int roomNumber)
        {
            HotelRoom hotelRoom = await _context.HotelRooms.FindAsync(hotelID, roomNumber);            return hotelRoom;
        }

        public Task UpdateHotelRoom(int hotelID, HotelRoom hotelroom)
        {
            throw new NotImplementedException();
        }
    }
}
