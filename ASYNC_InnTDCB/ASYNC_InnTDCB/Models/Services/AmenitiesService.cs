using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ASYNC_InnTDCB.Models.Interfaces;
using ASYNC_InnTDCB.Properties.Data;
using Microsoft.EntityFrameworkCore;

namespace ASYNC_InnTDCB.Models.Services
{
 
        public class AmenitiesService : IAmenitiesManager
    {
            private ASYNCinnDbContext _context;

            /// <summary>
            /// Connecting DB to CRUD
            /// </summary>
            /// <param name="context"></param>
            public AmenitiesService(ASYNCinnDbContext context)
            {
                _context = context;
            }

            /// <summary>
            /// Create a new Amenities
            /// </summary>
            /// <param name="amenities"></param>
            /// <returns></returns>
            public async Task<Amenities> CreateAmenities(Amenities amenities)
            {
                _context.Amenities.Add(amenities);

                await _context.SaveChangesAsync();
                return amenities;
            }

            /// <summary>
            /// Get all Amenities
            /// </summary>
            /// <returns></returns>
            public async Task<List<Amenities>> GetAllAmenities()
            {
                return await _context.Amenities.ToListAsync();
            }

            /// <summary>
            /// Get specific amenities by ID
            /// </summary>
            /// <param name="amenitiesID"></param>
            /// <returns></returns>
            public async Task<Amenities> GetAmenitieByID(int amenitiesID)
            {
            Amenities amenities = await _context.Amenities.FindAsync(amenitiesID);
                return amenities;
            }

            /// <summary>
            /// Delete amenities by ID
            /// </summary>
            /// <param name="amenitiesID"></param>
            /// <returns></returns>
            public async Task RemoveAmenities(int amenitiesID)
            {
            Amenities amenities = await GetAmenitieByID(amenitiesID);
                _context.Amenities.Remove(amenities);
                await _context.SaveChangesAsync();

            }

            /// <summary>
            /// Update an amenity by ID
            /// </summary>
            /// <param name="amenitiesID"></param>
            /// <param name="amenities"></param>
            /// <returns></returns>
            public async Task UpdateAmenities(int amenitiesID, Amenities amenities)
            {
                _context.Entry(amenities).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }
    
}
