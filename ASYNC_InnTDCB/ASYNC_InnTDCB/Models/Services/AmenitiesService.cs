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

            //Amenities amenities = new Amenities();
            //AmenitiesDTO amenitiesdto = new AmenitiesDTO();

            //amenities = _context.Amenities.Find(amenitiesID);
            //amenitiesdto.Name = amenities.Name;
            //amenitiesdto.ID = amenities.ID;


            //var roomAmenities = await _context.RoomAmenities.Where(x => x.AmenitiesID == amenitiesID)
            //    .Include(x => x.RoomID)
            //    .ToListAsync();

            //List<AmenitiesDTO> room = new List<AmenitiesDTO>();

            //foreach (var ra in roomAmenities)
            //{
            //    AmenitiesDTO amy = new AmenitiesDTO();
            //    amy.ID = ra.RoomID;
            //    amy.Name = ra.Amenities.Name;
            //    RoomDTO rdto = new RoomDTO
            //    {


            //        Name = hr.Room.Name
            //    };
            //    room.Add(rm);

            //}
            //hoteldto.Rooms = room;
            //return hoteldto;
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
