using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TastyEatsBD.Infrastructure.Data.Migrations.TastyEatsMigrations
{
    /// <inheritdoc />
    public partial class UpdateRatingColumnSize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Orders",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(1,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "DeliveryOrders",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(1,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Accounts",
                type: "decimal(2,1)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(1,1)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9363), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9365) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9374), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9374) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9375), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9376) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9377), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9377) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9378), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9401), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9402), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9403), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9404) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9405), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9406), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9407), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9408) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9435), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9435) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9436), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9436) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9437), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9437) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9438), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9438) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9439), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9439) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9440), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9440) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9442), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9442) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9443), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9443) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9444), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9444) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9445), new DateTime(2024, 1, 10, 20, 50, 29, 143, DateTimeKind.Utc).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3181), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3181) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3183), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3183) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3184), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3185), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3188), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3251), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3251) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3253) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3254), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3262), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3264), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3264) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3265), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3266), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3268), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3268) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3270), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3271), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3273), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3274), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3276), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3279), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3282), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3282) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3283), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3283) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3284), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3284) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3285), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3286) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3287), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3287) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3288), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3289) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3290), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3290) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3291), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3291) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3293), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3293) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3295), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3297), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3297) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3298), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3300), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3300) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3301), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3301) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3302), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3303) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3304), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3304) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3305), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3305) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3306), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3308), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3308) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3310), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3310) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3311), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3312), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3314), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3315), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3316), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3317) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3318), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3319), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3321), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3321) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3322), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3322) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3359), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3359) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3365), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3366) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3367), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3367) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3368), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3368) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3369), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3370) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3371), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3371) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3373), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3373) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3374), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3374) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3375), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3376) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3377), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3377) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3379), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3380) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3381), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3381) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3382), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3383) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3384), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3384) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3385), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3385) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3387), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3387) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3388), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3388) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3389), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3389) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3391), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3392) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3393), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3393) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3395), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3395) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3397), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3397) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3398), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3398) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3399), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3399) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3403), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3403) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3405), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3406), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3406) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3407), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3408) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3409), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3410), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3410) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3421), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3421) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3423), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3423) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3424), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3424) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3425), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3425) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3426), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3427) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3428), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3428) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3429), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3430), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3431) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3432), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3432) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3433), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3434) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3436), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3437) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3439), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3464), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3464) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3466), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3466) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3467), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3467) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3469), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3469) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3470), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3470) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3471), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3472) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3473), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3473) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3475), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3475) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3930), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3930) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3934), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3934) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3935), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3935) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3936), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3937) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3938), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3938) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3940), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3940) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3941), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3941) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3942), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3942) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3943), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3946), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(3947) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(827), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(828) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(829), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(831), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(832), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(833) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(834), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(835), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(837), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(838), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(839), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(840), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(841) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1141), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1141) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1143), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1144), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1145), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1145) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1146), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1146) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1148), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1148) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1149), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1149) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1150), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1151), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1151) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1153), new DateTime(2024, 1, 10, 20, 50, 29, 144, DateTimeKind.Utc).AddTicks(1153) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Orders",
                type: "decimal(1,1)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "DeliveryOrders",
                type: "decimal(1,1)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Accounts",
                type: "decimal(1,1)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5481), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5484) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5493), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5493) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5494), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5495) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5495), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5496) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5497), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5497) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5499), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5499) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5500), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5500) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5501), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5501) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5502), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5502) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5504), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5504) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5505), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5505) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5506), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5507), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5507) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5508), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5508) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5509), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5510) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5511), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5511) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5512), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5512) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5513), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5514) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5514), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5516), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5516) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5517), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5517) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9293), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9303), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9303) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9305), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9307), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9309), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9312), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9312) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9313), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9315), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9315) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9316), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9319), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9330), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9330) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9332), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9332) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9333), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9334) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9335), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9379), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9379) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9382), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9382) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9383), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9383) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9385), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9386), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9386) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9531), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9532) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9552), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9552) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9555), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9555) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9556), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9558), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9558) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9559), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9559) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9561), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9562) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9563), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9564), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9564) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9565), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9566) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9568), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9568) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9571), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9571) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9576), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9576) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9577), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9578) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9579), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9579) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9581), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9581) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9583), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9583) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9585), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9587), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9587) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9588), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9589) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9590), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9591) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9593), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9594) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9595), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9595) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9597), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9599), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9599) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9600), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9601) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9603), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9604), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9605) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9606), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9608), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9608) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9616), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9616) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9619), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9622), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9622) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9623), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9623) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9626), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9627) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9628), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9630), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9631) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9632), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9634), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9634) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(518), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(520) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(540), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(540) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(567), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(567) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(569), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(570) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(571), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(572) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(573), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(573) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(574), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(575) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(577), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(577) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(579), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(580), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(582), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(582) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(584), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(585) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(588), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(590), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(590) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(592), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(592) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(594), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(594) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(595), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(596) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(597), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(598) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(599), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(599) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(601), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(601) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(602), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(603) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(605), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(605) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(624), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(625) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(630), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(631) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(632), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(633), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(633) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(635), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(635) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(637), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(638), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(639) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(640), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(640) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(641), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(641) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(643), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(643) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(649), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(650) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(652), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(653), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(654) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(655), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(655) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(656), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(657) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(658), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(659) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(660), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(660) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(661), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(662) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(663), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(664) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(670), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(671) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2492), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2498), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2500), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2501), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2502), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2505), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2506), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2510), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2510) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2511), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2512) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2514), new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6966), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6967) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6970), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6972), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6972) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6973), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6974), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6976), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6978), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6979), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6979) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6980), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6980) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6982), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7280), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7283), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7283) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7284), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7284) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7285), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7285) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7286), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7286) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7288), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7288) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7289), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7289) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7290), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7290) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7291), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7291) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7292), new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7293) });
        }
    }
}
