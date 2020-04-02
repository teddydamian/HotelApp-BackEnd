using System;
using System.Collections.Generic;

namespace ASYNC_InnTDCB.Models
{
    public class Room
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int ID { get; set; }

        public string Name { get; set; }
        public Layout Layout { get; set; }
        public List<RoomAmenities> RoomAmenities { get; set; }
        public List<HotelRoom> HotelRooms { get; set; }

    }

    /// <summary>
    /// Drop down box to choose room layout
    /// </summary>
    public enum Layout
    {
        Studio = 0,
        OneBedroom,
        TwoBedroom
    };
}
