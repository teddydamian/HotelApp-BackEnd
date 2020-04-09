using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASYNC_InnTDCB.DTO;

namespace ASYNC_InnTDCB.Models.Interfaces
{
    public interface IHotelManager
    {
        //CRUD Operations for Create Update Delete getAll Hotels
        Task<Hotel> CreateHotel(Hotel hotel);
        Task UpdateHotel(int hotelID, Hotel hotel);
        Task<List<Hotel>> GetAllHotels();

        //changed hotel to hotelDTO
        Task<HotelDTO> GetHotelByID(int hotelID);
        Task RemoveHotel(int hotelID);

        
        //Task<List<HotelRoom>> GetHotelRooms(int hotelID);

    }
}
