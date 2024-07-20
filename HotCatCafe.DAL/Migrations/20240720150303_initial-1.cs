using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initial1 : Migration
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
                    Stock = table.Column<short>(type: "smallint", nullable: false),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    IsDiscontinued = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Discontinued = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ProductStatus = table.Column<int>(type: "int", nullable: false),
                    DataSize = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
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
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_OrderDetails", x => x.ID);
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
                        onDelete: ReferentialAction.Cascade);
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
                    { new Guid("0c600817-3788-77ec-e153-e8bda17676f6"), 0, "13093 Schmitt Highway, North Alyceville, Christmas Island", new DateTime(1981, 7, 18, 21, 51, 7, 543, DateTimeKind.Local).AddTicks(3124), "bf75fa85-a6f1-465d-86bd-a032feea86c8", "larissa77.anderson@gmail.com", false, 1, false, null, null, null, "RvjP_14O", "601.337.4772 x8813", false, null, false, "Stan.Kirlin" },
                    { new Guid("0ff3a9eb-f963-9013-8b4e-1011f7104a2d"), 0, "0617 Kovacek Drives, Kuhicside, Turks and Caicos Islands", new DateTime(1997, 1, 27, 9, 26, 46, 327, DateTimeKind.Local).AddTicks(9913), "c01089d5-9990-48b5-afc1-20ed11b4ea98", "pedro.strosin9@yahoo.com", false, 1, false, null, null, null, "me3hcgiO", "793-500-3756", false, null, false, "Hulda52" },
                    { new Guid("1dd2393a-d3f8-3c83-aeb4-02d6046658e3"), 0, "3702 Ike Pass, Corkeryfurt, Dominican Republic", new DateTime(1989, 9, 12, 2, 55, 4, 883, DateTimeKind.Local).AddTicks(8918), "701d2269-f64e-4d4f-b8d5-8582ed7d04b4", "jerod.hermiston4221@yahoo.com", false, 1, false, null, null, null, "fC1ivnON", "1-282-538-4350", false, null, false, "Frankie.Goodwin" },
                    { new Guid("23f2811f-a80e-c428-f0ce-f34b98e61483"), 0, "05924 Destini Locks, Harveyton, Egypt", new DateTime(2003, 4, 6, 11, 58, 22, 439, DateTimeKind.Local).AddTicks(7276), "f4551e45-3fce-4205-9f71-49d27ae9f723", "maida.lehner86@hotmail.com", false, 2, false, null, null, null, "pmgUoTh9", "1-264-877-5870 x6299", false, null, false, "Cheyanne_Leuschke36" },
                    { new Guid("34113781-91fa-c2d2-9454-85b7296d42bf"), 0, "27924 Juvenal Causeway, Schneiderview, Bolivia", new DateTime(1980, 8, 5, 10, 20, 3, 497, DateTimeKind.Local).AddTicks(3471), "e47b9f26-2376-4001-8d6c-5c23178eb3e3", "don8390@hotmail.com", false, 1, false, null, null, null, "_kKmirBJ", "515.975.9695", false, null, false, "Wilburn58" },
                    { new Guid("6873295c-1b4b-3da6-aa0e-3e20280c77b5"), 0, "914 Emard Brooks, Glenstad, Turks and Caicos Islands", new DateTime(1998, 11, 18, 6, 39, 49, 399, DateTimeKind.Local).AddTicks(9906), "66d45507-a7be-4fa5-82f8-d890f722e7d2", "emelia55_reinger92@gmail.com", false, 2, false, null, null, null, "a8puUH7E", "(340) 903-5123", false, null, false, "Kellen47" },
                    { new Guid("84f3c1f7-28e4-0f6a-4ec8-c53bc9e38f33"), 0, "7247 Celine Key, Grahammouth, Uruguay", new DateTime(2005, 3, 15, 9, 46, 14, 706, DateTimeKind.Local).AddTicks(595), "039ed134-a7a6-4bc5-b39d-55457d8ce5ab", "pablo67.bins34@yahoo.com", false, 0, false, null, null, null, "S4M7K8Ua", "1-742-406-0353 x79372", false, null, false, "Adrain.Mohr35" },
                    { new Guid("95354688-ac81-0c2b-720c-e653e3a6f10d"), 0, "6160 Nona Streets, East Oceaneshire, Estonia", new DateTime(1977, 6, 8, 22, 27, 57, 200, DateTimeKind.Local).AddTicks(2919), "cbfc7fc9-5fdc-4b8d-a844-ec75a41e8a30", "genesis.altenwerth_hansen@yahoo.com", false, 2, false, null, null, null, "AFsCYnft", "262-608-6701 x58403", false, null, false, "Alford.McKenzie" },
                    { new Guid("b0a863f3-94d5-726f-5ee4-91e29a4ffe07"), 0, "5037 Jewel Ferry, Port Tomas, Georgia", new DateTime(1988, 3, 20, 3, 35, 45, 667, DateTimeKind.Local).AddTicks(5959), "9d6af978-4df5-428b-8d95-7d2c718f3d70", "zackery34_wehner63@gmail.com", false, 0, false, null, null, null, "V6yU5Yx_", "596.897.1937 x69068", false, null, false, "Reece81" },
                    { new Guid("b63e89f0-2b11-b989-c704-f3989a5d5bf8"), 0, "76408 Kshlerin Squares, New Ibrahim, Guyana", new DateTime(1985, 9, 3, 3, 36, 6, 355, DateTimeKind.Local).AddTicks(3830), "8d30eddd-3561-4a69-8ac2-abf59e8062e7", "raegan22.emard@gmail.com", false, 1, false, null, null, null, "CFq_ImOS", "1-427-884-8482 x86248", false, null, false, "Annabelle.Homenick" },
                    { new Guid("bc8c5788-f9ea-091c-f5f6-b5128dda81d1"), 0, "0225 Taurean Underpass, New Rollin, Virgin Islands, U.S.", new DateTime(2003, 6, 17, 9, 20, 21, 171, DateTimeKind.Local).AddTicks(7375), "78e736b9-32c1-4bd7-a526-5613b1906a04", "ısai.dare_mayert@gmail.com", false, 0, false, null, null, null, "lgmxhYyE", "(719) 614-6625", false, null, false, "Leann.Larson" },
                    { new Guid("be02e853-4ab8-8c73-8cca-64cd2971a265"), 0, "605 Cornell Lodge, New Roosevelt, United Arab Emirates", new DateTime(1978, 8, 5, 20, 32, 41, 509, DateTimeKind.Local).AddTicks(7860), "05acb753-e79c-48cb-9e84-74e04ec8af43", "sophia3_koelpin69@yahoo.com", false, 0, false, null, null, null, "E5EePzeD", "1-405-796-9276 x27269", false, null, false, "Rusty77" },
                    { new Guid("c1085048-07b9-005e-7d7a-2f52be5aa836"), 0, "592 Daniella Freeway, South Lorenview, Chad", new DateTime(2003, 5, 3, 17, 41, 35, 131, DateTimeKind.Local).AddTicks(610), "d18a5a1b-6d50-49cd-ad00-38be816362c7", "faustino97.boyle@yahoo.com", false, 1, false, null, null, null, "VbgHhRbI", "564-855-2904", false, null, false, "Ned_Mayer67" },
                    { new Guid("ee38c13e-9634-02df-0e7f-214e65fa0287"), 0, "645 Mertz Burg, Cartwrightshire, Denmark", new DateTime(1988, 8, 20, 3, 19, 52, 442, DateTimeKind.Local).AddTicks(179), "45143dbc-3fad-4f62-af0c-dec02baf89fd", "frankie.mraz.rau@yahoo.com", false, 2, false, null, null, null, "dh0Xvxfk", "547-817-9244 x025", false, null, false, "Lavon.Glover" },
                    { new Guid("f331a2c8-3751-8369-870b-aed2174c945e"), 0, "428 Kozey Fort, Sporerberg, Netherlands Antilles", new DateTime(1985, 11, 16, 4, 38, 3, 86, DateTimeKind.Local).AddTicks(6981), "04861a8a-1d9c-4098-bf16-3fd5b6dcc3c9", "pattie55_oreilly18@gmail.com", false, 2, false, null, null, null, "sjHIqK2e", "1-217-492-1112", false, null, false, "Teagan_Armstrong9" },
                    { new Guid("f675fdcb-be13-5729-fb1e-381a95903a25"), 0, "570 Corwin Drives, Erwinfort, Tokelau", new DateTime(1977, 9, 19, 3, 39, 24, 119, DateTimeKind.Local).AddTicks(77), "4f166a89-6fdd-4dce-999f-84dbeee6b744", "felix.doyle21.flatley@yahoo.com", false, 2, false, null, null, null, "PTTInNIK", "610.998.6129 x1645", false, null, false, "Ron76" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Desserts", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(5908), 2, "Veniam vitae dolores totam in qui consectetur doloribus aspernatur reprehenderit.", true, new Guid("489402f0-ec54-4d08-9d9b-d60fa850e347"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Desserts", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6224), 2, "Praesentium sunt eos alias et laudantium et et.", true, new Guid("97c4ce5e-3bfd-422d-9736-e25715739049"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Salads", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6310), 2, "Labore minus beatae iusto tenetur omnis est libero ipsa ex.", true, new Guid("871196f1-9feb-485a-a0b3-041269050595"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Snacks", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6353), 2, "Animi earum quaerat est aspernatur non ut debitis.", true, new Guid("cb03cf6b-4850-4774-b681-b57e6073a287"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Ice Creams", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6384), 2, "Vel in sint non maiores aliquid ut.", true, new Guid("b23067c2-d2b3-430f-b31f-25f6903d3089"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Cakes", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6414), 2, "Non sint beatae deleniti soluta dicta.", true, new Guid("63236bfd-3fe6-4892-af6d-684a41eff635"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "Sandwiches", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6435), 2, "Commodi tenetur et quibusdam laudantium.", true, new Guid("72a167d9-f07b-493b-8e81-9ce98e65a054"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "Salads", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6453), 2, "Et molestiae maiores accusamus voluptatem quidem aliquid consequatur quis.", true, new Guid("ec028b98-73c8-4e52-886d-73880e8fb619"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "Fruit Juices", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6499), 2, "Alias earum ratione pariatur ex sed.", true, new Guid("40e9d26a-35dc-4f69-925d-bcd67c375b97"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "Cakes", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6565), 2, "Ut qui est architecto voluptas laudantium ea ducimus eum earum.", true, new Guid("66f4e690-4c44-4ac7-aa82-08a2b34619b2"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "Salads", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6596), 2, "Non qui numquam.", true, new Guid("cfbfaacd-5157-425b-9641-2eef3261565c"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "Chocolates", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6610), 2, "Nobis aut aut rerum est qui veritatis.", true, new Guid("68dd0958-121f-455d-aedc-076bb199d064"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "Coffees", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6637), 2, "Rerum rerum a dolor.", true, new Guid("dd01e3d8-bc20-44eb-91ac-36be05812039"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "Teas", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6655), 2, "Reprehenderit quo eveniet sint cumque eius dicta.", true, new Guid("cd4b51ed-3139-4e22-9951-56bb3c917c04"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "Salads", "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 79, DateTimeKind.Local).AddTicks(6678), 2, "Nisi qui ullam animi similique delectus similique et deserunt.", true, new Guid("8b47ce8c-bc6f-4522-b6d2-46d13a6ab21f"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "ID", "AppUserId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "DiscountID", "IsActive", "MasterId", "OrderDate", "Status", "TotalAmount", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[] { 1, null, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 86, DateTimeKind.Local).AddTicks(3146), 2, null, true, new Guid("22d6baa2-74eb-41b4-a01a-3427cbaef26d"), new DateTime(2024, 7, 20, 18, 3, 3, 86, DateTimeKind.Local).AddTicks(3193), 0, 100.00m, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "DataSize", "Discontinued", "Discount", "ImagePath", "IsActive", "IsDiscontinued", "MasterId", "Price", "ProductName", "ProductStatus", "Status", "Stock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, 1, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(7862), 2, 0, null, 0.029999999999999999, "https://picsum.photos/640/480/?image=883", true, false, new Guid("e90e59b0-29c9-4fe0-8f8e-2fde6c5d18cb"), 213.79m, "Coffee Soda", 0, 0, (short)56, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 4, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8119), 2, 0, null, 0.14000000000000001, "https://picsum.photos/640/480/?image=429", true, false, new Guid("206e5f84-3301-428a-8a71-99dd2c0d5141"), 72.52m, "Macchiato", 0, 0, (short)9, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 9, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8135), 2, 0, null, 0.040000000000000001, "https://picsum.photos/640/480/?image=1056", true, false, new Guid("a87ee31a-95f2-48cf-ac73-837c99309750"), 720.50m, "Americano", 0, 0, (short)20, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 7, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8147), 2, 0, null, 0.070000000000000007, "https://picsum.photos/640/480/?image=849", true, false, new Guid("d575756a-cc5d-4279-9785-43281fa1e495"), 155.76m, "Frappé", 0, 0, (short)89, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 3, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8156), 2, 0, null, 0.17000000000000001, "https://picsum.photos/640/480/?image=1010", true, false, new Guid("78f22eb1-fdf8-4bc7-b7a7-14a77bb5bc62"), 879.26m, "Coffee Martini", 0, 0, (short)79, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 10, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8166), 2, 0, null, 0.01, "https://picsum.photos/640/480/?image=570", true, false, new Guid("7d31fba4-4f2f-4ae8-a75b-7f6f9b3d7e8a"), 524.63m, "Tiramisu", 0, 0, (short)16, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 2, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8176), 2, 0, null, 0.14000000000000001, "https://picsum.photos/640/480/?image=638", true, false, new Guid("f8bacd30-d36e-4961-bdd9-1f3dc289125e"), 742.61m, "Trifle", 0, 0, (short)40, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 2, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8184), 2, 0, null, 0.059999999999999998, "https://picsum.photos/640/480/?image=169", true, false, new Guid("6db94e90-0c8b-450e-a072-99c3d7b8d16a"), 858.16m, "Cheesecake", 0, 0, (short)5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 6, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8193), 2, 0, null, 0.17000000000000001, "https://picsum.photos/640/480/?image=698", true, false, new Guid("52b8b81e-1b28-4653-8f57-ddcbff7801de"), 11.90m, "Cheesecake", 0, 0, (short)31, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 1, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8206), 2, 0, null, 0.14999999999999999, "https://picsum.photos/640/480/?image=861", true, false, new Guid("84934e95-8eee-40d2-9c33-60c3b1779dc9"), 814.74m, "Fruit Salad", 0, 0, (short)48, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 3, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8243), 2, 0, null, 0.34000000000000002, "https://picsum.photos/640/480/?image=905", true, false, new Guid("f5044f38-a1ca-47df-9584-4051b98246ab"), 498.07m, "Brownie", 0, 0, (short)70, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 4, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8253), 2, 0, null, 0.40000000000000002, "https://picsum.photos/640/480/?image=314", true, false, new Guid("0e4546ea-ac16-45fc-835c-a13e2579d7d4"), 759.29m, "Brownie", 0, 0, (short)5, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 7, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8262), 2, 0, null, 0.31, "https://picsum.photos/640/480/?image=1006", true, false, new Guid("6972aaa0-ea22-4db9-aeff-00e15992532e"), 535.98m, "Americano", 0, 0, (short)54, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 1, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8271), 2, 0, null, 0.02, "https://picsum.photos/640/480/?image=231", true, false, new Guid("b1dccabe-081d-43a3-a839-5eda889e4477"), 33.61m, "Turkish Coffee", 0, 0, (short)74, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 10, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8280), 2, 0, null, 0.17000000000000001, "https://picsum.photos/640/480/?image=173", true, false, new Guid("71f5f8d2-2343-4bc4-a644-5b70cb349275"), 73.90m, "Macaron", 0, 0, (short)33, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 7, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8290), 2, 0, null, 0.32000000000000001, "https://picsum.photos/640/480/?image=53", true, false, new Guid("8b8d0271-8eda-44d8-ad96-421a52afff58"), 66.18m, "Cold Brew", 0, 0, (short)34, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 1, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8299), 2, 0, null, 0.11, "https://picsum.photos/640/480/?image=658", true, false, new Guid("97f50c13-9a92-4d0b-bafb-5d21ec822a4b"), 95.56m, "Cake", 0, 0, (short)78, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 2, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8311), 2, 0, null, 0.45000000000000001, "https://picsum.photos/640/480/?image=605", true, false, new Guid("f9d7a168-cf9a-436d-839d-ed7d74b73914"), 464.55m, "Trifle", 0, 0, (short)10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 6, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8320), 2, 0, null, 0.27000000000000002, "https://picsum.photos/640/480/?image=926", true, false, new Guid("aa2a5596-7685-4c64-8a72-450f3cba9cfd"), 408.73m, "Cold Brew", 0, 0, (short)75, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 10, "LAPTOP-7RVI861P", new DateTime(2024, 7, 20, 18, 3, 3, 81, DateTimeKind.Local).AddTicks(8329), 2, 0, null, 0.070000000000000007, "https://picsum.photos/640/480/?image=142", true, false, new Guid("4747dbb1-69fa-4c75-97a2-e03a29db1700"), 800.44m, "Cappuccino", 0, 0, (short)73, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

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
