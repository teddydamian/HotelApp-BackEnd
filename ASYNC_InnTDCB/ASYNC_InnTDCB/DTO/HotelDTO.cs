using System;
using System.Collections.Generic;

namespace ASYNC_InnTDCB.DTO
{
    public class HotelDTO
    {
        /// <summary>
        /// Displaying selected properties to display
        /// </summary>
        public int ID { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Phone { get; set; }

        /// <summary>
        /// Accessing HotelRoomDTO properties
        /// </summary>
        public List<HotelRoomDTO> Rooms { get; set; }
    }
}
