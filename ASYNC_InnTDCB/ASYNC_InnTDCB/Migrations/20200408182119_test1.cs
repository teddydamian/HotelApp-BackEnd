using Microsoft.EntityFrameworkCore.Migrations;

namespace ASYNC_InnTDCB.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "HotelID", "RoomNumber" },
                keyValues: new object[] { 1, 101 });

            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "HotelID", "RoomNumber" },
                keyValues: new object[] { 2, 201 });

            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "HotelID", "RoomNumber" },
                keyValues: new object[] { 3, 301 });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "HotelID", "RoomNumber", "PetFriendly", "Rate", "RoomID" },
                values: new object[] { 4, 401, false, 400m, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "HotelID", "RoomNumber" },
                keyValues: new object[] { 4, 401 });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "HotelID", "RoomNumber", "PetFriendly", "Rate", "RoomID" },
                values: new object[] { 1, 101, true, 100m, 1 });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "HotelID", "RoomNumber", "PetFriendly", "Rate", "RoomID" },
                values: new object[] { 2, 201, true, 200m, 2 });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "HotelID", "RoomNumber", "PetFriendly", "Rate", "RoomID" },
                values: new object[] { 3, 301, false, 300m, 3 });
        }
    }
}
