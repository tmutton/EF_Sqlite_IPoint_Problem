using GeoAPI.Geometries;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Sqlite_IPoint_Problem.Migrations
{
    public partial class VenueLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<IPoint>(
                name: "Location",
                table: "Venues",
                nullable: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Venues");
        }
    }
}
