using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASYNC_InnTDCB.DTO;

namespace ASYNC_InnTDCB.Models.Interfaces
{
    public interface IRoomManager
    {
        // CRUD operations for Rooms
        Task<Room> CreateRoom(Room room);

        Task UpdateRoom(int roomID, Room room);

        Task<List<RoomDTO>> GetAllRooms();

        Task<RoomDTO> GetRoomByID(int roomID);
        Task RemoveRoom(int roomID);

        // Get Rooms with amenities
        Task<List<AmenitiesDTO>> GetAllRoomAmenities(int roomId );

        Task<List<AmenitiesDTO>> GetAmenities(int roomId);
    }
}
