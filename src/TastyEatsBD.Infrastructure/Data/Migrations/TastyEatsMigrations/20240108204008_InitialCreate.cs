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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(1,1)", nullable: true),
                    ProfileImageURL = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AccountSettings",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    IsDarkMode = table.Column<bool>(type: "bit", nullable: false),
                    ThemeColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountSettings", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DeliveryOrders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    RiderID = table.Column<int>(type: "int", nullable: false),
                    PickupTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeliveryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Rating = table.Column<decimal>(type: "decimal(1,1)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeliveryOrders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ItemOrders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ItemID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemOrders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RestaurantID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: true),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    PreparationTime = table.Column<int>(type: "int", nullable: true),
                    PhotoURL = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Ledgers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(19,4)", nullable: false),
                    TransactionType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReferenceID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ledgers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Latitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(9,6)", nullable: false),
                    StreetAddress = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Area = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerID = table.Column<int>(type: "int", nullable: false),
                    DeliveryLocationID = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<decimal>(type: "decimal(1,1)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    RestaurantName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Riders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<int>(type: "int", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Riders", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Accounts",
                columns: new[] { "ID", "AccountType", "CreatedBy", "CreatedOn", "Email", "ModifiedBy", "ModifiedOn", "Name", "ProfileImageURL", "Rating" },
                values: new object[,]
                {
                    { 1, 3, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5481), "daspranto82@gmail.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5484), "Admin User", null, null },
                    { 2, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5493), "contact@dhakadelights.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5493), "Dhaka Delights", null, null },
                    { 3, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5494), "info@chittagongeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5495), "Chittagong Eats", null, null },
                    { 4, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5495), "contact@sylhetspices.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5496), "Sylhet Spices", null, null },
                    { 5, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5497), "hello@rajshahirecipes.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5497), "Rajshahi Recipes", null, null },
                    { 6, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5499), "info@khulnakitchen.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5499), "Khulna Kitchen", null, null },
                    { 7, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5500), "support@barisalbites.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5500), "Barisal Bites", null, null },
                    { 8, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5501), "contact@rangpurrelish.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5501), "Rangpur Relish", null, null },
                    { 9, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5502), "info@mymensinghmunch.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5502), "Mymensingh Munch", null, null },
                    { 10, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5504), "hello@comillacuisine.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5504), "Comilla Cuisine", null, null },
                    { 11, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5505), "support@gazipurgourmet.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5505), "Gazipur Gourmet", null, null },
                    { 12, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5506), "aminul.islam@tastyeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5506), "Aminul Islam", null, null },
                    { 13, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5507), "bishal.ray@tastyeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5507), "Bishal Ray", null, null },
                    { 14, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5508), "chayan.das@tastyeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5508), "Chayan Das", null, null },
                    { 15, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5509), "dipu.chandra@tastyeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5510), "Dipu Chandra", null, null },
                    { 16, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5511), "emon.hossain@tastyeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5511), "Emon Hossain", null, null },
                    { 17, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5512), "fahim.molla@tastyeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5512), "Fahim Molla", null, null },
                    { 18, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5513), "gias.uddin@tastyeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5514), "Gias Uddin", null, null },
                    { 19, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5514), "habib.rahman@tastyeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5515), "Habib Rahman", null, null },
                    { 20, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5516), "irfan.ali@tastyeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5516), "Irfan Ali", null, null },
                    { 21, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5517), "joy.barua@tastyeats.com", "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(5517), "Joy Barua", null, null }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "ID", "CreatedBy", "CreatedOn", "Description", "Discount", "IsAvailable", "ModifiedBy", "ModifiedOn", "Name", "PhotoURL", "PreparationTime", "Price", "RestaurantID" },
                values: new object[,]
                {
                    { 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9293), "Aromatic rice dish with marinated chicken and spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9294), "Biryani", null, null, 350m, 1 },
                    { 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9303), "Rich stew of lentils, wheat, and tender beef", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9303), "Haleem", null, null, 220m, 1 },
                    { 3, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9305), "Crispy shells filled with tangy tamarind and chickpeas", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9306), "Fuchka", null, null, 120m, 1 },
                    { 4, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9307), "Mixed rice dish with lentils and aromatic spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9308), "Bhuna Khichuri", null, null, 280m, 1 },
                    { 5, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9309), "Traditional rice cake, a sweet delight", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9309), "Pitha", null, null, 150m, 1 },
                    { 6, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9312), "Soft, spongy cheese balls in syrup", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9312), "Roshogolla", null, null, 100m, 1 },
                    { 7, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9313), "Creamy coconut shrimp curry", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9314), "Chingri Malai Curry", null, null, 400m, 1 },
                    { 8, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9315), "Slow-cooked spiced beef, a Chittagong specialty", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9315), "Beef Kala Bhuna", null, null, 320m, 1 },
                    { 9, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9316), "Sweetened yogurt dessert", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9317), "Mishti Doi", null, null, 150m, 1 },
                    { 10, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9319), "Stuffed bread with egg and minced meat", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9319), "Mughlai Paratha", null, null, 180m, 1 },
                    { 11, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9330), "Spiced, grilled chicken chunks", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9330), "Chicken Tikka", null, null, 320m, 2 },
                    { 12, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9332), "Fried bread stuffed with spicy lentils", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9332), "Dal Puri", null, null, 130m, 2 },
                    { 13, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9333), "Mashed potatoes with mustard oil and spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9334), "Aloo Bhorta", null, null, 90m, 2 },
                    { 14, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9335), "Hilsa fish in mustard sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9335), "Sorshe Ilish", null, null, 450m, 2 },
                    { 15, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9379), "Slow-cooked beef stew", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9379), "Nihari", null, null, 300m, 2 },
                    { 16, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9382), "Layered rice and goat meat dish", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9382), "Kacchi Biryani", null, null, 380m, 2 },
                    { 17, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9383), "Crepes with coconut and jaggery filling", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9383), "Patishapta", null, null, 160m, 2 },
                    { 18, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9385), "Deep-fried flatbread", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9385), "Luchi", null, null, 70m, 2 },
                    { 19, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9386), "Cottage cheese in creamy tomato sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9386), "Paneer Butter Masala", null, null, 350m, 2 },
                    { 20, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9531), "Refreshing yogurt-based mango drink", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9532), "Mango Lassi", null, null, 180m, 2 },
                    { 21, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9552), "Bread pudding with nuts and cream", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9552), "Shahi Tukra", null, null, 200m, 3 },
                    { 22, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9555), "Spicy lamb curry with a thick gravy", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9555), "Lamb Bhuna", null, null, 370m, 3 },
                    { 23, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9556), "Chicken curry with pickling spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9557), "Achari Chicken", null, null, 340m, 3 },
                    { 24, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9558), "Mixed rice with vegetables and lentils", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9558), "Sabzi Khichuri", null, null, 260m, 3 },
                    { 25, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9559), "Fish in a yogurt-based curry", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9559), "Doi Maach", null, null, 310m, 3 },
                    { 26, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9561), "Fish curry with mustard paste", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9562), "Shorshe Bata Diye Macher Jhol", null, null, 330m, 3 },
                    { 27, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9563), "Dark, syrupy sweet made from milk solids", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9563), "Kalojam", null, null, 110m, 3 },
                    { 28, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9564), "Sweet vermicelli dessert", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9564), "Shemai", null, null, 140m, 3 },
                    { 29, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9565), "Mutton in a rich, creamy sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9566), "Mutton Korma", null, null, 390m, 3 },
                    { 30, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9568), "Stir-fried cottage cheese with vegetables", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9568), "Paneer Jalfrezi", null, null, 320m, 3 },
                    { 31, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9571), "Spicy chicken stir-fry with vegetables", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9571), "Chicken Jalfrezi", null, null, 330m, 4 },
                    { 32, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9576), "Crispy pastry filled with spiced vegetables", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9576), "Vegetable Samosa", null, null, 80m, 4 },
                    { 33, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9577), "Cottage cheese in a spiced spinach gravy", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9578), "Palak Paneer", null, null, 310m, 4 },
                    { 34, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9579), "Creamy dessert of paneer balls in milk syrup", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9579), "Ras Malai", null, null, 190m, 4 },
                    { 35, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9581), "Mild goat curry with yogurt and cashew nuts", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9581), "Goat Rezala", null, null, 380m, 4 },
                    { 36, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9583), "Mashed eggplant with onions and tomatoes", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9583), "Baingan Bharta", null, null, 200m, 4 },
                    { 37, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9585), "Flavorful rice dish with chicken and spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9586), "Chicken Biryani", null, null, 360m, 4 },
                    { 38, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9587), "Fried lentil balls soaked in yogurt", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9587), "Dahi Vada", null, null, 170m, 4 },
                    { 39, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9588), "Yogurt and spice-marinated chicken, grilled", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9589), "Tandoori Chicken", null, null, 350m, 4 },
                    { 40, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9590), "Traditional Indian ice cream", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9591), "Kulfi", null, null, 150m, 4 },
                    { 41, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9593), "Mashed fish with mustard oil and spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9594), "Fish Bharta", null, null, 300m, 5 },
                    { 42, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9595), "Eggplant slices in a chickpea flour batter", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9595), "Beguni", null, null, 100m, 5 },
                    { 43, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9597), "Layered rice and mutton cooked with aromatic spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9597), "Mutton Biryani", null, null, 380m, 5 },
                    { 44, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9599), "Tangy tamarind and chickpea snack", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9599), "Chotpoti", null, null, 120m, 5 },
                    { 45, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9600), "Roasted chicken in a flavorful gravy", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9601), "Chicken Roast", null, null, 350m, 5 },
                    { 46, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9603), "Bottle gourd cooked with lentils", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9603), "Lau Ghonto", null, null, 180m, 5 },
                    { 47, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9604), "Sweet pumpkin curry", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9605), "Misti Kumra", null, null, 210m, 5 },
                    { 48, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9606), "Prawns in a creamy coconut milk sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9606), "Prawn Malai Curry", null, null, 420m, 5 },
                    { 49, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9608), "Spicy black beef curry", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9608), "Kalo Bhuna", null, null, 370m, 5 },
                    { 50, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9616), "Spiced rice with beef", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9616), "Tehari", null, null, 340m, 5 },
                    { 51, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9619), "Lentil-stuffed fried bread", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9620), "Daal Puri", null, null, 110m, 6 },
                    { 52, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9622), "Creamy chicken curry cooked in a handi", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9622), "Chicken Handi", null, null, 320m, 6 },
                    { 53, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9623), "Mixed vegetable fritters", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9623), "Vegetable Pakora", null, null, 90m, 6 },
                    { 54, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9626), "Aromatic rice with tender beef pieces", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9627), "Beef Tehari", null, null, 360m, 6 },
                    { 55, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9628), "Rich and hearty lentil and meat stew", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9628), "Shahi Halim", null, null, 250m, 6 },
                    { 56, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9630), "Mango flavored rice pudding", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9631), "Mango Firni", null, null, 150m, 6 },
                    { 57, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9632), "Fish balls in a spicy gravy", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9632), "Fish Kofta Curry", null, null, 330m, 6 },
                    { 58, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9634), "Mild yogurt-based mutton curry", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(9634), "Mutton Rezala", null, null, 390m, 6 },
                    { 59, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(518), "Chicken cooked with spinach and spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(520), "Palak Chicken", null, null, 310m, 6 },
                    { 60, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(540), "Rice and lentil mix with assorted vegetables", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(540), "Vegetable Khichuri", null, null, 260m, 6 },
                    { 61, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(567), "Grilled paneer with spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(567), "Paneer Tikka", null, null, 280m, 7 },
                    { 62, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(569), "Spicy grilled mutton ribs", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(570), "Mutton Chaap", null, null, 400m, 7 },
                    { 63, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(571), "Stir-fried vegetables with Indian spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(572), "Vegetable Jalfrezi", null, null, 220m, 7 },
                    { 64, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(573), "Chicken in a creamy almond sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(573), "Chicken Korma", null, null, 340m, 7 },
                    { 65, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(574), "Steamed hilsa fish with mustard", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(575), "Bhapa Ilish", null, null, 450m, 7 },
                    { 66, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(577), "Cottage cheese in a rich tomato gravy", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(577), "Shahi Paneer", null, null, 310m, 7 },
                    { 67, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(579), "Fragrant rice with marinated chicken", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(579), "Chicken Biriyani", null, null, 360m, 7 },
                    { 68, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(580), "Lentil soup with spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(580), "Moong Dal", null, null, 150m, 7 },
                    { 69, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(582), "Crispy fried seasoned fish", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(582), "Fish Fry", null, null, 320m, 7 },
                    { 70, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(584), "Lentil cakes in a spicy gravy", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(585), "Dhokar Dalna", null, null, 210m, 7 },
                    { 71, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(588), "Spicy beef skewers", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(589), "Beef Boti Kebab", null, null, 380m, 8 },
                    { 72, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(590), "Mashed spiced shrimp", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(590), "Chingri Bhorta", null, null, 340m, 8 },
                    { 73, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(592), "Crushed samosa with chickpea and tamarind", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(592), "Samosa Chat", null, null, 120m, 8 },
                    { 74, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(594), "Chicken in a creamy buttery tomato sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(594), "Butter Chicken", null, null, 360m, 8 },
                    { 75, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(595), "Assorted vegetables in a spicy gravy", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(596), "Mixed Vegetable Curry", null, null, 230m, 8 },
                    { 76, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(597), "Hard-boiled eggs in a creamy sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(598), "Egg Korma", null, null, 250m, 8 },
                    { 77, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(599), "Spicy lamb curry with a vinegar tang", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(599), "Lamb Vindaloo", null, null, 390m, 8 },
                    { 78, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(601), "Cauliflower and potatoes cooked with Indian spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(601), "Aloo Gobi", null, null, 210m, 8 },
                    { 79, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(602), "Chicken curry with a double onion base", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(603), "Chicken Do Pyaza", null, null, 320m, 8 },
                    { 80, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(605), "Cheese dumplings in a creamy milk sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(605), "Rasmalai", null, null, 180m, 8 },
                    { 81, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(624), "Tender lamb cooked in a rich, aromatic sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(625), "Lamb Rogan Josh", null, null, 410m, 9 },
                    { 82, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(630), "Spicy and tangy shrimp curry", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(631), "Shrimp Bhuna", null, null, 360m, 9 },
                    { 83, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(632), "Flatbread stuffed with spiced potatoes", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(632), "Aloo Paratha", null, null, 150m, 9 },
                    { 84, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(633), "Fragrant rice cooked with mixed vegetables", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(633), "Vegetable Biryani", null, null, 320m, 9 },
                    { 85, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(635), "Soft and buttery flatbread", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(635), "Butter Naan", null, null, 50m, 9 },
                    { 86, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(637), "Paneer in a spicy tomato-based sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(637), "Paneer Masala", null, null, 330m, 9 },
                    { 87, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(638), "Chicken in a rich and spicy curry", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(639), "Chicken Masala", null, null, 350m, 9 },
                    { 88, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(640), "Soft milk-solid balls soaked in rose-scented syrup", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(640), "Gulab Jamun", null, null, 120m, 9 },
                    { 89, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(641), "Minced meat cooked with peas and spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(641), "Keema Matar", null, null, 340m, 9 },
                    { 90, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(643), "Creamy black lentils cooked with butter and spices", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(643), "Dal Makhani", null, null, 250m, 9 },
                    { 91, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(649), "Grilled chicken chunks in a spicy sauce", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(650), "Chicken Tikka Masala", null, null, 360m, 10 },
                    { 92, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(652), "Leavened bread made from maida flour", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(652), "Kulcha", null, null, 60m, 10 },
                    { 93, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(653), "Spiced and grilled boneless fish pieces", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(654), "Fish Tikka", null, null, 380m, 10 },
                    { 94, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(655), "Chicken curry made in Mughlai style", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(655), "Mughlai Chicken", null, null, 370m, 10 },
                    { 95, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(656), "Marinated paneer grilled to perfection", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(657), "Paneer Tikka", null, null, 310m, 10 },
                    { 96, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(658), "Spiced minced beef grilled on skewers", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(659), "Beef Sheek Kebab", null, null, 400m, 10 },
                    { 97, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(660), "Assorted vegetables cooked in a flavorful curry", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(660), "Vegetable Curry", null, null, 270m, 10 },
                    { 98, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(661), "Spiced potato patties", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(662), "Aloo Tikki", null, null, 110m, 10 },
                    { 99, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(663), "Spicy chickpeas curry", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(664), "Chana Masala", null, null, 240m, 10 },
                    { 100, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(670), "Traditional yogurt-based drink", null, false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(671), "Lassi", null, null, 150m, 10 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "ID", "Area", "City", "CreatedBy", "CreatedOn", "Latitude", "Longitude", "ModifiedBy", "ModifiedOn", "StreetAddress", "ZipCode" },
                values: new object[,]
                {
                    { 1, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2492), 23.8103m, 90.4125m, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2493), null, null },
                    { 2, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2498), 22.3569m, 91.7832m, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2499), null, null },
                    { 3, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2500), 24.8949m, 91.8687m, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2500), null, null },
                    { 4, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2501), 24.3636m, 88.6241m, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2502), null, null },
                    { 5, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2502), 22.8456m, 89.5403m, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2503), null, null },
                    { 6, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2505), 22.7010m, 90.3535m, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2505), null, null },
                    { 7, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2506), 25.7439m, 89.2752m, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2506), null, null },
                    { 8, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2510), 24.7471m, 90.4203m, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2510), null, null },
                    { 9, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2511), 23.4609m, 91.1809m, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2512), null, null },
                    { 10, null, null, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2514), 24.0023m, 90.4264m, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 24, DateTimeKind.Utc).AddTicks(2514), null, null }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "ID", "AccountID", "CreatedBy", "CreatedOn", "IsAvailable", "LocationID", "ModifiedBy", "ModifiedOn", "RestaurantName" },
                values: new object[,]
                {
                    { 1, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6966), false, 1, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6967), "Dhaka Delights" },
                    { 2, 3, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6970), false, 2, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6970), "Chittagong Eats" },
                    { 3, 4, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6972), false, 3, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6972), "Sylhet Spices" },
                    { 4, 5, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6973), false, 4, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6973), "Rajshahi Recipes" },
                    { 5, 6, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6974), false, 5, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6975), "Khulna Kitchen" },
                    { 6, 7, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6976), false, 6, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6977), "Barisal Bites" },
                    { 7, 8, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6978), false, 7, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6978), "Rangpur Relish" },
                    { 8, 9, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6979), false, 8, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6979), "Mymensingh Munch" },
                    { 9, 10, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6980), false, 9, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6980), "Comilla Cuisine" },
                    { 10, 11, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6982), false, 10, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(6982), "Gazipur Gourmet" }
                });

            migrationBuilder.InsertData(
                table: "Riders",
                columns: new[] { "ID", "AccountID", "CreatedBy", "CreatedOn", "IsAvailable", "ModifiedBy", "ModifiedOn" },
                values: new object[,]
                {
                    { 1, 12, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7280), true, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7280) },
                    { 2, 13, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7283), false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7283) },
                    { 3, 14, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7284), true, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7284) },
                    { 4, 15, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7285), true, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7285) },
                    { 5, 16, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7286), false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7286) },
                    { 6, 17, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7288), true, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7288) },
                    { 7, 18, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7289), false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7289) },
                    { 8, 19, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7290), true, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7290) },
                    { 9, 20, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7291), true, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7291) },
                    { 10, 21, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7292), false, "TastyEatsBD_WebApp", new DateTime(2024, 1, 8, 20, 40, 7, 23, DateTimeKind.Utc).AddTicks(7293) }
                });

            migrationBuilder.CreateIndex(
                name: "IDX_AccountSetting_AccountID",
                table: "AccountSettings",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IDX_Customer_AccountID",
                table: "Customers",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IDX_DeliveryOrder_OrderID",
                table: "DeliveryOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IDX_DeliveryOrder_RestaurantID",
                table: "DeliveryOrders",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IDX_DeliveryOrder_RiderID",
                table: "DeliveryOrders",
                column: "RiderID");

            migrationBuilder.CreateIndex(
                name: "IDX_ItemOrder_ItemID",
                table: "ItemOrders",
                column: "ItemID");

            migrationBuilder.CreateIndex(
                name: "IDX_ItemOrder_OrderID",
                table: "ItemOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IDX_Item_RestaurantID",
                table: "Items",
                column: "RestaurantID");

            migrationBuilder.CreateIndex(
                name: "IDX_Ledger_AccountID",
                table: "Ledgers",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IDX_Order_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IDX_Order_DeliveryLocation",
                table: "Orders",
                column: "DeliveryLocationID");

            migrationBuilder.CreateIndex(
                name: "IDX_Restaurant_AccountID",
                table: "Restaurants",
                column: "AccountID");

            migrationBuilder.CreateIndex(
                name: "IDX_Restaurant_LocationID",
                table: "Restaurants",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IDX_Rider_AccountID",
                table: "Riders",
                column: "AccountID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "AccountSettings");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "DeliveryOrders");

            migrationBuilder.DropTable(
                name: "ItemOrders");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Ledgers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Riders");
        }
    }
}
