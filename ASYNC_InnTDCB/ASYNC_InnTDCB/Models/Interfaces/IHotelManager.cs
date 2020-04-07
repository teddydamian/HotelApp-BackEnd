using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASYNC_InnTDCB.Models.Interfaces
{
    public interface IHotelManager
    {
        Task<Hotel> CreateHotel(Hotel hotel);
        Task UpdateHotel(int hotelID, Hotel hotel);
        Task<List<Hotel>> GetAllHotels();
        Task<Hotel> GetHotelByID(int hotelID);
        Task RemoveHotel(int hotelID);

    }
}
