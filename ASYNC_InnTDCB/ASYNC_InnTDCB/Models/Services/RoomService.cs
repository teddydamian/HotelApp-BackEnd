using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASYNC_InnTDCB.Models.Interfaces;
using ASYNC_InnTDCB.Properties.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASYNC_InnTDCB.Models.Services
{
    public class RoomService : IRoomManager
    {
        private ASYNCinnDbContext _context;

        /// <summary>
        /// Connecting DB to CRUD
        /// </summary>
        /// <param name="context"></param>
        public RoomService(ASYNCinnDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Create a room
        /// </summary>
        /// <param name="room"></param>
        /// <returns></returns>
        public async Task<Room> CreateRoom(Room room)
        {
            _context.Rooms.Add(room);

            await _context.SaveChangesAsync();
            return room;
        }

        /// <summary>
        /// Get all rooms
        /// </summary>
        /// <returns></returns>
        public async Task<List<Room>> GetAllRooms()
        {
            return await _context.Rooms.ToListAsync();
        }

        /// <summary>
        /// Get a room by ID
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public async Task<Room> GetRoomByID(int roomID)
        {
            Room room = await _context.Rooms.FindAsync(roomID);
            return room;
        }

        /// <summary>
        /// Delete a Room
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public async Task RemoveRoom(int roomID)
        {
            Room room = await GetRoomByID(roomID);
            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

        }

        /// <summary>
        /// Update the room
        /// </summary>
        /// <param name="roomID"></param>
        /// <param name="room"></param>
        /// <returns></returns>
        public async Task UpdateRoom(int roomID, Room room)
        {
            _context.Entry(room).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Access to RoomAmenities from Hotel
        /// </summary>
        /// <param name="amenitiesId"></param>
        /// <param name="roomId"></param>
        /// <returns></returns>
        public async Task<List<Amenities>> GetAllRoomAmenities(int roomId)
        {
            var roomAmenities = await _context.RoomAmenities.Where(roomAmenities => roomAmenities.RoomID == roomId)
                                                            .Include(RoomAmenities => RoomAmenities.Amenities)
                                                            .Select(amenity => amenity.Amenities)
                                                            .ToListAsync();
            return roomAmenities;
        }
    }
}
