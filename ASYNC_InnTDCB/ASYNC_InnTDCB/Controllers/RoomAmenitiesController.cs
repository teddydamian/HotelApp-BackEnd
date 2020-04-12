using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASYNC_InnTDCB.Models;
using ASYNC_InnTDCB.Properties.Data;

namespace ASYNC_InnTDCB.Controllers
{
    [Route("api/Room/Amenities")]
    [ApiController]
    public class RoomAmenitiesController : Controller
    {
        private readonly ASYNCinnDbContext _context;

        public RoomAmenitiesController(ASYNCinnDbContext context)
        {
            _context = context;
        }

        // GET: RoomAmenities
        public async Task<ActionResult<IEnumerable<RoomAmenities>>> GetRoomAmenities()
        {
            return await _context.RoomAmenities.ToListAsync();
        }

        // GET: RoomAmenities/5
        public async Task<ActionResult<RoomAmenities>> GetRoomAmenities(int id)
        {
            var roomAmenities = await _context.RoomAmenities.FindAsync(id);

            if (roomAmenities == null)
            {
                return NotFound();
            }

            return roomAmenities;
        }


        // PUT: api/RoomAmenities/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoomAmenities(int id, RoomAmenities roomAmenities)
        {
            if (id != roomAmenities.AmenitiesID)
            {
                return BadRequest();
            }

            _context.Entry(roomAmenities).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RoomAmenitiesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/RoomAmenities
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost, Route("{RoomID}/{AmenitiesID}")]
        public async Task<ActionResult<RoomAmenities>> PostRoomAmenities(int RoomID, int AmenitiesID)
        {
            //_context.RoomAmenities.Add(roomAmenities);
            //try
            //{
            //    await _context.SaveChangesAsync();
            //}
            //catch (DbUpdateException)
            //{
            //    if (RoomAmenitiesExists(roomAmenities.AmenitiesID))
            //    {
            //        return Conflict();
            //    }
            //    else
            //    {
            //        throw;
            //    }
            //}

            //return CreatedAtAction("GetRoomAmenities", new { id = roomAmenities.AmenitiesID }, roomAmenities);
            return null;
        }

        // DELETE: api/RoomAmenities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RoomAmenities>> DeleteRoomAmenities(int id)
        {
            var roomAmenities = await _context.RoomAmenities.FindAsync(id);
            if (roomAmenities == null)
            {
                return NotFound();
            }

            _context.RoomAmenities.Remove(roomAmenities);
            await _context.SaveChangesAsync();

            return roomAmenities;
        }

        private bool RoomAmenitiesExists(int id)
        {
            return _context.RoomAmenities.Any(e => e.AmenitiesID == id);
        }

        
    }
}
