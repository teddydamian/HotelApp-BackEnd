using System;
using System.Collections.Generic;

namespace ASYNC_InnTDCB.Models
{
    public class Hotel
    {
        /// <summary>
        /// ID is Primary Key.
        /// </summary>
        public int ID { get; set; }
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Phone { get; set; }

        /// <summary>
        /// Navigation
        /// </summary>
        public List<HotelRoom> HotelRooms { get; set; }
    }
}
