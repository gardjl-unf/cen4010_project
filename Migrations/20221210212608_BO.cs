using Microsoft.EntityFrameworkCore.Migrations;

namespace OpenBed.Migrations
{
    public partial class BO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NumberOfBedsOccupied",
                table: "Rooms",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NumberOfBedsOccupied",
                table: "Rooms");
        }
    }
}
