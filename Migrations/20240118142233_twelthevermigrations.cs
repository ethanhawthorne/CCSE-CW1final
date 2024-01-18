using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace asp_net_core_web_app_authentication_authorisation.Migrations
{
    /// <inheritdoc />
    public partial class twelthevermigrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("10091c4b-164d-4048-9d25-85f03456afc5"), 20, 300m, "LondonMarriotHotel", "double" },
                    { new Guid("28b15918-33ea-40e5-9263-641c4b5c0cb5"), 20, 300m, "LondonMarriotHotel", "single" },
                    { new Guid("2c6a4da3-7570-4728-8adb-039a8ccf14df"), 20, 375m, "HiltonLondonHotel", "single" },
                    { new Guid("36062ece-d128-4dab-9714-ca50137b19e5"), 20, 775m, "HiltonLondonHotel", "double" },
                    { new Guid("432704ae-ca38-455f-b4b3-4312ee4addda"), 20, 300m, "LondonMarriotHotel", "family suite" },
                    { new Guid("5826782c-46b2-4bae-afe5-2887e4ec9f95"), 20, 950m, "HiltonLondonHotel", "family suite" },
                    { new Guid("6e77bdf8-d9bb-4bae-a7d3-b87b9097a04a"), 20, 300m, "LondonMarriotHotel", "Double" },
                    { new Guid("cffd5c3b-0e2b-4f1f-9074-1045f891c6e7"), 20, 300m, "LondonMarriotHotel", "single" },
                    { new Guid("fd240acb-b00c-469d-84c6-28e7c528e09c"), 20, 300m, "LondonMarriotHotel", "family suite" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "TourId", "AvailableSpaces", "Cost", "DurationInDays", "Name" },
                values: new object[,]
                {
                    { new Guid("6a81339b-43f1-4c56-a09d-329d7d893d6d"), 20, 600m, 5, "Britain and Ireland Explorer" },
                    { new Guid("c78c99a4-a9de-4786-9c79-10788c0b4d97"), 20, 600m, 5, "Real Britain" }
                });

            migrationBuilder.InsertData(
                table: "HotelAvailabilities",
                columns: new[] { "HotelAvailabilityId", "AvailableFrom", "AvailableTo", "HotelId" },
                values: new object[] { new Guid("b610a9c3-49e3-4143-995a-fd40baec5958"), new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2c6a4da3-7570-4728-8adb-039a8ccf14df") });

            migrationBuilder.InsertData(
                table: "TourAvailabilities",
                columns: new[] { "TourAvailabilityId", "AvailableFrom", "AvailableTo", "TourId" },
                values: new object[] { new Guid("308352ee-b4bb-44c7-89e7-085f89b70c3a"), new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c78c99a4-a9de-4786-9c79-10788c0b4d97") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "HotelAvailabilities",
                keyColumn: "HotelAvailabilityId",
                keyValue: new Guid("b610a9c3-49e3-4143-995a-fd40baec5958"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("10091c4b-164d-4048-9d25-85f03456afc5"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("28b15918-33ea-40e5-9263-641c4b5c0cb5"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("36062ece-d128-4dab-9714-ca50137b19e5"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("432704ae-ca38-455f-b4b3-4312ee4addda"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("5826782c-46b2-4bae-afe5-2887e4ec9f95"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("6e77bdf8-d9bb-4bae-a7d3-b87b9097a04a"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("cffd5c3b-0e2b-4f1f-9074-1045f891c6e7"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("fd240acb-b00c-469d-84c6-28e7c528e09c"));

            migrationBuilder.DeleteData(
                table: "TourAvailabilities",
                keyColumn: "TourAvailabilityId",
                keyValue: new Guid("308352ee-b4bb-44c7-89e7-085f89b70c3a"));

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: new Guid("6a81339b-43f1-4c56-a09d-329d7d893d6d"));

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "HotelId",
                keyValue: new Guid("2c6a4da3-7570-4728-8adb-039a8ccf14df"));

            migrationBuilder.DeleteData(
                table: "Tours",
                keyColumn: "TourId",
                keyValue: new Guid("c78c99a4-a9de-4786-9c79-10788c0b4d97"));

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
    }
}
