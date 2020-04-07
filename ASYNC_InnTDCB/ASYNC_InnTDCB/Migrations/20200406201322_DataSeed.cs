using Microsoft.EntityFrameworkCore.Migrations;

namespace ASYNC_InnTDCB.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "City", "Name", "Phone", "State", "StreetAddress" },
                values: new object[,]
                {
                    { 1, "Seattle", "SeattleWA Hotel", 2061234567, "Washington", "123 Seattle St." },
                    { 2, "Denver", "Denver Hotel", 2062222222, "Colorado", "123 Colorado St." },
                    { 3, "Portland", "Portland Hotel", 2063333333, "Oregon", "123 Portland St." },
                    { 4, "Kona", "Kona Hotel", 2064444444, "Hawaii", "123 Kona St." },
                    { 5, "San Diego", "San Diego Hotel", 2065555555, "California", "123 Diego St." }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
