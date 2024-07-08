using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initialseeddata : Migration
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("01d61052-8e67-75b9-1e76-772d32943196"), 0, "4093 Mekhi Trail, Port Mikayla, India", new DateTime(1985, 5, 29, 16, 34, 36, 303, DateTimeKind.Local).AddTicks(7782), "da6a2a23-a677-4761-bd74-f2833d9f612e", "lucie5195@yahoo.com", false, 1, false, null, null, null, "HrCdqZMV", "360.467.0887 x966", false, null, false, "Ezra_Hagenes29" },
                    { new Guid("0590e6f2-4d8b-69f8-1d92-1c3e02234bcf"), 0, "9973 Corwin Turnpike, East Ruthieshire, Nauru", new DateTime(1993, 4, 23, 13, 9, 18, 70, DateTimeKind.Local).AddTicks(5110), "75c77bf5-4fb1-4096-9e5f-73004f468312", "annetta.borer.abshire@yahoo.com", false, 1, false, null, null, null, "JJ2GV6bE", "1-870-761-7584 x8690", false, null, false, "Myles.Bernier12" },
                    { new Guid("07237204-83cb-8003-266e-6dd98bf14a16"), 0, "75741 Martina Manor, West Elwinberg, Peru", new DateTime(1994, 11, 29, 13, 40, 22, 283, DateTimeKind.Local).AddTicks(3798), "300e3348-7f18-4cfd-9a86-8188aa9fec74", "monserrate.schmitt67_brown@hotmail.com", false, 0, false, null, null, null, "5RlpDlIS", "522.575.6803 x91629", false, null, false, "Ansley.Stehr" },
                    { new Guid("07359ec6-db15-a7df-51bf-d35292e0d375"), 0, "9948 Henderson Mission, Borerview, Afghanistan", new DateTime(1989, 5, 1, 3, 25, 12, 834, DateTimeKind.Local).AddTicks(5073), "182d2c9e-4b22-4d73-b0b8-2321718b168b", "molly_jast6034@gmail.com", false, 2, false, null, null, null, "Ce0dt5ag", "327.269.8898 x13182", false, null, false, "Jacynthe.Thompson79" },
                    { new Guid("2300e3dd-ac90-3fab-4745-10d111cab204"), 0, "9633 Stanton Creek, East Rozella, Monaco", new DateTime(1977, 9, 17, 5, 12, 23, 645, DateTimeKind.Local).AddTicks(1587), "a147db0c-e60f-4873-8e42-c28b61ee2778", "georgette.lehner2.turner@hotmail.com", false, 2, false, null, null, null, "WxNlxDXf", "(270) 409-8076 x27120", false, null, false, "Tremaine_Rice" },
                    { new Guid("266a0c0d-9bd3-6bea-78a6-f93236514d4a"), 0, "62610 Ebert Prairie, Leannhaven, Singapore", new DateTime(1993, 1, 31, 18, 35, 4, 567, DateTimeKind.Local).AddTicks(4802), "eb0866ce-e834-4b3a-8505-9b3f6968c812", "kendall.jones.hessel85@hotmail.com", false, 0, false, null, null, null, "SHQcOzan", "(342) 834-9200 x71232", false, null, false, "Lupe51" },
                    { new Guid("3c96ecb8-a968-875b-9f95-f25d12292bf6"), 0, "873 Bergstrom Ranch, Lake Rae, Heard Island and McDonald Islands", new DateTime(2002, 4, 16, 17, 7, 12, 324, DateTimeKind.Local).AddTicks(102), "4fe25c47-2f33-48ba-a7f8-20a4be3b0f5b", "christa_lesch8753@gmail.com", false, 1, false, null, null, null, "2gT8_14e", "(516) 434-6712 x7817", false, null, false, "Fredrick_Gottlieb24" },
                    { new Guid("4640ea55-e84d-122f-efd4-f1f334ca1bdf"), 0, "1466 Tromp Causeway, South Adan, Samoa", new DateTime(1992, 8, 13, 7, 58, 53, 930, DateTimeKind.Local).AddTicks(8847), "845b93ce-c58c-42c0-8a78-83f12b22bade", "rick_rice98_spencer@hotmail.com", false, 0, false, null, null, null, "DmiJ6l71", "(881) 758-3926 x37101", false, null, false, "Julia.Barrows3" },
                    { new Guid("47edc48e-324e-f7f7-7b76-1128a6c95f73"), 0, "58393 Gislason Drive, Loufurt, Dominica", new DateTime(1982, 12, 23, 5, 43, 37, 349, DateTimeKind.Local).AddTicks(9945), "c8a9c8b6-e211-4929-82c1-2354a8c6662c", "mariano_nienow9579@yahoo.com", false, 1, false, null, null, null, "c3BfTGDh", "(994) 272-8268 x279", false, null, false, "Toney_Towne78" },
                    { new Guid("4b8e6c00-a478-842c-bc81-1d25114a0505"), 0, "0374 Mills Skyway, Bruenberg, Bahamas", new DateTime(2003, 10, 14, 3, 13, 20, 843, DateTimeKind.Local).AddTicks(1851), "5dd83f1e-7b84-4935-a290-972431ac69ef", "jazmin1258@hotmail.com", false, 2, false, null, null, null, "xaj7yILe", "719.920.7158", false, null, false, "Raul39" },
                    { new Guid("51a458ad-4774-1bc6-5e47-028d03cdfc7c"), 0, "9017 Evie Estate, East Melvin, British Indian Ocean Territory (Chagos Archipelago)", new DateTime(1986, 4, 24, 1, 22, 27, 294, DateTimeKind.Local).AddTicks(340), "8c628f8a-9c78-41b4-bdf2-7bcc71e1b78e", "mattie48_gusikowski11@yahoo.com", false, 0, false, null, null, null, "vraZSpy_", "1-909-918-9807 x6498", false, null, false, "Jacynthe.Goldner82" },
                    { new Guid("852cb390-d0b6-7b5e-d5e1-0e0330a512b0"), 0, "3650 Ally Valley, Lake Alverta, Denmark", new DateTime(1977, 11, 28, 19, 22, 45, 492, DateTimeKind.Local).AddTicks(1874), "85febbd2-f4d8-43fd-b607-3f8377e382dd", "dejuan_oconner.romaguera@hotmail.com", false, 2, false, null, null, null, "axCyivHz", "641-386-8352 x8032", false, null, false, "Amir_Leuschke" },
                    { new Guid("ac3e9e8d-07b8-2234-50bb-136c027c4688"), 0, "271 Francesca Crossroad, New Rosalynburgh, Malaysia", new DateTime(1994, 8, 26, 1, 58, 37, 254, DateTimeKind.Local).AddTicks(7752), "8db7a83a-e797-4687-9514-ab067339c5ef", "vada33.nienow@gmail.com", false, 1, false, null, null, null, "akYSqsIh", "1-727-979-7831", false, null, false, "Naomie31" },
                    { new Guid("c330809c-e1f8-ac1e-5f89-250c26773272"), 0, "61365 Rutherford Tunnel, Whitneyshire, Barbados", new DateTime(1997, 4, 3, 7, 22, 5, 675, DateTimeKind.Local).AddTicks(8464), "318cbc91-9fe6-4329-8f45-74fb971549ab", "lurline_beer87.robel4@gmail.com", false, 2, false, null, null, null, "SgtQdbIz", "720-611-1165 x0008", false, null, false, "Justice_Kling69" },
                    { new Guid("e0810408-df9e-aeff-1a4e-bb7a297a305d"), 0, "073 Caden Neck, Hillsmouth, Italy", new DateTime(2001, 2, 10, 6, 4, 48, 132, DateTimeKind.Local).AddTicks(6494), "3b8ff311-6bad-4b84-9711-2912e9549261", "june122@gmail.com", false, 0, false, null, null, null, "8_dJjHKS", "362.760.1033 x16788", false, null, false, "Braxton.Mayert" },
                    { new Guid("e82072f5-6535-9e24-aa62-b66e9e9d7e6d"), 0, "4957 Hillard Harbor, Roweport, Marshall Islands", new DateTime(1991, 7, 31, 20, 27, 55, 601, DateTimeKind.Local).AddTicks(5620), "725d9a71-0336-412f-b171-9aec170fc5c5", "orrin_abernathy_kuvalis77@hotmail.com", false, 1, false, null, null, null, "xDddDJa1", "776.652.5768 x53747", false, null, false, "Bobbie43" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Description", "IsActive", "MasterId", "Status", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, "Chocolates", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8473), 2, "Perspiciatis enim voluptatibus est in.", true, new Guid("c8fa42ad-d88a-4592-9bcd-6ecc0b38d234"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "Snacks", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8757), 2, "Sunt blanditiis enim ut adipisci enim.", true, new Guid("c409ac6b-f394-4290-b5ac-aaaea90e861b"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "Teas", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8791), 2, "Laboriosam harum voluptas qui ad quia sunt et quo.", true, new Guid("0686e84c-4ae5-4cd3-bbcb-b30aeab5ac9f"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, "Snacks", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8824), 2, "Voluptatum ducimus ducimus qui nobis quaerat consequatur consequatur.", true, new Guid("89251b88-b54d-4998-9bec-6ee4116d7733"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, "Cakes", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8848), 2, "Voluptates itaque quidem incidunt officia.", true, new Guid("ad0bebae-6b3d-4ad1-b6d7-3909142afcf5"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, "Chocolates", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8874), 2, "Pariatur dignissimos sint velit libero.", true, new Guid("726c143c-dc55-4ec1-8c5f-4b21fd6ca556"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, "Cakes", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8896), 2, "Exercitationem ducimus enim nam et placeat rerum dolor nisi.", true, new Guid("2870b168-41a9-4350-afe0-2495b2888f43"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, "Ice Creams", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8921), 2, "Eligendi molestiae in neque dolorem commodi enim dolor nemo ab.", true, new Guid("d67750b6-91c1-4906-a240-6fa58ed9d482"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, "Snacks", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8963), 2, "İtaque nam at expedita nam est facilis eos.", true, new Guid("790dfeae-18f7-4e69-8e22-afe99c2f79d5"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, "Salads", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8986), 2, "Commodi neque impedit.", true, new Guid("85acc24a-6abd-4c3a-a4f3-297c9cd38006"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, "Cakes", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(8997), 2, "Omnis nesciunt molestias eaque veritatis.", true, new Guid("0e1802f7-162f-45e1-8326-fcb1f4e146ab"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, "Cakes", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(9012), 2, "Ea magni vitae.", true, new Guid("62563b3a-809c-4f88-9022-6465479e1f2d"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, "Coffees", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(9026), 2, "İn pariatur qui ut blanditiis quis qui.", true, new Guid("b9251af1-9ea4-4c84-923e-bbd2cac1593d"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, "Chocolates", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(9048), 2, "Deserunt architecto est sed itaque ab.", true, new Guid("f5566bba-d6d5-4292-ab0a-27f9cf06c00b"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, "Fruit Juices", "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 408, DateTimeKind.Local).AddTicks(9071), 2, "Voluptatem tenetur placeat.", true, new Guid("148d7926-1974-4a53-ac6f-26cdff427ecd"), 0, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ID", "CategoryId", "CreatedComputerName", "CreatedDate", "CreatedIpAddress", "Discount", "ImagePath", "IsActive", "MasterId", "Price", "ProductName", "Status", "Stock", "UpdatedComputerName", "UpdatedDate", "UpdatedIpAddress" },
                values: new object[,]
                {
                    { 1, 3, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1453), 2, 0.23000000000000001, "https://picsum.photos/640/480/?image=430", true, new Guid("4a62a451-f172-4ed9-a97a-bb8aeb7da687"), 836.55m, "Flat White", 0, (short)32, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, 6, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1671), 2, 0.040000000000000001, "https://picsum.photos/640/480/?image=55", true, new Guid("cad0f091-0423-4a5d-836b-323431912464"), 808.72m, "Éclair", 0, (short)58, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, 3, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1685), 2, 0.27000000000000002, "https://picsum.photos/640/480/?image=995", true, new Guid("97c1332f-8173-447a-be16-0a9b8ea1bc3d"), 602.88m, "Waffle", 0, (short)85, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 4, 4, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1695), 2, 0.02, "https://picsum.photos/640/480/?image=124", true, new Guid("5ab62479-28e1-4a52-b251-aeb8a3f925d8"), 600.71m, "Waffle", 0, (short)67, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 5, 7, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1706), 2, 0.029999999999999999, "https://picsum.photos/640/480/?image=678", true, new Guid("924f6d77-cf60-4571-8e7e-84bb65e7dcf8"), 408.06m, "Pie", 0, (short)41, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 6, 2, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1717), 2, 0.45000000000000001, "https://picsum.photos/640/480/?image=966", true, new Guid("6f49aae1-21c1-4137-b3b0-aafd8288fa1f"), 411.87m, "Éclair", 0, (short)56, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 7, 3, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1727), 2, 0.02, "https://picsum.photos/640/480/?image=180", true, new Guid("50377e54-f2be-4256-b5e9-aec2ea3972a8"), 789.61m, "Mocha", 0, (short)43, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 8, 10, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1736), 2, 0.22, "https://picsum.photos/640/480/?image=620", true, new Guid("8bd355c3-0a0a-4a3b-b14f-a6d619721dc1"), 61.82m, "Coffee Martini", 0, (short)50, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 9, 10, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1746), 2, 0.40000000000000002, "https://picsum.photos/640/480/?image=927", true, new Guid("1066ffc0-ad60-47ce-a23b-785aa364218d"), 167.84m, "Cold Brew", 0, (short)12, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 10, 4, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1759), 2, 0.20999999999999999, "https://picsum.photos/640/480/?image=286", true, new Guid("bb4cf628-bf91-461e-a0c9-6e44efe18a2e"), 686.38m, "Cupcake", 0, (short)25, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 11, 4, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1769), 2, 0.46000000000000002, "https://picsum.photos/640/480/?image=1051", true, new Guid("aa6713d0-162d-4dc4-87dd-b7736832b73a"), 2.03m, "Profiterole", 0, (short)11, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 12, 6, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1784), 2, 0.089999999999999997, "https://picsum.photos/640/480/?image=1043", true, new Guid("9e329c3f-a8fb-49c0-bbb8-02e417ef1b9f"), 874.00m, "Pudding", 0, (short)47, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 13, 2, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1794), 2, 0.32000000000000001, "https://picsum.photos/640/480/?image=681", true, new Guid("a5904ec0-2a91-4726-9538-41f7e98b7231"), 396.59m, "Coffee Soda", 0, (short)59, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 14, 10, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1802), 2, 0.20000000000000001, "https://picsum.photos/640/480/?image=437", true, new Guid("1270d0d4-3473-4e4e-9ea0-613aff4b317a"), 611.26m, "Pie", 0, (short)52, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 15, 3, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1811), 2, 0.25, "https://picsum.photos/640/480/?image=950", true, new Guid("f589dfe0-3f83-4d74-8cc6-e8054da4a2c7"), 904.67m, "Iced Coffee", 0, (short)94, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 16, 2, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1820), 2, 0.23000000000000001, "https://picsum.photos/640/480/?image=244", true, new Guid("7ab7069b-565a-4ec9-8830-ce9b72ccf1e6"), 577.80m, "Ice Cream", 0, (short)10, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 17, 9, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1829), 2, 0.45000000000000001, "https://picsum.photos/640/480/?image=288", true, new Guid("2d7a7a34-b4b7-41d3-b5e3-259d38f8b3ed"), 377.41m, "Iced Coffee", 0, (short)38, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 18, 4, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1842), 2, 0.20999999999999999, "https://picsum.photos/640/480/?image=381", true, new Guid("036fdf3f-1187-44cf-9f9b-e5f3f6bb5a27"), 842.76m, "Iced Coffee", 0, (short)47, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 19, 3, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1851), 2, 0.38, "https://picsum.photos/640/480/?image=485", true, new Guid("67f46ed6-acb2-4baa-8769-1f6a0841e7bf"), 163.41m, "Tiramisu", 0, (short)69, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 20, 8, "LAPTOP-7RVI861P", new DateTime(2024, 7, 5, 17, 7, 24, 410, DateTimeKind.Local).AddTicks(1861), 2, 0.39000000000000001, "https://picsum.photos/640/480/?image=825", true, new Guid("5b11db43-7a38-4954-9b89-97e1ba2573f2"), 281.47m, "Pie", 0, (short)50, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
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
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
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
                name: "Products");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
