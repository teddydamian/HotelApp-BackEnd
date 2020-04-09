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
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        private readonly IRoomManager _room;

        public RoomController(IRoomManager room)
        {
            _room = room;
        }

        // GET: Room
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Room>>> GetRooms()
        {
            return await _room.GetAllRooms();
        }

        // GET: Room/Details/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Room>> GetRoom(int id)
        {
            var room = await _room.GetRoomByID(id);

            if (room == null)
            {
                return NotFound();
            }

            return room;
        }

        // GET: Room/Details/5
        [HttpGet("{amenitiesId}, {roomId}")]
        public async Task<ActionResult<IEnumerable<Amenities>>> GetAllRoomAmenities(int roomId)
        {
            return await _room.GetAllRoomAmenities(roomId);
        }

        // PUT: api/Room/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRoom(int id, Room room)
        {
            if (id != room.ID)
            {
                return BadRequest();
            }

            await _room.UpdateRoom(id, room);

            return NoContent();
        }

        // POST: api/Room
        [HttpPost]
        public async Task<ActionResult<Room>> PostRoom(Room room)
        {
            var result = await _room.CreateRoom(room);

            return CreatedAtAction("GetRoom", new { id = result.ID }, result);
        }

        // DELETE: api/Rooms/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Room>> DeleteRoom(int id)
        {
            await _room.RemoveRoom(id);

            return NoContent();
        }
    }
}
