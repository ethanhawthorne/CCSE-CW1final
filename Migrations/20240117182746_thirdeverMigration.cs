using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace asp_net_core_web_app_authentication_authorisation.Migrations
{
    /// <inheritdoc />
    public partial class thirdeverMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "AvailableSpaces", "Cost", "Name", "RoomType" },
                values: new object[,]
                {
                    { new Guid("3225b834-2b4f-473b-afbb-1e489eecd1fb"), 20, 950m, "HiltonLondonHotel", "family suite" },
                    { new Guid("b11c61b5-9724-4b29-bddc-c2607e01b266"), 20, 300m, "LondonMarriotHotel", "single" },
                    { new Guid("ec2a26ac-c715-43ef-b8a6-04864058bc71"), 20, 775m, "HiltonLondonHotel", "double" },
                    { new Guid("f261998c-a13c-45f1-a3bc-6d5d3855d710"), 20, 375m, "HiltonLondonHotel", "single" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("3225b834-2b4f-473b-afbb-1e489eecd1fb"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("b11c61b5-9724-4b29-bddc-c2607e01b266"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("ec2a26ac-c715-43ef-b8a6-04864058bc71"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("f261998c-a13c-45f1-a3bc-6d5d3855d710"));

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
    }
}
