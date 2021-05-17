using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelDatabaseImplements.Migrations
{
    public partial class Fourth : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckIns_Clients_ClientId",
                table: "CheckIns");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Hotels_HotelId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Clients_ClientId",
                table: "HotelRooms");

            migrationBuilder.AddColumn<int>(
                name: "CheckInId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HotelId",
                table: "Payments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "HotelRooms",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Clients",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "CheckIns",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIns_Clients_ClientId",
                table: "CheckIns",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Hotels_HotelId",
                table: "Clients",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Clients_ClientId",
                table: "HotelRooms",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheckIns_Clients_ClientId",
                table: "CheckIns");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Hotels_HotelId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_HotelRooms_Clients_ClientId",
                table: "HotelRooms");

            migrationBuilder.DropColumn(
                name: "CheckInId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "HotelId",
                table: "Payments");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "HotelRooms",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "HotelId",
                table: "Clients",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "CheckIns",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_CheckIns_Clients_ClientId",
                table: "CheckIns",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Hotels_HotelId",
                table: "Clients",
                column: "HotelId",
                principalTable: "Hotels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HotelRooms_Clients_ClientId",
                table: "HotelRooms",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
