using System;
namespace ASYNC_InnTDCB.Models
{
    public class RoomAmenities
    {
        /// <summary>
        /// Composite Key and Foreign Key
        /// </summary>
        public int AmenitiesID { get; set; }
        public int RoomID { get; set; }

        /// <summary>
        /// Navigation
        /// </summary>
        public Room Room { get; set; }
        public Amenities Amenities { get; set; }
    }
}
