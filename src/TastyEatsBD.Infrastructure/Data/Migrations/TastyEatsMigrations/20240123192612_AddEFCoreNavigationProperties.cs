using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TastyEatsBD.Infrastructure.Data.Migrations.TastyEatsMigrations
{
    /// <inheritdoc />
    public partial class AddEFCoreNavigationProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IDX_Rider_AccountID",
                table: "Riders");

            migrationBuilder.DropIndex(
                name: "IDX_Restaurant_AccountID",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IDX_Ledger_AccountID",
                table: "Ledgers");

            migrationBuilder.DropIndex(
                name: "IDX_DeliveryOrder_OrderID",
                table: "DeliveryOrders");

            migrationBuilder.DropIndex(
                name: "IDX_Customer_AccountID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IDX_AccountSetting_AccountID",
                table: "AccountSettings");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Riders",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Riders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LocationID",
                table: "Restaurants",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Restaurants",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Restaurants",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Orders",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Orders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "DeliveryLocationID",
                table: "Orders",
                newName: "LocationId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Locations",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ReferenceID",
                table: "Ledgers",
                newName: "ReferenceId");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Ledgers",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Ledgers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RestaurantID",
                table: "Items",
                newName: "RestaurantId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Items",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "ItemOrders",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "ItemID",
                table: "ItemOrders",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "ItemOrders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "RiderID",
                table: "DeliveryOrders",
                newName: "RiderId");

            migrationBuilder.RenameColumn(
                name: "RestaurantID",
                table: "DeliveryOrders",
                newName: "RestaurantId");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "DeliveryOrders",
                newName: "OrderId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "DeliveryOrders",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Customers",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "AccountSettings",
                newName: "AccountId");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "AccountSettings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Accounts",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1090), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1097) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1104), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1104) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1105), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1106) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1107), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1107) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1108), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1108) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1111), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1113), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1113) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1114), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1114) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1115), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1115) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1116), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1117) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1117), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1118), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1119) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1119), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1120) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1120), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1121), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1122) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1122), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1123) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1123), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1124) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1125), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1126), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1127) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1127), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1128), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1129) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3056), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3063), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3063) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3065), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3065) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3066), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3066) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3068), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3070), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3071), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3072), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3073), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3073) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3075), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3075) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3080), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3080) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3081), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3082) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3083), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3083) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3084), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3084) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3085), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3087), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3087) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3088), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3089), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3090) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3092), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3093), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3094) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3096), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3098), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3099), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3099) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3100), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3101) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3102), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3102) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3103), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3104) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3104), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3106), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3106) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3107), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3107) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3108), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3109) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3111), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3111) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3113), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3114), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3114) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3144), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3144) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3146), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3147), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3149), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3149) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3150), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3150) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3151), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3151) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3153), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3155), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3157), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3157) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3158), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3158) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3159), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3160), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3162), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3162) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3163), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3164), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3164) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3165), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3167), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3167) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3170), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3170) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3171), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3172) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3173), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3174), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3175), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3175) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3177), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3177) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3178), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3178) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3179), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3179) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3180), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3180) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3182), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3182) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3184), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3184) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3185), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3185) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3186), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3187) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3188), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3188) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3189), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3191), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3191) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3192), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3193), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3193) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3194), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3194) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3196), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3196) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3197), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3199), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3199) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3200), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3201), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3202) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3202), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3203) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3204), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3204) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3205), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3205) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3207), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3247), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3247) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3250), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3252), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3252) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3254), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3254) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3255), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3255) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3256), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3256) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3257), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3259), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3259) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3260), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3261) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3261), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3262) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3263), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3263) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3264), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3265) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3267), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3267) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3268), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3269) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3270), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3271), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3272), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3272) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3274), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3274) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3275), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3276), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3276) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3277), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3279), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3625), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3626) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3639), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3639) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3640), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3641), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3641) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3642), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3642) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3644), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3645) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3645), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3646) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3647), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3647) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3648), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3648) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3649), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1985), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1988), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1990), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1991), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1992), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1994), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1995), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1996), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1997), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1999), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2173), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2175), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2176), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2177), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2179), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2180), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2181), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2182), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2183), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2185), new DateTime(2024, 1, 23, 19, 26, 10, 483, DateTimeKind.Utc).AddTicks(2185) });

            migrationBuilder.CreateIndex(
                name: "IDX_Rider_AccountID",
                table: "Riders",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Riders_IsAvailable",
                table: "Riders",
                column: "IsAvailable");

            migrationBuilder.CreateIndex(
                name: "IDX_Restaurant_AccountID",
                table: "Restaurants",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_IsAvailable",
                table: "Restaurants",
                column: "IsAvailable");

            migrationBuilder.CreateIndex(
                name: "IDX_Ledger_AccountID",
                table: "Ledgers",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_DeliveryOrder_OrderID",
                table: "DeliveryOrders",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_Customer_AccountID",
                table: "Customers",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_AccountSetting_AccountID",
                table: "AccountSettings",
                column: "AccountId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AccountSettings_Accounts_AccountId",
                table: "AccountSettings",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Accounts_AccountId",
                table: "Customers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryOrders_Orders_OrderId",
                table: "DeliveryOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryOrders_Restaurants_RestaurantId",
                table: "DeliveryOrders",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_DeliveryOrders_Riders_RiderId",
                table: "DeliveryOrders",
                column: "RiderId",
                principalTable: "Riders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrders_Items_ItemId",
                table: "ItemOrders",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ItemOrders_Orders_OrderId",
                table: "ItemOrders",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Restaurants_RestaurantId",
                table: "Items",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ledgers_Accounts_AccountId",
                table: "Ledgers",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Locations_LocationId",
                table: "Orders",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Accounts_AccountId",
                table: "Restaurants",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_Locations_LocationId",
                table: "Restaurants",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Riders_Accounts_AccountId",
                table: "Riders",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountSettings_Accounts_AccountId",
                table: "AccountSettings");

            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Accounts_AccountId",
                table: "Customers");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryOrders_Orders_OrderId",
                table: "DeliveryOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryOrders_Restaurants_RestaurantId",
                table: "DeliveryOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_DeliveryOrders_Riders_RiderId",
                table: "DeliveryOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrders_Items_ItemId",
                table: "ItemOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_ItemOrders_Orders_OrderId",
                table: "ItemOrders");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Restaurants_RestaurantId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Ledgers_Accounts_AccountId",
                table: "Ledgers");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Customers_CustomerId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Locations_LocationId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Accounts_AccountId",
                table: "Restaurants");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_Locations_LocationId",
                table: "Restaurants");

            migrationBuilder.DropForeignKey(
                name: "FK_Riders_Accounts_AccountId",
                table: "Riders");

            migrationBuilder.DropIndex(
                name: "IDX_Rider_AccountID",
                table: "Riders");

            migrationBuilder.DropIndex(
                name: "IX_Riders_IsAvailable",
                table: "Riders");

            migrationBuilder.DropIndex(
                name: "IDX_Restaurant_AccountID",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_IsAvailable",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IDX_Ledger_AccountID",
                table: "Ledgers");

            migrationBuilder.DropIndex(
                name: "IDX_DeliveryOrder_OrderID",
                table: "DeliveryOrders");

            migrationBuilder.DropIndex(
                name: "IDX_Customer_AccountID",
                table: "Customers");

            migrationBuilder.DropIndex(
                name: "IDX_AccountSetting_AccountID",
                table: "AccountSettings");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Riders",
                newName: "AccountID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Riders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Restaurants",
                newName: "LocationID");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Restaurants",
                newName: "AccountID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Restaurants",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Orders",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Orders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "LocationId",
                table: "Orders",
                newName: "DeliveryLocationID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Locations",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "ReferenceId",
                table: "Ledgers",
                newName: "ReferenceID");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Ledgers",
                newName: "AccountID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Ledgers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "Items",
                newName: "RestaurantID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Items",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "ItemOrders",
                newName: "OrderID");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ItemOrders",
                newName: "ItemID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ItemOrders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "RiderId",
                table: "DeliveryOrders",
                newName: "RiderID");

            migrationBuilder.RenameColumn(
                name: "RestaurantId",
                table: "DeliveryOrders",
                newName: "RestaurantID");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "DeliveryOrders",
                newName: "OrderID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "DeliveryOrders",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Customers",
                newName: "AccountID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "AccountSettings",
                newName: "AccountID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "AccountSettings",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Accounts",
                newName: "ID");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Items",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(60)",
                oldMaxLength: 60);

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

            migrationBuilder.CreateIndex(
                name: "IDX_Rider_AccountID",
                table: "Riders",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IDX_Restaurant_AccountID",
                table: "Restaurants",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IDX_Ledger_AccountID",
                table: "Ledgers",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IDX_DeliveryOrder_OrderID",
                table: "DeliveryOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IDX_Customer_AccountID",
                table: "Customers",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IDX_AccountSetting_AccountID",
                table: "AccountSettings",
                column: "AccountID");
        }
    }
}
