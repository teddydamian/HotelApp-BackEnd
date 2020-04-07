using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ASYNC_InnTDCB.Models.Interfaces
{
    public interface IAmenitiesManager
    {
        Task<Amenities> CreateAmenities(Amenities amenities);
        Task UpdateAmenities(int amenitiesID, Amenities amenities);
        Task<List<Amenities>> GetAllAmenities();
        Task<Amenities> GetAmenitieByID(int amenitiesID);
        Task RemoveAmenities(int amenitiesID);
    }
}
