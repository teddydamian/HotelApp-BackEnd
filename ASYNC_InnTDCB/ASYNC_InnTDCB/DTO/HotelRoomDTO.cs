using System;
namespace ASYNC_InnTDCB.DTO
{
    public class HotelRoomDTO
    {
     
        public int RoomNumber { get; set; }
        public decimal Rate { get; set; }
        public bool PetFriendly { get; set; }
        public RoomDTO Room { get; set; }
        
    }
}
