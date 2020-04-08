using System;
using System.Collections.Generic;

namespace ASYNC_InnTDCB.DTO
{
    public class RoomDTO
    {
        public string Name { get; set; }
        public string Layout { get; set; }
        public List<AmenitiesDTO> Amenities { get; set; }
    }
}
