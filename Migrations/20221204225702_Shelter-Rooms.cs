using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenBed.Migrations
{
    public partial class ShelterRooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Shelters",
                table: "Shelters");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "Shelters",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shelters",
                table: "Shelters",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomID = table.Column<Guid>(nullable: false),
                    ShelterId = table.Column<Guid>(nullable: false),
                    RoomType = table.Column<string>(nullable: false),
                    RoomDescription = table.Column<string>(nullable: true),
                    NumberOfBeds = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Rooms_Shelters_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Shelters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Shelters",
                table: "Shelters");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Shelters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Shelters",
                table: "Shelters",
                column: "ShelterID");
        }
    }
}
