using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASYNC_InnTDCB.DTO;

namespace ASYNC_InnTDCB.Models.Interfaces
{
    public interface IHotelManager
    {
        Task<Hotel> CreateHotel(Hotel hotel);
        Task UpdateHotel(int hotelID, Hotel hotel);
        Task<List<Hotel>> GetAllHotels();

        //changed hotel to hotelDTO
        Task<HotelDTO> GetHotelByID(int hotelID);
        Task RemoveHotel(int hotelID);

        //TODO She has this:
        //but if we add this, we have to change hotel services cos it will be required to be implemented
        //Task<List<HotelRoom>> GetHotelRooms(int hotelID);

    }
}
