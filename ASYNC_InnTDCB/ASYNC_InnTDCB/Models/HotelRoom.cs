using System;
namespace ASYNC_InnTDCB.Models
{
    public class HotelRoom
    {
        /// <summary>
        /// HotelID : Composite Key and Foreign Key
        /// RoomNumber : Composite Key
        /// RoomID : Foreign Key
        /// </summary>
        public int HotelID { get; set; }
        public int RoomNumber { get; set; }
        public int RoomID { get; set; }
        public decimal Rate { get; set; }
        public bool PetFriendly { get; set; }

        // Navigation
        public Hotel Hotel { get; set; }
        public Room Room { get; set; }
    }
}
