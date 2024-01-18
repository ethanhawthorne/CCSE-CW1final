using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace asp_net_core_web_app_authentication_authorisation.Migrations
{
    /// <inheritdoc />
    public partial class eleventhevermigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelAvailabilities",
                keyColumn: "HotelAvailabilityId",
                keyValue: new Guid("699c4b82-b7bf-4702-85e5-9cc2dce4ab22"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("28073bf4-ba1f-4f18-8937-09b0c51a9a39"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("3229d58b-f241-4c94-bed2-2b06291f404a"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("3ecf8287-66bc-454f-bd54-fca0d6b1da9f"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("50b60cfc-f491-4c5b-947c-4b869530208f"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("83fb3898-8f68-4665-9948-5fb0c116476c"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("c8ec46a3-901f-4882-8ffb-bd934fa67ec0"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("d14d1836-c819-4662-a9f4-4fd51228ebce"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("db585420-0221-43be-bae4-134124ef5fa2"));

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: new Guid("797eaa85-82a1-4d5b-af1a-4f7a7c33f06d"));

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: new Guid("c27955c6-55e4-41d7-b78e-7a6370485322"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("2e08985a-612a-4b02-ae46-089f89fdbbe3"));

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "AvailableSpaces", "Cost", "Name", "RoomType" },
                values: new object[,]
                {
                    { new Guid("2d6e6f03-0269-4efd-abf4-6ac19c8f5b89"), 20, 300m, "LondonMarriotHotel", "double" },
                    { new Guid("5cc630c2-71db-4408-a2cb-d3eed91e7788"), 20, 375m, "HiltonLondonHotel", "single" },
                    { new Guid("61490dbe-ffb8-4cec-be31-b78b1460a4e8"), 20, 775m, "HiltonLondonHotel", "double" },
                    { new Guid("6635efa4-cfc0-41c7-96b7-1b824589fdb9"), 20, 300m, "LondonMarriotHotel", "family suite" },
                    { new Guid("73449102-2705-4ba7-bd3a-4f43bb84b9d0"), 20, 300m, "LondonMarriotHotel", "family suite" },
                    { new Guid("90045802-51c2-45a2-9307-331226063389"), 20, 300m, "LondonMarriotHotel", "single" },
                    { new Guid("99684496-36a7-408d-a758-dc39eee02171"), 20, 300m, "LondonMarriotHotel", "single" },
                    { new Guid("bb94147f-99ea-4fe6-8284-6719f324f0a7"), 20, 950m, "HiltonLondonHotel", "family suite" },
                    { new Guid("dc82ff53-a016-4aa0-8f0a-c9bbe073bd4f"), 20, 300m, "LondonMarriotHotel", "Double" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "AvailableSpaces", "Cost", "DurationInDays", "Name" },
                values: new object[,]
                {
                    { new Guid("4f913e1d-7384-49ec-bc48-46fc98d4ccb0"), 20, 600m, 5, "Britain and Ireland Explorer" },
                    { new Guid("950d8d2f-425e-462a-989b-ad81dffbbb5f"), 20, 600m, 5, "Real Britain" }
                });

            migrationBuilder.InsertData(
                table: "HotelAvailabilities",
                columns: new[] { "HotelAvailabilityId", "AvailableFrom", "AvailableTo", "HotelId" },
                values: new object[] { new Guid("498c0582-817f-4020-8a44-62744fcbc4e3"), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5cc630c2-71db-4408-a2cb-d3eed91e7788") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelAvailabilities",
                keyColumn: "HotelAvailabilityId",
                keyValue: new Guid("498c0582-817f-4020-8a44-62744fcbc4e3"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("2d6e6f03-0269-4efd-abf4-6ac19c8f5b89"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("61490dbe-ffb8-4cec-be31-b78b1460a4e8"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("6635efa4-cfc0-41c7-96b7-1b824589fdb9"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("73449102-2705-4ba7-bd3a-4f43bb84b9d0"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("90045802-51c2-45a2-9307-331226063389"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("99684496-36a7-408d-a758-dc39eee02171"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("bb94147f-99ea-4fe6-8284-6719f324f0a7"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("dc82ff53-a016-4aa0-8f0a-c9bbe073bd4f"));

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: new Guid("4f913e1d-7384-49ec-bc48-46fc98d4ccb0"));

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: new Guid("950d8d2f-425e-462a-989b-ad81dffbbb5f"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("5cc630c2-71db-4408-a2cb-d3eed91e7788"));

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "HotelId", "AvailableSpaces", "Cost", "Name", "RoomType" },
                values: new object[,]
                {
                    { new Guid("28073bf4-ba1f-4f18-8937-09b0c51a9a39"), 20, 950m, "HiltonLondonHotel", "family suite" },
                    { new Guid("2e08985a-612a-4b02-ae46-089f89fdbbe3"), 20, 375m, "HiltonLondonHotel", "single" },
                    { new Guid("3229d58b-f241-4c94-bed2-2b06291f404a"), 20, 300m, "LondonMarriotHotel", "single" },
                    { new Guid("3ecf8287-66bc-454f-bd54-fca0d6b1da9f"), 20, 300m, "LondonMarriotHotel", "family suite" },
                    { new Guid("50b60cfc-f491-4c5b-947c-4b869530208f"), 20, 300m, "LondonMarriotHotel", "double" },
                    { new Guid("83fb3898-8f68-4665-9948-5fb0c116476c"), 20, 300m, "LondonMarriotHotel", "Double" },
                    { new Guid("c8ec46a3-901f-4882-8ffb-bd934fa67ec0"), 20, 300m, "LondonMarriotHotel", "family suite" },
                    { new Guid("d14d1836-c819-4662-a9f4-4fd51228ebce"), 20, 300m, "LondonMarriotHotel", "single" },
                    { new Guid("db585420-0221-43be-bae4-134124ef5fa2"), 20, 775m, "HiltonLondonHotel", "double" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "AvailableSpaces", "Cost", "DurationInDays", "Name" },
                values: new object[,]
                {
                    { new Guid("797eaa85-82a1-4d5b-af1a-4f7a7c33f06d"), 20, 600m, 7, "Real Britain" },
                    { new Guid("c27955c6-55e4-41d7-b78e-7a6370485322"), 20, 600m, 7, "Britain and Ireland Explorer" }
                });

            migrationBuilder.InsertData(
                table: "HotelAvailabilities",
                columns: new[] { "HotelAvailabilityId", "AvailableFrom", "AvailableTo", "HotelId" },
                values: new object[] { new Guid("699c4b82-b7bf-4702-85e5-9cc2dce4ab22"), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2e08985a-612a-4b02-ae46-089f89fdbbe3") });
        }
    }
}
