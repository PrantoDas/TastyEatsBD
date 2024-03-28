using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TastyEatsBD.Infrastructure.Data.Migrations.AppIdentityMigrations
{
    /// <inheritdoc />
    public partial class RenameToAccountId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "46e425ed-ac09-4dfa-a5e5-f174d86b5c0e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fafe134-9230-413e-a2a8-31fcf3ec10b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81f6be8e-5c55-4539-8302-f854b5fba63d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3ebd148-574e-475f-ab3c-a45d678f4a71");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2c977bc-be70-491f-b14f-c5c99a0cc48f");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "AspNetUsers",
                newName: "AccountId");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1511e2da-f405-49b9-a33d-2a346c9c09b9", "d8338eb0-9015-483b-b6de-d0f6fa11c69e", "Restaurant", "RESTAURANT" },
                    { "74253ecf-0665-40d2-960c-c452edf16195", "03b49e36-f6af-4ed2-8966-50eb79f3d053", "Administrator", "ADMINISTRATOR" },
                    { "83defad9-2b06-4215-b8fc-1396f8de6e6e", "766edb49-f0a3-42d6-a144-0f5d39fa1f73", "Customer", "CUSTOMER" },
                    { "8ec7aeb9-56da-4b1f-9219-701e133225ca", "dc1a8203-0a0c-4fc5-a66d-7cf1d7cc91ab", "CustomerCare", "CUSTOMERCARE" },
                    { "a7f6fa26-9ce7-48cc-b192-3e696a715159", "3dfe982b-87ac-4496-bd31-3252ecd35d12", "Rider", "RIDER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1511e2da-f405-49b9-a33d-2a346c9c09b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74253ecf-0665-40d2-960c-c452edf16195");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83defad9-2b06-4215-b8fc-1396f8de6e6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ec7aeb9-56da-4b1f-9219-701e133225ca");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a7f6fa26-9ce7-48cc-b192-3e696a715159");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "AspNetUsers",
                newName: "AccountID");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "46e425ed-ac09-4dfa-a5e5-f174d86b5c0e", "0fc1dd81-34a3-4ca0-8513-2051e35c1c8b", "Customer", "CUSTOMER" },
                    { "7fafe134-9230-413e-a2a8-31fcf3ec10b2", "f4e2f341-7362-450f-9b3e-e0dc708f94ee", "Rider", "RIDER" },
                    { "81f6be8e-5c55-4539-8302-f854b5fba63d", "56a83605-9fb9-4f85-b779-9825839bcd2f", "Restaurant", "RESTAURANT" },
                    { "b3ebd148-574e-475f-ab3c-a45d678f4a71", "2402c073-c1ab-4cdc-9278-3046c5d52887", "CustomerCare", "CUSTOMERCARE" },
                    { "c2c977bc-be70-491f-b14f-c5c99a0cc48f", "c45c3047-52ec-4343-92c4-e27f14d56042", "Administrator", "ADMINISTRATOR" }
                });
        }
    }
}
