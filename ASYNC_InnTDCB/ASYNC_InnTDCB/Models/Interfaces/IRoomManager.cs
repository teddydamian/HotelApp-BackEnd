using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASYNC_InnTDCB.Models.Interfaces
{
    public interface IRoomManager
    {
        // CRUD operations for Rooms
        Task<Room> CreateRoom(Room room);
        Task UpdateRoom(int roomID, Room room);
        Task<List<Room>> GetAllRooms();
        Task<Room> GetRoomByID(int roomID);
        Task RemoveRoom(int roomID);

        // Get Rooms with amenities
        Task<List<Amenities>> GetAllRoomAmenities(int roomId );
    }
}
