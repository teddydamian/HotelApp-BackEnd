using System;
using System.Collections.Generic;

namespace ASYNC_InnTDCB.DTO
{
    public class HotelDTO
    {
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PhoneNumber { get; set; }

        public List<HotelRoomDTO> Rooms { get; set; }
    }
}
