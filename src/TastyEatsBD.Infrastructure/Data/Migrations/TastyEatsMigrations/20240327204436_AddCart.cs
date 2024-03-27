using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TastyEatsBD.Infrastructure.Data.Migrations.TastyEatsMigrations
{
    /// <inheritdoc />
    public partial class AddCart : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItem_Cart_CartId",
                        column: x => x.CartId,
                        principalTable: "Cart",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartItem_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

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

            migrationBuilder.CreateIndex(
                name: "IDX_Cart_AccountId",
                table: "Cart",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_CartItem_CartId",
                table: "CartItem",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IDX_CartItem_ItemId",
                table: "CartItem",
                column: "ItemId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItem");

            migrationBuilder.DropTable(
                name: "Cart");

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
        }
    }
}
