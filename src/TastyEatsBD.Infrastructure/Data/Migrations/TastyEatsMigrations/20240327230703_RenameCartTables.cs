using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TastyEatsBD.Infrastructure.Data.Migrations.TastyEatsMigrations
{
    /// <inheritdoc />
    public partial class RenameCartTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cart_Accounts_AccountId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Items_ItemId",
                table: "CartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.RenameTable(
                name: "CartItem",
                newName: "CartItems");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9835), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9838) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9850), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9851), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9851) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9852), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9852) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9853), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9853) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9856), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9856) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9857), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9858), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9859), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9860) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9861), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9862) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9862), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9863) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9863), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9864), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9865), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9867), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9868), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9869), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9869) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9870), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9871) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9872), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9872) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9872), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9873) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9874), new DateTime(2024, 3, 27, 23, 7, 1, 127, DateTimeKind.Utc).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1833), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1833) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1838), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1838) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1839), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1840) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1841), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1841) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1842), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1842) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1844), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1845), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1845) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1847), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1847) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1848), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1848) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1850), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1850) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1854), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1854) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1855), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1856) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1857), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1857) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1858), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1858) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1859), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1859) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1861), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1861) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1862), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1862) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1863), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1864) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1865), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1865) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1866), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1867) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1869), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1869) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1870), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1870) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1871), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1873), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1873) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1874), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1874) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1875), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1876) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1877), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1877) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1878), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1879), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1879) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1880), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1881) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1883), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1883) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1884), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1885) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1886), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1886) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1887), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1887) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1888), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1888) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1914), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1914) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1915), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1916) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1917), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1917) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1918), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1918) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1920), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1920) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1922), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1922) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1924), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1924) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1925), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1925) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1926), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1926) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1927), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1928) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1929), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1930) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1931), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1931) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1932), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1933) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1934), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1936), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1936) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1938), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1939) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1940), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1940) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1941), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1941) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1942), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1944), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1945), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1947), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1948), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1949), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1949) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1951), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1952), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1954), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1955), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1956) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1957), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1958), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1959), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1961), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1962), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1963), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1965), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1967), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1967) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1968), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1969) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1969), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1970) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1974), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1975), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1975) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1976), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1977), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1979), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1979) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1980), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1981), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1995), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1995) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1997), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1998), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2000), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2000) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2001), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2002), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2004), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2004) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2005), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2006), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2008), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2008) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2010), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2012), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2012) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2014), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2014) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2015), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2015) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2016), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2017) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2018), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2019), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2020), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2021) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2022), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2023), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2376), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2376) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2380), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2382), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2383), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2384), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2384) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2386), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2386) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2387), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2388), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2389) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2389), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2390) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2391), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(2391) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(691), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(691) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(694), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(694) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(695), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(697), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(698), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(698) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(700), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(701), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(701) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(702), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(702) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(703), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(704) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(705), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(706) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(945), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(947), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(947) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(948), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(948) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(949), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(950), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(950) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(952), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(952) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(953), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(953) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(954), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(954) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(955), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(955) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(957), new DateTime(2024, 3, 27, 23, 7, 1, 128, DateTimeKind.Utc).AddTicks(957) });

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Items_ItemId",
                table: "CartItems",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Accounts_AccountId",
                table: "Carts",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Items_ItemId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Accounts_AccountId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "CartItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6311), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6315) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6331), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6331) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6333), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6333) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6334), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6334) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6335), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6339), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6340) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6341), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6341) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6342), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6342) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6343), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6345), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6346), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6347), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6348) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6349), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6349) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6350), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6351), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6351) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6352), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6353) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6353), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6354) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6356), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6356) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6357), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6357) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6358), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6358) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6359), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(6359) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8775), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8775) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8780), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8781), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8782) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8783), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8783) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8784), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8786), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8786) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8787), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8788), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8789) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8790), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8792), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8792) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8798), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8798) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8799), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8801), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8801) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8802), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8802) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8803), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8803) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8805), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8805) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8806), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8808), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8808) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8809), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8809) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8811), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8811) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8813), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8813) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8815), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8815) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8816), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8816) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8817), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8817) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8818), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8818) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8821), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8822), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8822) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8823), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8824) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8824), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8825) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8826), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8879), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8879) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8881), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8883), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8884), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8884) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8886), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8886) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8888), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8888) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8889), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8890), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8891), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8893), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8893) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8895), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8897), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8897) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8898), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8899), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8900) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8901), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8901) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8902), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8904), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8904) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8905), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8905) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8906), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8906) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8908), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8908) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8910), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8910) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8912), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8912) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8913), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8914), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8915), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8916) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8917), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8918), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8919) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8920), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8920) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8921), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8921) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8922), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8924), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8925) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8926), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8926) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8927), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8928) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8929), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8930), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8930) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8932), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8932) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8933), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8934), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8935) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8936), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8936) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8937), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8938) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8940), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8940) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8941), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8942) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8943), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8943) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8944), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8973), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8974) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8975), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8977), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8977) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8978), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8978) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8979), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8980) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8982), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8982) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8984), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8984) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8985), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8986) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8987), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8988), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8988) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8989), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8989) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8991), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8992), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8993) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8993), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8994) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8995), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8996), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8997) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8999), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(8999) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9001), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9001) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9002), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9002) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9003), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9003) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9004), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9004) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9006), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9006) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9007), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9007) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9008), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9010), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9010) });

            migrationBuilder.UpdateData(
                table: "Items",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9011), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9011) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9392), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9393) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9397), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9399), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9399) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9400), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9400) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9401), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9401) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9403), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9403) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9404), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9405) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9406), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9406) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9407), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9407) });

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9409), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(9409) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7448), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7449) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7451), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7451) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7452), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7452) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7454), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7455), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7455) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7457), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7457) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7458), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7458) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7459), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7460) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7460), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7461) });

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7463), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7713), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7713) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7715), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7716) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7717), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7717) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7718), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7719), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7719) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7721), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7722), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7722) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7723), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7723) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7724), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7724) });

            migrationBuilder.UpdateData(
                table: "Riders",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7726), new DateTime(2024, 3, 27, 20, 44, 35, 943, DateTimeKind.Utc).AddTicks(7726) });

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_Accounts_AccountId",
                table: "Cart",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Items_ItemId",
                table: "CartItem",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id");
        }
    }
}
