using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Travel.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReservationDate",
                table: "Reviews");

            migrationBuilder.DropColumn(
                name: "ReviewDate",
                table: "Reviews");

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Description", "Location", "Name", "Rating", "Recommended" },
                values: new object[] { 1, "A big tall natural momument", "NYC", "Mt. Everest", 2, true });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Description", "Location", "Name", "Rating", "Recommended" },
                values: new object[] { 2, "Large 'man made' structure", "Egypt", "Great Pyramid", 4, false });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "ReviewId", "Description", "Location", "Name", "Rating", "Recommended" },
                values: new object[] { 3, "Amazing", "New York", "Niagara Falls", 5, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "ReviewId",
                keyValue: 3);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservationDate",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ReviewDate",
                table: "Reviews",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
