using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASYNC_InnTDCB.Models.Interfaces
{
    public interface IRoomManager
    {

        Task<Room> CreateRoom(Room room);
        Task UpdateRoom(int roomID, Room room);
        Task<List<Room>> GetAllRooms();
        Task<Room> GetRoomByID(int roomID);
        Task RemoveRoom(int roomID);
        Task<List<RoomAmenities>> GetAllRoomAmenities(int amenitiesId, int roomId );
    }
}
