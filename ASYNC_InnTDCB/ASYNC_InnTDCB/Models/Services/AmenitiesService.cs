using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASYNC_InnTDCB.DTO;
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
            public async Task<List<AmenitiesDTO>> GetAllAmenities()
            {
                var allAmenities = await _context.Amenities.ToListAsync();
                List<AmenitiesDTO> listAmenities = new List<AmenitiesDTO>();

                foreach (var amenity in allAmenities)
                {
                    listAmenities.Add(new AmenitiesDTO
                    {
                        ID = amenity.ID,
                        Name = amenity.Name
                    });

                }
                return listAmenities;
        }

            /// <summary>
            /// Get specific amenities by ID
            /// </summary>
            /// <param name="amenitiesID"></param>
            /// <returns></returns>
            public async Task<AmenitiesDTO> GetAmenitieByID(int amenitiesID)
            {
                Amenities amenities = await _context.Amenities.FindAsync(amenitiesID);
                AmenitiesDTO amenitiesDTO = new AmenitiesDTO
                {
                    ID = amenities.ID,
                    Name = amenities.Name,

                };
                return amenitiesDTO;

            }

            /// <summary>
            /// Delete amenities by ID
            /// </summary>
            /// <param name="amenitiesID"></param>
            /// <returns></returns>
            public async Task RemoveAmenities(int amenitiesID)
            {
                AmenitiesDTO amenitiesDTO = await GetAmenitieByID(amenitiesID);
                Amenities amenities = new Amenities()
                {
                    ID = amenitiesDTO.ID,
                    Name = amenitiesDTO.Name
                };
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
