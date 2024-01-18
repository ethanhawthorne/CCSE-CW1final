using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace asp_net_core_web_app_authentication_authorisation.Migrations
{
    /// <inheritdoc />
    public partial class tenthevermigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelAvailabilities",
                keyColumn: "HotelAvailabilityId",
                keyValue: new Guid("df132c13-cdb7-4a23-9667-5755609f435d"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("0c6fdd3f-fae3-4a96-8abf-11463ef86f7d"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("0feb6f6b-b630-4c10-8419-b49f419e37ed"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("493ec01b-156a-450f-9b68-0e350949d267"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("700f2484-7601-43d8-bb03-aa9ff89ba652"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("9aa08e85-10f3-4dfd-8f74-e50cae0cef7e"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("c345b3e3-c9ce-4182-8389-21ab6d02fbae"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("c4d74b85-afd5-468b-b9d7-01cc671ed9ae"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("cc3aafd6-229b-4ea7-ab7f-8e1182a4bf9a"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("be64579a-9c98-42cf-a99b-893ce4e67237"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0c6fdd3f-fae3-4a96-8abf-11463ef86f7d"), 20, 300m, "LondonMarriotHotel", "double" },
                    { new Guid("0feb6f6b-b630-4c10-8419-b49f419e37ed"), 20, 775m, "HiltonLondonHotel", "double" },
                    { new Guid("493ec01b-156a-450f-9b68-0e350949d267"), 20, 300m, "LondonMarriotHotel", "family suite" },
                    { new Guid("700f2484-7601-43d8-bb03-aa9ff89ba652"), 20, 950m, "HiltonLondonHotel", "family suite" },
                    { new Guid("9aa08e85-10f3-4dfd-8f74-e50cae0cef7e"), 20, 300m, "LondonMarriotHotel", "single" },
                    { new Guid("be64579a-9c98-42cf-a99b-893ce4e67237"), 20, 375m, "HiltonLondonHotel", "single" },
                    { new Guid("c345b3e3-c9ce-4182-8389-21ab6d02fbae"), 20, 300m, "LondonMarriotHotel", "single" },
                    { new Guid("c4d74b85-afd5-468b-b9d7-01cc671ed9ae"), 20, 300m, "LondonMarriotHotel", "family suite" },
                    { new Guid("cc3aafd6-229b-4ea7-ab7f-8e1182a4bf9a"), 20, 300m, "LondonMarriotHotel", "Double" }
                });

            migrationBuilder.InsertData(
                table: "HotelAvailabilities",
                columns: new[] { "HotelAvailabilityId", "AvailableFrom", "AvailableTo", "HotelId" },
                values: new object[] { new Guid("df132c13-cdb7-4a23-9667-5755609f435d"), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("be64579a-9c98-42cf-a99b-893ce4e67237") });
        }
    }
}
