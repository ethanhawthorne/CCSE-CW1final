using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace asp_net_core_web_app_authentication_authorisation.Migrations
{
    /// <inheritdoc />
    public partial class SecondeverMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "AvailableSpaces", "Cost", "Name", "RoomType" },
                values: new object[,]
                {
                    { new Guid("0594aaeb-cf8f-4351-85b3-c5e50332558a"), 20, 300m, "LondonMarriotHotel", "Single" },
                    { new Guid("2e5b89dd-d95f-4022-ad22-76d0f6011d84"), 20, 375m, "HiltonLondonHotel", "Single" },
                    { new Guid("7a7306ea-1a36-4c85-af92-5d18d9f728d2"), 20, 950m, "HiltonLondonHotel", "Family" },
                    { new Guid("9a0f91d7-a2f5-4ba2-b5a1-12e19e87f4b8"), 20, 775m, "HiltonLondonHotel", "Double" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("0594aaeb-cf8f-4351-85b3-c5e50332558a"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("2e5b89dd-d95f-4022-ad22-76d0f6011d84"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("7a7306ea-1a36-4c85-af92-5d18d9f728d2"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("9a0f91d7-a2f5-4ba2-b5a1-12e19e87f4b8"));
        }
    }
}
