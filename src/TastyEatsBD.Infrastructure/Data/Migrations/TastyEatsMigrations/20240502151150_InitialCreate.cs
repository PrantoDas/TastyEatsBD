using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TastyEatsBD.Infrastructure.Data.Migrations.TastyEatsMigrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    ProfileImageURL = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccountSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    IsDarkMode = table.Column<bool>(type: "bit", nullable: false),
                    ThemeColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSettings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AccountSettings_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Customers_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Ledgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReferenceId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ledgers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ledgers_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Riders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Riders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Riders_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    RestaurantName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Restaurants_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carts_Accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Accounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Carts_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    PreparationTime = table.Column<int>(type: "int", nullable: true),
                    PhotoURL = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GETDATE()"),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Items_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DeliveryOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    RiderId = table.Column<int>(type: "int", nullable: false),
                    PickupTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(2,1)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DeliveryOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DeliveryOrders_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_DeliveryOrders_Riders_RiderId",
                        column: x => x.RiderId,
                        principalTable: "Riders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
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
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CartItems_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ItemOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItemOrders_Items_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Items",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ItemOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "Id", "AccountType", "CreatedBy", "CreatedOn", "Email", "ModifiedBy", "Name", "ProfileImageURL", "Rating" },
                values: new object[,]
                {
                    { 1, 3, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8619), "daspranto82@gmail.com", "TastyEatsBD_WebApp", "Admin User", null, null },
                    { 2, 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8642), "contact@dhakadelights.com", "TastyEatsBD_WebApp", "Dhaka Delights", null, null },
                    { 3, 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8644), "info@chittagongeats.com", "TastyEatsBD_WebApp", "Chittagong Eats", null, null },
                    { 4, 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8645), "contact@sylhetspices.com", "TastyEatsBD_WebApp", "Sylhet Spices", null, null },
                    { 5, 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8647), "hello@rajshahirecipes.com", "TastyEatsBD_WebApp", "Rajshahi Recipes", null, null },
                    { 6, 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8650), "info@khulnakitchen.com", "TastyEatsBD_WebApp", "Khulna Kitchen", null, null },
                    { 7, 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8652), "support@barisalbites.com", "TastyEatsBD_WebApp", "Barisal Bites", null, null },
                    { 8, 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8654), "contact@rangpurrelish.com", "TastyEatsBD_WebApp", "Rangpur Relish", null, null },
                    { 9, 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8655), "info@mymensinghmunch.com", "TastyEatsBD_WebApp", "Mymensingh Munch", null, null },
                    { 10, 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8658), "hello@comillacuisine.com", "TastyEatsBD_WebApp", "Comilla Cuisine", null, null },
                    { 11, 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8659), "support@gazipurgourmet.com", "TastyEatsBD_WebApp", "Gazipur Gourmet", null, null },
                    { 12, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8661), "aminul.islam@tastyeats.com", "TastyEatsBD_WebApp", "Aminul Islam", null, null },
                    { 13, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8662), "bishal.ray@tastyeats.com", "TastyEatsBD_WebApp", "Bishal Ray", null, null },
                    { 14, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8664), "chayan.das@tastyeats.com", "TastyEatsBD_WebApp", "Chayan Das", null, null },
                    { 15, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8666), "dipu.chandra@tastyeats.com", "TastyEatsBD_WebApp", "Dipu Chandra", null, null },
                    { 16, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8667), "emon.hossain@tastyeats.com", "TastyEatsBD_WebApp", "Emon Hossain", null, null },
                    { 17, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8669), "fahim.molla@tastyeats.com", "TastyEatsBD_WebApp", "Fahim Molla", null, null },
                    { 18, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8671), "gias.uddin@tastyeats.com", "TastyEatsBD_WebApp", "Gias Uddin", null, null },
                    { 19, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8673), "habib.rahman@tastyeats.com", "TastyEatsBD_WebApp", "Habib Rahman", null, null },
                    { 20, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8674), "irfan.ali@tastyeats.com", "TastyEatsBD_WebApp", "Irfan Ali", null, null },
                    { 21, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 917, DateTimeKind.Utc).AddTicks(8676), "joy.barua@tastyeats.com", "TastyEatsBD_WebApp", "Joy Barua", null, null }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "Area", "City", "CreatedBy", "CreatedOn", "Latitude", "Longitude", "ModifiedBy", "StreetAddress", "ZipCode" },
                values: new object[,]
                {
                    { 1, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 919, DateTimeKind.Utc).AddTicks(1975), 23.8103m, 90.4125m, "TastyEatsBD_WebApp", null, null },
                    { 2, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 919, DateTimeKind.Utc).AddTicks(1985), 22.3569m, 91.7832m, "TastyEatsBD_WebApp", null, null },
                    { 3, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 919, DateTimeKind.Utc).AddTicks(1987), 24.8949m, 91.8687m, "TastyEatsBD_WebApp", null, null },
                    { 4, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 919, DateTimeKind.Utc).AddTicks(2035), 24.3636m, 88.6241m, "TastyEatsBD_WebApp", null, null },
                    { 5, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 919, DateTimeKind.Utc).AddTicks(2037), 22.8456m, 89.5403m, "TastyEatsBD_WebApp", null, null },
                    { 6, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 919, DateTimeKind.Utc).AddTicks(2041), 22.7010m, 90.3535m, "TastyEatsBD_WebApp", null, null },
                    { 7, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 919, DateTimeKind.Utc).AddTicks(2043), 25.7439m, 89.2752m, "TastyEatsBD_WebApp", null, null },
                    { 8, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 919, DateTimeKind.Utc).AddTicks(2045), 24.7471m, 90.4203m, "TastyEatsBD_WebApp", null, null },
                    { 9, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 919, DateTimeKind.Utc).AddTicks(2047), 23.4609m, 91.1809m, "TastyEatsBD_WebApp", null, null },
                    { 10, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 919, DateTimeKind.Utc).AddTicks(2049), 24.0023m, 90.4264m, "TastyEatsBD_WebApp", null, null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "AccountId", "CreatedBy", "CreatedOn", "LocationId", "ModifiedBy", "RestaurantName" },
                values: new object[,]
                {
                    { 1, 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(2805), 1, "TastyEatsBD_WebApp", "Dhaka Delights" },
                    { 2, 3, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(2815), 2, "TastyEatsBD_WebApp", "Chittagong Eats" },
                    { 3, 4, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(2817), 3, "TastyEatsBD_WebApp", "Sylhet Spices" },
                    { 4, 5, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(2819), 4, "TastyEatsBD_WebApp", "Rajshahi Recipes" },
                    { 5, 6, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(2821), 5, "TastyEatsBD_WebApp", "Khulna Kitchen" },
                    { 6, 7, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(2824), 6, "TastyEatsBD_WebApp", "Barisal Bites" },
                    { 7, 8, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(2825), 7, "TastyEatsBD_WebApp", "Rangpur Relish" },
                    { 8, 9, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(2827), 8, "TastyEatsBD_WebApp", "Mymensingh Munch" },
                    { 9, 10, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(2829), 9, "TastyEatsBD_WebApp", "Comilla Cuisine" },
                    { 10, 11, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(2831), 10, "TastyEatsBD_WebApp", "Gazipur Gourmet" }
                });

            migrationBuilder.InsertData(
                table: "Riders",
                columns: new[] { "Id", "AccountId", "CreatedBy", "CreatedOn", "ModifiedBy" },
                values: new object[,]
                {
                    { 1, 12, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(5495), "TastyEatsBD_WebApp" },
                    { 2, 13, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(5504), "TastyEatsBD_WebApp" },
                    { 3, 14, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(5507), "TastyEatsBD_WebApp" },
                    { 4, 15, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(5509), "TastyEatsBD_WebApp" },
                    { 5, 16, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(5511), "TastyEatsBD_WebApp" },
                    { 6, 17, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(5517), "TastyEatsBD_WebApp" },
                    { 7, 18, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(5519), "TastyEatsBD_WebApp" },
                    { 8, 19, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(5520), "TastyEatsBD_WebApp" },
                    { 9, 20, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(5522), "TastyEatsBD_WebApp" },
                    { 10, 21, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(5524), "TastyEatsBD_WebApp" }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "Id", "CreatedBy", "CreatedOn", "Description", "Discount", "ModifiedBy", "Name", "PhotoURL", "PreparationTime", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9392), "Aromatic rice dish with marinated chicken and spices", null, "TastyEatsBD_WebApp", "Biryani", null, null, 350m, 1 },
                    { 2, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9488), "Rich stew of lentils, wheat, and tender beef", null, "TastyEatsBD_WebApp", "Haleem", null, null, 220m, 1 },
                    { 3, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9490), "Crispy shells filled with tangy tamarind and chickpeas", null, "TastyEatsBD_WebApp", "Fuchka", null, null, 120m, 1 },
                    { 4, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9495), "Mixed rice dish with lentils and aromatic spices", null, "TastyEatsBD_WebApp", "Bhuna Khichuri", null, null, 280m, 1 },
                    { 5, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9497), "Traditional rice cake, a sweet delight", null, "TastyEatsBD_WebApp", "Pitha", null, null, 150m, 1 },
                    { 6, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9500), "Soft, spongy cheese balls in syrup", null, "TastyEatsBD_WebApp", "Roshogolla", null, null, 100m, 1 },
                    { 7, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9502), "Creamy coconut shrimp curry", null, "TastyEatsBD_WebApp", "Chingri Malai Curry", null, null, 400m, 1 },
                    { 8, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9504), "Slow-cooked spiced beef, a Chittagong specialty", null, "TastyEatsBD_WebApp", "Beef Kala Bhuna", null, null, 320m, 1 },
                    { 9, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9506), "Sweetened yogurt dessert", null, "TastyEatsBD_WebApp", "Mishti Doi", null, null, 150m, 1 },
                    { 10, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9508), "Stuffed bread with egg and minced meat", null, "TastyEatsBD_WebApp", "Mughlai Paratha", null, null, 180m, 1 },
                    { 11, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9516), "Spiced, grilled chicken chunks", null, "TastyEatsBD_WebApp", "Chicken Tikka", null, null, 320m, 2 },
                    { 12, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9518), "Fried bread stuffed with spicy lentils", null, "TastyEatsBD_WebApp", "Dal Puri", null, null, 130m, 2 },
                    { 13, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9520), "Mashed potatoes with mustard oil and spices", null, "TastyEatsBD_WebApp", "Aloo Bhorta", null, null, 90m, 2 },
                    { 14, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9522), "Hilsa fish in mustard sauce", null, "TastyEatsBD_WebApp", "Sorshe Ilish", null, null, 450m, 2 },
                    { 15, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9523), "Slow-cooked beef stew", null, "TastyEatsBD_WebApp", "Nihari", null, null, 300m, 2 },
                    { 16, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9526), "Layered rice and goat meat dish", null, "TastyEatsBD_WebApp", "Kacchi Biryani", null, null, 380m, 2 },
                    { 17, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9528), "Crepes with coconut and jaggery filling", null, "TastyEatsBD_WebApp", "Patishapta", null, null, 160m, 2 },
                    { 18, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9529), "Deep-fried flatbread", null, "TastyEatsBD_WebApp", "Luchi", null, null, 70m, 2 },
                    { 19, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9531), "Cottage cheese in creamy tomato sauce", null, "TastyEatsBD_WebApp", "Paneer Butter Masala", null, null, 350m, 2 },
                    { 20, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9533), "Refreshing yogurt-based mango drink", null, "TastyEatsBD_WebApp", "Mango Lassi", null, null, 180m, 2 },
                    { 21, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9537), "Bread pudding with nuts and cream", null, "TastyEatsBD_WebApp", "Shahi Tukra", null, null, 200m, 3 },
                    { 22, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9540), "Spicy lamb curry with a thick gravy", null, "TastyEatsBD_WebApp", "Lamb Bhuna", null, null, 370m, 3 },
                    { 23, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9541), "Chicken curry with pickling spices", null, "TastyEatsBD_WebApp", "Achari Chicken", null, null, 340m, 3 },
                    { 24, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9543), "Mixed rice with vegetables and lentils", null, "TastyEatsBD_WebApp", "Sabzi Khichuri", null, null, 260m, 3 },
                    { 25, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9686), "Fish in a yogurt-based curry", null, "TastyEatsBD_WebApp", "Doi Maach", null, null, 310m, 3 },
                    { 26, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9689), "Fish curry with mustard paste", null, "TastyEatsBD_WebApp", "Shorshe Bata Diye Macher Jhol", null, null, 330m, 3 },
                    { 27, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9691), "Dark, syrupy sweet made from milk solids", null, "TastyEatsBD_WebApp", "Kalojam", null, null, 110m, 3 },
                    { 28, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9692), "Sweet vermicelli dessert", null, "TastyEatsBD_WebApp", "Shemai", null, null, 140m, 3 },
                    { 29, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9694), "Mutton in a rich, creamy sauce", null, "TastyEatsBD_WebApp", "Mutton Korma", null, null, 390m, 3 },
                    { 30, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9697), "Stir-fried cottage cheese with vegetables", null, "TastyEatsBD_WebApp", "Paneer Jalfrezi", null, null, 320m, 3 },
                    { 31, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9701), "Spicy chicken stir-fry with vegetables", null, "TastyEatsBD_WebApp", "Chicken Jalfrezi", null, null, 330m, 4 },
                    { 32, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9703), "Crispy pastry filled with spiced vegetables", null, "TastyEatsBD_WebApp", "Vegetable Samosa", null, null, 80m, 4 },
                    { 33, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9705), "Cottage cheese in a spiced spinach gravy", null, "TastyEatsBD_WebApp", "Palak Paneer", null, null, 310m, 4 },
                    { 34, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9706), "Creamy dessert of paneer balls in milk syrup", null, "TastyEatsBD_WebApp", "Ras Malai", null, null, 190m, 4 },
                    { 35, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9708), "Mild goat curry with yogurt and cashew nuts", null, "TastyEatsBD_WebApp", "Goat Rezala", null, null, 380m, 4 },
                    { 36, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9711), "Mashed eggplant with onions and tomatoes", null, "TastyEatsBD_WebApp", "Baingan Bharta", null, null, 200m, 4 },
                    { 37, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9712), "Flavorful rice dish with chicken and spices", null, "TastyEatsBD_WebApp", "Chicken Biryani", null, null, 360m, 4 },
                    { 38, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9715), "Fried lentil balls soaked in yogurt", null, "TastyEatsBD_WebApp", "Dahi Vada", null, null, 170m, 4 },
                    { 39, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9717), "Yogurt and spice-marinated chicken, grilled", null, "TastyEatsBD_WebApp", "Tandoori Chicken", null, null, 350m, 4 },
                    { 40, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9719), "Traditional Indian ice cream", null, "TastyEatsBD_WebApp", "Kulfi", null, null, 150m, 4 },
                    { 41, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9723), "Mashed fish with mustard oil and spices", null, "TastyEatsBD_WebApp", "Fish Bharta", null, null, 300m, 5 },
                    { 42, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9725), "Eggplant slices in a chickpea flour batter", null, "TastyEatsBD_WebApp", "Beguni", null, null, 100m, 5 },
                    { 43, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9727), "Layered rice and mutton cooked with aromatic spices", null, "TastyEatsBD_WebApp", "Mutton Biryani", null, null, 380m, 5 },
                    { 44, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9728), "Tangy tamarind and chickpea snack", null, "TastyEatsBD_WebApp", "Chotpoti", null, null, 120m, 5 },
                    { 45, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9730), "Roasted chicken in a flavorful gravy", null, "TastyEatsBD_WebApp", "Chicken Roast", null, null, 350m, 5 },
                    { 46, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9732), "Bottle gourd cooked with lentils", null, "TastyEatsBD_WebApp", "Lau Ghonto", null, null, 180m, 5 },
                    { 47, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9734), "Sweet pumpkin curry", null, "TastyEatsBD_WebApp", "Misti Kumra", null, null, 210m, 5 },
                    { 48, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9736), "Prawns in a creamy coconut milk sauce", null, "TastyEatsBD_WebApp", "Prawn Malai Curry", null, null, 420m, 5 },
                    { 49, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9737), "Spicy black beef curry", null, "TastyEatsBD_WebApp", "Kalo Bhuna", null, null, 370m, 5 },
                    { 50, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9740), "Spiced rice with beef", null, "TastyEatsBD_WebApp", "Tehari", null, null, 340m, 5 },
                    { 51, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9744), "Lentil-stuffed fried bread", null, "TastyEatsBD_WebApp", "Daal Puri", null, null, 110m, 6 },
                    { 52, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9746), "Creamy chicken curry cooked in a handi", null, "TastyEatsBD_WebApp", "Chicken Handi", null, null, 320m, 6 },
                    { 53, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9748), "Mixed vegetable fritters", null, "TastyEatsBD_WebApp", "Vegetable Pakora", null, null, 90m, 6 },
                    { 54, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9750), "Aromatic rice with tender beef pieces", null, "TastyEatsBD_WebApp", "Beef Tehari", null, null, 360m, 6 },
                    { 55, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9752), "Rich and hearty lentil and meat stew", null, "TastyEatsBD_WebApp", "Shahi Halim", null, null, 250m, 6 },
                    { 56, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9754), "Mango flavored rice pudding", null, "TastyEatsBD_WebApp", "Mango Firni", null, null, 150m, 6 },
                    { 57, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9756), "Fish balls in a spicy gravy", null, "TastyEatsBD_WebApp", "Fish Kofta Curry", null, null, 330m, 6 },
                    { 58, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9758), "Mild yogurt-based mutton curry", null, "TastyEatsBD_WebApp", "Mutton Rezala", null, null, 390m, 6 },
                    { 59, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9759), "Chicken cooked with spinach and spices", null, "TastyEatsBD_WebApp", "Palak Chicken", null, null, 310m, 6 },
                    { 60, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9762), "Rice and lentil mix with assorted vegetables", null, "TastyEatsBD_WebApp", "Vegetable Khichuri", null, null, 260m, 6 },
                    { 61, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9765), "Grilled paneer with spices", null, "TastyEatsBD_WebApp", "Paneer Tikka", null, null, 280m, 7 },
                    { 62, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9767), "Spicy grilled mutton ribs", null, "TastyEatsBD_WebApp", "Mutton Chaap", null, null, 400m, 7 },
                    { 63, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9769), "Stir-fried vegetables with Indian spices", null, "TastyEatsBD_WebApp", "Vegetable Jalfrezi", null, null, 220m, 7 },
                    { 64, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9771), "Chicken in a creamy almond sauce", null, "TastyEatsBD_WebApp", "Chicken Korma", null, null, 340m, 7 },
                    { 65, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9772), "Steamed hilsa fish with mustard", null, "TastyEatsBD_WebApp", "Bhapa Ilish", null, null, 450m, 7 },
                    { 66, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9775), "Cottage cheese in a rich tomato gravy", null, "TastyEatsBD_WebApp", "Shahi Paneer", null, null, 310m, 7 },
                    { 67, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9834), "Fragrant rice with marinated chicken", null, "TastyEatsBD_WebApp", "Chicken Biriyani", null, null, 360m, 7 },
                    { 68, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9837), "Lentil soup with spices", null, "TastyEatsBD_WebApp", "Moong Dal", null, null, 150m, 7 },
                    { 69, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9838), "Crispy fried seasoned fish", null, "TastyEatsBD_WebApp", "Fish Fry", null, null, 320m, 7 },
                    { 70, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9841), "Lentil cakes in a spicy gravy", null, "TastyEatsBD_WebApp", "Dhokar Dalna", null, null, 210m, 7 },
                    { 71, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9844), "Spicy beef skewers", null, "TastyEatsBD_WebApp", "Beef Boti Kebab", null, null, 380m, 8 },
                    { 72, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9846), "Mashed spiced shrimp", null, "TastyEatsBD_WebApp", "Chingri Bhorta", null, null, 340m, 8 },
                    { 73, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9848), "Crushed samosa with chickpea and tamarind", null, "TastyEatsBD_WebApp", "Samosa Chat", null, null, 120m, 8 },
                    { 74, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9850), "Chicken in a creamy buttery tomato sauce", null, "TastyEatsBD_WebApp", "Butter Chicken", null, null, 360m, 8 },
                    { 75, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9851), "Assorted vegetables in a spicy gravy", null, "TastyEatsBD_WebApp", "Mixed Vegetable Curry", null, null, 230m, 8 },
                    { 76, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9854), "Hard-boiled eggs in a creamy sauce", null, "TastyEatsBD_WebApp", "Egg Korma", null, null, 250m, 8 },
                    { 77, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9856), "Spicy lamb curry with a vinegar tang", null, "TastyEatsBD_WebApp", "Lamb Vindaloo", null, null, 390m, 8 },
                    { 78, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9857), "Cauliflower and potatoes cooked with Indian spices", null, "TastyEatsBD_WebApp", "Aloo Gobi", null, null, 210m, 8 },
                    { 79, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9859), "Chicken curry with a double onion base", null, "TastyEatsBD_WebApp", "Chicken Do Pyaza", null, null, 320m, 8 },
                    { 80, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9862), "Cheese dumplings in a creamy milk sauce", null, "TastyEatsBD_WebApp", "Rasmalai", null, null, 180m, 8 },
                    { 81, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9865), "Tender lamb cooked in a rich, aromatic sauce", null, "TastyEatsBD_WebApp", "Lamb Rogan Josh", null, null, 410m, 9 },
                    { 82, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9867), "Spicy and tangy shrimp curry", null, "TastyEatsBD_WebApp", "Shrimp Bhuna", null, null, 360m, 9 },
                    { 83, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9869), "Flatbread stuffed with spiced potatoes", null, "TastyEatsBD_WebApp", "Aloo Paratha", null, null, 150m, 9 },
                    { 84, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9870), "Fragrant rice cooked with mixed vegetables", null, "TastyEatsBD_WebApp", "Vegetable Biryani", null, null, 320m, 9 },
                    { 85, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9872), "Soft and buttery flatbread", null, "TastyEatsBD_WebApp", "Butter Naan", null, null, 50m, 9 },
                    { 86, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9875), "Paneer in a spicy tomato-based sauce", null, "TastyEatsBD_WebApp", "Paneer Masala", null, null, 330m, 9 },
                    { 87, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9876), "Chicken in a rich and spicy curry", null, "TastyEatsBD_WebApp", "Chicken Masala", null, null, 350m, 9 },
                    { 88, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9878), "Soft milk-solid balls soaked in rose-scented syrup", null, "TastyEatsBD_WebApp", "Gulab Jamun", null, null, 120m, 9 },
                    { 89, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9880), "Minced meat cooked with peas and spices", null, "TastyEatsBD_WebApp", "Keema Matar", null, null, 340m, 9 },
                    { 90, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9882), "Creamy black lentils cooked with butter and spices", null, "TastyEatsBD_WebApp", "Dal Makhani", null, null, 250m, 9 },
                    { 91, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9886), "Grilled chicken chunks in a spicy sauce", null, "TastyEatsBD_WebApp", "Chicken Tikka Masala", null, null, 360m, 10 },
                    { 92, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9889), "Leavened bread made from maida flour", null, "TastyEatsBD_WebApp", "Kulcha", null, null, 60m, 10 },
                    { 93, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9890), "Spiced and grilled boneless fish pieces", null, "TastyEatsBD_WebApp", "Fish Tikka", null, null, 380m, 10 },
                    { 94, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9892), "Chicken curry made in Mughlai style", null, "TastyEatsBD_WebApp", "Mughlai Chicken", null, null, 370m, 10 },
                    { 95, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9893), "Marinated paneer grilled to perfection", null, "TastyEatsBD_WebApp", "Paneer Tikka", null, null, 310m, 10 },
                    { 96, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9896), "Spiced minced beef grilled on skewers", null, "TastyEatsBD_WebApp", "Beef Sheek Kebab", null, null, 400m, 10 },
                    { 97, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9898), "Assorted vegetables cooked in a flavorful curry", null, "TastyEatsBD_WebApp", "Vegetable Curry", null, null, 270m, 10 },
                    { 98, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9899), "Spiced potato patties", null, "TastyEatsBD_WebApp", "Aloo Tikki", null, null, 110m, 10 },
                    { 99, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9901), "Spicy chickpeas curry", null, "TastyEatsBD_WebApp", "Chana Masala", null, null, 240m, 10 },
                    { 100, "TastyEatsBD_WebApp", new DateTime(2024, 5, 2, 15, 11, 48, 918, DateTimeKind.Utc).AddTicks(9904), "Traditional yogurt-based drink", null, "TastyEatsBD_WebApp", "Lassi", null, null, 150m, 10 }
                });

            migrationBuilder.CreateIndex(
                name: "IDX_AccountSetting_AccountID",
                table: "AccountSettings",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_CartItem_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IDX_CartItem_ItemId",
                table: "CartItems",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IDX_Cart_AccountId",
                table: "Carts",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_Cart_RestaurantId",
                table: "Carts",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IDX_Customer_AccountID",
                table: "Customers",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_DeliveryOrder_OrderID",
                table: "DeliveryOrders",
                column: "OrderId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_DeliveryOrder_RestaurantID",
                table: "DeliveryOrders",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IDX_DeliveryOrder_RiderID",
                table: "DeliveryOrders",
                column: "RiderId");

            migrationBuilder.CreateIndex(
                name: "IDX_ItemOrder_ItemID",
                table: "ItemOrders",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IDX_ItemOrder_OrderID",
                table: "ItemOrders",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IDX_Item_RestaurantID",
                table: "Items",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IDX_Ledger_AccountID",
                table: "Ledgers",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_Order_CustomerID",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IDX_Order_DeliveryLocation",
                table: "Orders",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IDX_Restaurant_AccountID",
                table: "Restaurants",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_Restaurant_LocationID",
                table: "Restaurants",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_IsAvailable",
                table: "Restaurants",
                column: "IsAvailable");

            migrationBuilder.CreateIndex(
                name: "IDX_Rider_AccountID",
                table: "Riders",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Riders_IsAvailable",
                table: "Riders",
                column: "IsAvailable");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountSettings");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "DeliveryOrders");

            migrationBuilder.DropTable(
                name: "ItemOrders");

            migrationBuilder.DropTable(
                name: "Ledgers");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Riders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Accounts");
        }
    }
}
