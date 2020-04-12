using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ASYNC_InnTDCB.Models;
using ASYNC_InnTDCB.Properties.Data;
using ASYNC_InnTDCB.Models.Interfaces;

namespace ASYNC_InnTDCB.Controllers
{
    [Route("api/Hotels/Rooms")]
    [ApiController]
    public class HotelRoomController : ControllerBase
    {
        private readonly IHotelRoomManager _context;

        public HotelRoomController(IHotelRoomManager context)
        {
            _context = context;
        }

        // GET: api/HotelRooms
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HotelRoom>>> GetHotelRooms(int hotelID)
        {
            return await _context.GetAllHotelRooms(hotelID);
        }

        // GET: api/HotelRooms/5
        [HttpGet, Route("{hotelID}/{roomNumber}")]
        public async Task<ActionResult<HotelRoom>> GetHotelRoomByRoomNumber(int hotelID, int roomNumber)
        {
            var hotelRoom = await _context.GetHotelRoomByRoomNumber(hotelID, roomNumber);

            if (hotelRoom == null)
            {
                return NotFound();
            }

            return hotelRoom;
        }

        // PUT: api/HotelRooms/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutHotelRoom(int id, HotelRoom hotelRoom)
        //{
        //    if (id != hotelRoom.HotelID)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(hotelRoom).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!HotelRoomExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        // POST: api/HotelRooms
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        //[HttpPost]
        //public async Task<ActionResult<HotelRoom>> PostHotelRoom(HotelRoom hotelRoom)
        //{
        //    _context.HotelRooms.Add(hotelRoom);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (HotelRoomExists(hotelRoom.HotelID))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetHotelRoom", new { id = hotelRoom.HotelID }, hotelRoom);
        //}

        //// DELETE: api/HotelRooms/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<HotelRoom>> DeleteHotelRoom(int id)
        //{
        //    var hotelRoom = await _context.HotelRooms.FindAsync(id);
        //    if (hotelRoom == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.HotelRooms.Remove(hotelRoom);
        //    await _context.SaveChangesAsync();

        //    return hotelRoom;
        //}

        //private bool HotelRoomExists(int id)
        //{
        //    return _context.HotelRooms.Any(e => e.HotelID == id);
        //}

    }
}
