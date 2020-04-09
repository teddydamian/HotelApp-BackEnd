using System;
namespace ASYNC_InnTDCB.DTO
{
    public class HotelRoomDTO
    {
        /// <summary>
        /// Displaying selected properties to display
        /// </summary>
        public int HotelID { get; set; }
        public int RoomNumber { get; set; }
        public decimal Rate { get; set; }
        public bool PetFriendly { get; set; }
        public RoomDTO Room { get; set; }
        public int RoomID { get; set; }


    }
}
