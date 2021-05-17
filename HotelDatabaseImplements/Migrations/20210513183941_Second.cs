using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelDatabaseImplements.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountFreeRooms",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "LevelOfService",
                table: "Hotels");

            migrationBuilder.DropColumn(
                name: "CountRooms",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "CountDays",
                table: "CheckIns");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountFreeRooms",
                table: "Hotels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "LevelOfService",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountRooms",
                table: "HotelRooms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountDays",
                table: "CheckIns",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
