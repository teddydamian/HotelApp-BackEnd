using Microsoft.EntityFrameworkCore.Migrations;

namespace ASYNC_InnTDCB.Migrations
{
    public partial class SeedMore : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "HotelID", "RoomNumber" },
                keyValues: new object[] { 1, 0 });

            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumns: new[] { "HotelID", "RoomNumber" },
                keyValues: new object[] { 2, 0 });

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Hotels",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "HotelID", "RoomNumber", "PetFriendly", "Rate", "RoomID" },
                values: new object[,]
                {
                    { 1, 101, true, 100m, 1 },
                    { 2, 201, true, 200m, 2 },
                    { 3, 301, false, 300m, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1,
                column: "Phone",
                value: "2061234567");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2,
                column: "Phone",
                value: "2062222222");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3,
                column: "Phone",
                value: "2063333333");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 4,
                column: "Phone",
                value: "2064444444");

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 5,
                column: "Phone",
                value: "2065555555");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Hotels",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "HotelID", "RoomNumber", "PetFriendly", "Rate", "RoomID" },
                values: new object[,]
                {
                    { 1, 0, true, 100m, 1 },
                    { 2, 0, true, 200m, 2 }
                });

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1,
                column: "Phone",
                value: 2061234567);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2,
                column: "Phone",
                value: 2062222222);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3,
                column: "Phone",
                value: 2063333333);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 4,
                column: "Phone",
                value: 2064444444);

            migrationBuilder.UpdateData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 5,
                column: "Phone",
                value: 2065555555);
        }
    }
}
