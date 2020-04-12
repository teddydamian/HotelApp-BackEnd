using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASYNC_InnTDCB.DTO;
using ASYNC_InnTDCB.Models.Interfaces;
using ASYNC_InnTDCB.Properties.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASYNC_InnTDCB.Models.Services
{
    public class RoomService : IRoomManager
    {

        private ASYNCinnDbContext _context;
        private IAmenitiesManager _amenities;

        /// <summary>
        /// Connecting DB to CRUD
        /// </summary>
        /// <param name="context"></param>
        public RoomService(ASYNCinnDbContext context, IAmenitiesManager amenities)
        {
            _context = context;
            _amenities = amenities;
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
        public async Task<List<RoomDTO>> GetAllRooms()
        {
            var allRooms = await _context.Rooms.ToListAsync();
            List<RoomDTO> allRoomDTO = new List<RoomDTO>();

            foreach (var room in allRooms)
            {
                List<AmenitiesDTO> roomAmenityDTO = await GetAmenities(room.ID);
                var roomDTO = new RoomDTO()
                {
                    ID = room.ID,
                    Name = room.Name,
                    Layout = room.Layout.ToString(),
                    Amenities = roomAmenityDTO
                };
                allRoomDTO.Add(roomDTO);

            }
            return allRoomDTO;

        }

        /// <summary>
        /// Get a room by ID
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public async Task<RoomDTO> GetRoomByID(int roomID)
        {
            var room = await _context.Rooms.FindAsync(roomID);
            List<AmenitiesDTO> roomAmenityDTO = new List<AmenitiesDTO>();
            foreach (var amenity in room.RoomAmenities)
            {
                var getAmenities = new AmenitiesDTO
                {
                    ID = amenity.AmenitiesID,
                    Name = _context.Amenities.Find(amenity.AmenitiesID).Name,
                };
                roomAmenityDTO.Add(getAmenities);
            }

            RoomDTO roomDto = new RoomDTO
            {
                ID = room.ID,
                Name = room.Name,
                Layout = room.Layout.ToString(),
                Amenities = roomAmenityDTO
            };
            return roomDto;
        }

        /// <summary>
        /// Delete a Room
        /// </summary>
        /// <param name="roomID"></param>
        /// <returns></returns>
        public async Task RemoveRoom(int roomID)
        {
            Room room = await _context.Rooms.FindAsync(roomID);

            _context.Rooms.Remove(room);
            await _context.SaveChangesAsync();

        }


        public async Task<List<AmenitiesDTO>> GetAmenities(int roomId)
        {
            var roomAmenities = await _context.RoomAmenities.Where(x => x.RoomID == roomId).ToListAsync();

            List<AmenitiesDTO> amenitiesResults = new List<AmenitiesDTO>();

            foreach (var item in roomAmenities)
            {
                var items = await _amenities.GetAmenitieByID(item.AmenitiesID);
                amenitiesResults.Add(items);
            }
            return amenitiesResults;
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
        public async Task<List<AmenitiesDTO>> GetAllRoomAmenities(int roomId)
        {
            //var roomAmenities = await _context.RoomAmenities.Where(roomAmenities => roomAmenities.RoomID == roomId)
            //                                                //.Include(RoomAmenities => RoomAmenities.Amenities)
            //                                                //.Select(amenity => amenity.Amenities)
            //                                                .ToListAsync();
            //return roomAmenities;
            return null;
        }

    }
}
