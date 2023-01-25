using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace E_Shop.Migrations
{
    public partial class FixedMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndDate",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "StartDate",
                table: "Movies");

            migrationBuilder.AddColumn<string>(
                name: "DateReleased",
                table: "Movies",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateReleased",
                table: "Movies");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndDate",
                table: "Movies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "StartDate",
                table: "Movies",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
