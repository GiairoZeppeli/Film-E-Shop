using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Shop.Migrations
{
    public partial class FixedCinema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Producers",
                newName: "Bio");

            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "Cinemas",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Bio",
                table: "Producers",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Cinemas",
                newName: "Bio");
        }
    }
}
