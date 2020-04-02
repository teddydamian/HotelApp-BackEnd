using System;
using System.Collections.Generic;

namespace ASYNC_InnTDCB.Models
{
    public class Amenities
    {
        /// <summary>
        /// ID is Primary Key.
        /// </summary>
        public int ID { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Navigation
        /// </summary>
        public List<RoomAmenities> RoomAmenities { get; set; }
    }
}
