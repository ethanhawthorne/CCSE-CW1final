using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace asp_net_core_web_app_authentication_authorisation.Migrations
{
    /// <inheritdoc />
    public partial class fourtheverMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
