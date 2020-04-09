using System;
using System.Collections.Generic;

namespace ASYNC_InnTDCB.DTO
{
    public class RoomDTO
    {
        /// <summary>
        /// Displaying selected properties to display
        /// </summary>
        public int ID { get; set; }
        public string Name { get; set; }
        public string Layout { get; set; }
        public List<AmenitiesDTO> Amenities { get; set; }
    }
}
