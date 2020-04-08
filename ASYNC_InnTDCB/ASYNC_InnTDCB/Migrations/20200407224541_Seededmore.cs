using Microsoft.EntityFrameworkCore.Migrations;

namespace ASYNC_InnTDCB.Migrations
{
    public partial class Seededmore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "HotelID", "RoomNumber", "PetFriendly", "Rate", "RoomID" },
                values: new object[] { 1, 0, true, 100m, 1 });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "HotelID", "RoomNumber", "PetFriendly", "Rate", "RoomID" },
                values: new object[] { 2, 0, true, 200m, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "HotelID", "RoomNumber" },
                keyValues: new object[] { 1, 0 });

            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "HotelID", "RoomNumber" },
                keyValues: new object[] { 2, 0 });
        }
    }
}
