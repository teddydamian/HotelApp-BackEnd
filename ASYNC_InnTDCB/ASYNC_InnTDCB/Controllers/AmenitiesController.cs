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
    public class AmenitiesController : Controller
    {
        private readonly IAmenitiesManager _amenities;

        public AmenitiesController(IAmenitiesManager amenities)
        {
            _amenities = amenities;
        }

        // GET: api/Amenities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Amenities>>> GetAmenities()
        {
            return await _amenities.GetAllAmenities();
        }

        // GET: api/Amenities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Amenities>> GetAmenitie(int id)
        {
            var amenities = await _amenities.GetAmenitieByID(id);

            if (amenities == null)
            {
                return NotFound();
            }

            return amenities;
        }

        // PUT: api/Amenities/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAmenities(int id, Amenities amenities)
        {
            if (id != amenities.ID)
            {
                return BadRequest();
            }

            await _amenities.UpdateAmenities(id, amenities);

            return NoContent();
        }

        // POST: api/Amenities
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Amenities>> PostAmenities(Amenities amenities)
        {
            var result = await _amenities.CreateAmenities(amenities);

            return CreatedAtAction("GetAmenities", new { id = result.ID }, result);
        }

        // DELETE: api/Amenities/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Amenities>> DeleteAmenities(int id)
        {
            await _amenities.RemoveAmenities(id);

            return NoContent();
        }
    }
}
