using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASYNC_InnTDCB.DTO;

namespace ASYNC_InnTDCB.Models.Interfaces
{
    public interface IHotelRoomManager
    {
        //CRUD Operations for Create Update Delete getAll Hotels
        Task<HotelRoom> CreateHotelRoom(HotelRoom hotelroom);

        Task UpdateHotelRoom(int hotelID, HotelRoom hotelroom);
        Task<List<HotelRoom>> GetAllHotelRooms(int hotelID);
        Task<HotelRoom> GetHotelRoomByRoomNumber(int hotelID, int roomNumber);

        Task DeleteHotelRoom(int hotelID);

    }
}
