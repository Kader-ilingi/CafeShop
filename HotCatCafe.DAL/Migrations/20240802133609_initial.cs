using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscountCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountType = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MinimumAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsDiscontinued = table.Column<bool>(type: "bit", nullable: false),
                    Discontinued = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DataSize = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DiscountID = table.Column<int>(type: "int", nullable: true),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Orders_Discounts_DiscountID",
                        column: x => x.DiscountID,
                        principalTable: "Discounts",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReviewId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AppUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ID = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Shipments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShippingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrackingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShippingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MasterId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedIpAddress = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedComputerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedIpAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Shipments_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("02235ab6-faa5-7486-0986-9dce3d5e8edc"), 0, "708 Zena Bypass, New Stacy, Malaysia", new DateTime(2004, 12, 21, 2, 42, 12, 995, DateTimeKind.Local).AddTicks(9401), "9fa2742b-17ee-47c7-be77-02e198c7da89", "virgie69_harber68@yahoo.com", false, 2, false, null, null, null, "dG606uU9", "579.561.3729 x773", false, null, false, "Maya.Graham" },
                    { new Guid("0b606032-a3aa-3c97-011a-60ce9e42cac4"), 0, "91900 Tyler Shoal, South Lonzo, Central African Republic", new DateTime(2006, 5, 22, 5, 50, 31, 97, DateTimeKind.Local).AddTicks(9348), "6a1d961a-c74f-42ed-b9ad-136cf383459b", "titus_hoppe94.schowalter93@yahoo.com", false, 1, false, null, null, null, "PvL9XMUf", "1-345-525-7432 x6688", false, null, false, "Hobart_Schuppe" },
                    { new Guid("4aaefad9-2458-e80b-b20f-03f471b47e94"), 0, "7226 Fay Causeway, Lake Kyla, Senegal", new DateTime(1988, 5, 17, 7, 3, 59, 515, DateTimeKind.Local).AddTicks(862), "a78b2dc7-a630-4bdd-b992-735581b242bd", "camden22.goodwin@gmail.com", false, 0, false, null, null, null, "bnzZ4Fi3", "896-682-8362 x925", false, null, false, "Nadia.Muller51" },
                    { new Guid("58b49fed-8372-f476-401f-52a0c5bf51bc"), 0, "426 Tyra Land, Rosendoborough, Uganda", new DateTime(1995, 4, 6, 17, 45, 36, 602, DateTimeKind.Local).AddTicks(9198), "f81a67c0-843a-45ff-94bd-2226aa430be1", "kiara_howell2539@yahoo.com", false, 1, false, null, null, null, "f5HwMu8S", "334.685.1007", false, null, false, "Gussie_Corwin" },
                    { new Guid("5cd9ab24-14ef-30c0-a18d-c29caf83ab01"), 0, "4109 Fiona Drive, Bergstromstad, Belize", new DateTime(1979, 3, 12, 15, 49, 19, 953, DateTimeKind.Local).AddTicks(7659), "9398fcad-35f1-45c2-a514-57a6fb43e154", "gunnar192@yahoo.com", false, 0, false, null, null, null, "u5PtYS6s", "(360) 203-5596 x08032", false, null, false, "Payton_Metz16" },
                    { new Guid("6093ca50-3e68-0ea0-93e4-c7a7eb94e93a"), 0, "4617 Goyette Fords, South Jennifer, Honduras", new DateTime(1981, 9, 17, 20, 6, 39, 630, DateTimeKind.Local).AddTicks(9974), "587f911d-fcda-4627-bd8f-7551bf8a519a", "tommie80_hermiston@yahoo.com", false, 1, false, null, null, null, "RRGmQqpB", "916.893.1039 x4108", false, null, false, "Cathrine19" },
                    { new Guid("6b1cada8-49cf-92a6-1562-bdae6627bc77"), 0, "22728 Powlowski Lock, Harveyport, Belarus", new DateTime(1990, 1, 1, 12, 21, 35, 748, DateTimeKind.Local).AddTicks(2422), "0784e627-2ee3-4e7a-a008-10ec380d6f62", "ıva.casper62@gmail.com", false, 2, false, null, null, null, "X8YAKGbb", "1-510-723-1505", false, null, false, "Claudine.Hilll52" },
                    { new Guid("6f195fc3-0fb3-7234-1071-13718484c042"), 0, "5558 Kulas Lights, New Joelleberg, Serbia", new DateTime(1995, 4, 5, 5, 0, 54, 170, DateTimeKind.Local).AddTicks(9478), "ceaa40a8-158d-4627-8329-0b9ed2eb572e", "rickie.cruickshank96_welch35@hotmail.com", false, 2, false, null, null, null, "eFGCUPHw", "468-219-3758 x966", false, null, false, "Vesta_Mueller" },
                    { new Guid("703d1c77-273d-4026-26ce-0166120333b5"), 0, "3427 Fisher Place, Lindseyview, Madagascar", new DateTime(2002, 12, 19, 8, 37, 14, 52, DateTimeKind.Local).AddTicks(6028), "3f89e72b-bda5-4a53-96b0-3a3acbb5101b", "sydnee.bartoletti90.aufderhar12@gmail.com", false, 0, false, null, null, null, "1SjNcIwH", "289-506-8046", false, null, false, "Etha.Murazik" },
                    { new Guid("748c12ba-a589-37a0-6570-c917347aa047"), 0, "578 Aurore Port, Osinskishire, French Guiana", new DateTime(1984, 3, 12, 10, 35, 30, 489, DateTimeKind.Local).AddTicks(5897), "0fc862d7-449d-46a2-a47d-be017742a0bf", "johnny_prosacco30.boehm25@hotmail.com", false, 2, false, null, null, null, "yg8MVUUg", "(496) 556-8497 x521", false, null, false, "Arielle21" },
                    { new Guid("79a0fb10-dd26-e7d8-3318-0ed281e569f1"), 0, "58034 Tillman Corners, Lake Alleneberg, Cote d'Ivoire", new DateTime(1997, 5, 15, 6, 52, 40, 922, DateTimeKind.Local).AddTicks(7833), "bc996e26-5721-49bb-93c6-5f3753ab6ba3", "baby_parisian52.mitchell@gmail.com", false, 1, false, null, null, null, "1qXDNvq6", "(791) 433-0090 x66056", false, null, false, "Morton13" },
                    { new Guid("86194ab9-19e1-5d85-81a0-d7dbb9179934"), 0, "5190 Murazik Knolls, Port Madyson, Malta", new DateTime(2002, 6, 19, 9, 3, 33, 873, DateTimeKind.Local).AddTicks(6445), "60c906aa-9fd4-4db7-bd6b-48c3a0761585", "ısmael_runolfsson19@yahoo.com", false, 2, false, null, null, null, "2XbAc_vH", "1-417-654-0503 x51056", false, null, false, "Morton_Hauck65" },
                    { new Guid("976a148f-f8e0-3a10-889b-e13887e89a9a"), 0, "463 Dickinson Streets, Alexandraport, Guyana", new DateTime(1990, 7, 27, 3, 3, 3, 702, DateTimeKind.Local).AddTicks(2183), "f77f3993-1d18-45b3-88d0-e0a99beeba7f", "tierra.schaefer.swift61@yahoo.com", false, 1, false, null, null, null, "gpRsjH7D", "320.796.5016 x563", false, null, false, "Joelle.Corwin" },
                    { new Guid("af628ae5-a9b6-756a-50de-0d3133428a90"), 0, "18420 Lenny Field, Lake Toyberg, Republic of Korea", new DateTime(2003, 7, 16, 4, 18, 33, 314, DateTimeKind.Local).AddTicks(6630), "2ba47660-62fc-4bed-b299-113fd6c1d575", "ısaias_yost94@gmail.com", false, 2, false, null, null, null, "XszhXZAq", "974-365-1365 x521", false, null, false, "Zella.Leffler41" },
                    { new Guid("ce64f326-4772-57fc-30a5-7f9df98fb50b"), 0, "9275 Keyon Brook, West Aurelio, Reunion", new DateTime(2004, 11, 7, 17, 33, 14, 436, DateTimeKind.Local).AddTicks(8251), "587a071f-934d-4416-88c9-40b0bd252c93", "monserrat66.stehr@yahoo.com", false, 1, false, null, null, null, "Mcd3tsXW", "909-300-0905 x43506", false, null, false, "Kyle_Sawayn" },
                    { new Guid("d183a5ce-ab17-b85c-56d7-12cacc56a65f"), 0, "8472 Walter Roads, Reillymouth, Moldova", new DateTime(1981, 7, 6, 3, 32, 27, 372, DateTimeKind.Local).AddTicks(9769), "8c164900-98b0-4505-a61d-1ad96537381a", "marjorie5585@hotmail.com", false, 1, false, null, null, null, "Ca0UWvf8", "385.906.2044", false, null, false, "Dallin26" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Coffees", "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(2091), 2, "Various types of coffee.", true, new Guid("21e3f335-1aba-4ba1-b674-2492481ac664"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Desserts", "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(2229), 2, "Sweet treats and desserts.", true, new Guid("7caf9f05-9cfa-42d3-9397-add14786abdc"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Teas", "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(2233), 2, "Different types of tea.", true, new Guid("4b397609-f121-4711-8575-f7ea8791a449"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Sandwiches", "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(2236), 2, "Assorted sandwiches.", true, new Guid("c8cce6d5-e4fe-467c-86aa-efce186932d0"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Salads", "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(2238), 2, "Fresh and healthy salads.", true, new Guid("782a9607-447d-4332-adf9-8c30da3c3dfc"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Snacks", "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(2241), 2, "Light snacks and nibbles.", true, new Guid("ac604de4-237a-4875-8287-23d18c44d19b"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "Fruit Juices", "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(2243), 2, "Refreshing fruit juices.", true, new Guid("1cb96695-84a7-4713-b163-015cb0fff32d"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "Cakes", "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(2245), 2, "Varieties of cakes.", true, new Guid("d904b62e-a300-41df-acb6-b96faf13091b"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "Ice Creams", "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(2256), 2, "Various ice cream flavors.", true, new Guid("0527feb3-7d9c-4906-bc13-5813c163e7f8"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "Chocolates", "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(2295), 2, "Different types of chocolates.", true, new Guid("380fec55-4795-4104-ad92-61c8e77d8173"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "AppUserId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "DiscountID", "IsActive", "MasterId", "OrderDate", "Status", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[] { 1, null, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 858, DateTimeKind.Local).AddTicks(3534), 2, null, true, new Guid("7128f0e1-3b9b-4170-8b76-3187f3d3355d"), new DateTime(2024, 8, 2, 16, 36, 7, 858, DateTimeKind.Local).AddTicks(3599), 0, 100.00m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "DataSize", "Discontinued", "Discount", "ImagePath", "IsActive", "IsDiscontinued", "MasterId", "Price", "ProductName", "Status", "Stock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, 1, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4842), 2, 0, null, 0.1m, "espresso.jpg", true, false, new Guid("90f29880-138e-43d1-95ee-71f2f236353e"), 2.49m, "Espresso", 0, 50, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 1, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4896), 2, 0, null, 0.15m, "latte.jpg", true, false, new Guid("6680b7a1-659f-4cb8-b9fe-ff0d142fce5a"), 3.49m, "Latte", 0, 30, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 2, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4900), 2, 0, null, 0.2m, "cheesecake.jpg", true, false, new Guid("5fed0a1a-2f87-4872-9974-4c2c34d898d4"), 4.99m, "Cheesecake", 0, 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 2, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4903), 2, 0, null, 0.1m, "brownie.jpg", true, false, new Guid("3590de36-4b03-4696-be5f-042f7ff8b908"), 3.99m, "Brownie", 0, 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 3, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4906), 2, 0, null, 0.05m, "greentea.jpg", true, false, new Guid("ac613aa4-c690-418b-915e-9ea7db62b48b"), 2.99m, "Green Tea", 0, 40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 3, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4908), 2, 0, null, 0.1m, "blacktea.jpg", true, false, new Guid("1921a093-fe4a-436c-bd80-7fccf48d2023"), 2.49m, "Black Tea", 0, 45, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 4, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4916), 2, 0, null, 0.1m, "turkeysandwich.jpg", true, false, new Guid("0341acc6-1cfa-4fa3-876e-b06e46a4c467"), 5.49m, "Turkey Sandwich", 0, 35, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 4, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4920), 2, 0, null, 0.2m, "veggiesandwich.jpg", true, false, new Guid("169dc546-fcb0-4c1b-bcb4-ad1c9b8ac40e"), 4.99m, "Veggie Sandwich", 0, 50, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 5, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4923), 2, 0, null, 0.15m, "caesarsalad.jpg", true, false, new Guid("1450017c-94d3-4a26-b7f7-177ceeb7e7e8"), 6.99m, "Caesar Salad", 0, 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 5, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4929), 2, 0, null, 0.1m, "greeksalad.jpg", true, false, new Guid("3815b91c-3b15-4023-91e1-de79bfc7fe70"), 5.99m, "Greek Salad", 0, 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 6, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4931), 2, 0, null, 0.05m, "chips.jpg", true, false, new Guid("e22673ec-89f1-45dd-a687-6b515893e0e9"), 1.99m, "Chips", 0, 60, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 6, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4934), 2, 0, null, 0.1m, "pretzels.jpg", true, false, new Guid("6480a8f5-16a7-4680-8eb2-aa9e598e259a"), 2.49m, "Pretzels", 0, 70, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 7, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4937), 2, 0, null, 0.1m, "orangejuice.jpg", true, false, new Guid("b4baeceb-9ec0-4649-8c17-f686e3bee8e5"), 3.29m, "Orange Juice", 0, 50, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 7, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4940), 2, 0, null, 0.05m, "applejuice.jpg", true, false, new Guid("086e5839-302c-4a9a-bec1-9440c25632c3"), 2.99m, "Apple Juice", 0, 45, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 8, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4944), 2, 0, null, 0.2m, "chocolatecake.jpg", true, false, new Guid("6b1f2cf3-6560-4401-b242-9dc76c76f8f7"), 6.49m, "Chocolate Cake", 0, 10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 8, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4947), 2, 0, null, 0.15m, "vanillacake.jpg", true, false, new Guid("aacfe4c2-1346-4318-93ca-856f56442495"), 5.99m, "Vanilla Cake", 0, 15, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 9, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4950), 2, 0, null, 0.1m, "vanillaicecream.jpg", true, false, new Guid("ad631006-f60a-4c4a-97d9-539c134c43f4"), 4.49m, "Vanilla Ice Cream", 0, 25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 9, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4953), 2, 0, null, 0.1m, "chocolateicecream.jpg", true, false, new Guid("984154e7-f7d7-4054-bd7a-6c12a5853f58"), 4.99m, "Chocolate Ice Cream", 0, 20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 10, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4957), 2, 0, null, 0.05m, "darkchocolate.jpg", true, false, new Guid("725fc037-7a63-48e9-996a-825f541f5faf"), 2.99m, "Dark Chocolate", 0, 30, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 10, "LAPTOP-7RVI861P", new DateTime(2024, 8, 2, 16, 36, 7, 854, DateTimeKind.Local).AddTicks(4992), 2, 0, null, 0.1m, "milkchocolate.jpg", true, false, new Guid("eea7df5f-273c-45c2-a028-61b43b9d6732"), 2.49m, "Milk Chocolate", 0, 40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AppUserId",
                table: "Orders",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DiscountID",
                table: "Orders",
                column: "DiscountID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_AppUserId",
                table: "Reviews",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_OrderId",
                table: "Shipments",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Shipments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Discounts");
        }
    }
}
