using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class productst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0b55b5bf-cf31-290b-e607-f2d826b36524"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("23fdc4bb-a78c-e76c-b94b-2d11e81e25dd"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("28aa96c6-b5ab-2281-2d6b-ffda8118cbd4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("34b8baeb-90d2-65a5-9f7d-b8d51c32e598"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("402db502-0d0f-1060-a518-b2a38ca8284f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("447c85c8-7675-ed79-b7ce-3644d48868bf"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("53816cb6-227a-0e0e-8c47-d4c07db1c6fe"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("65e42b15-67a6-eacd-4ecd-8fe4bfb95423"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("76c1d0ed-7b9c-ddd0-1408-9823e6a97f13"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d4b8c15-fa37-4857-fb3b-24061248a06a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b4f40006-7b22-d36b-0340-b6379a2cda07"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bcc36900-cbcc-33d9-56ba-b14f3b3998ad"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c1add858-9f99-d4fb-ed7c-444ff682b0be"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("c1f6a2fe-7b6f-dd8f-5c89-c9ce688ac94f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("ca1e4265-3b1e-e976-8d64-9d41a598f40a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f573315c-2886-ed76-26dd-ead324af36a0"));

            migrationBuilder.DropColumn(
                name: "ProductStatus",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0d3b6889-fb92-6c61-75f2-6cfca1638992"), 0, "04528 Torp Lodge, Port Lilla, Falkland Islands (Malvinas)", new DateTime(2001, 2, 18, 20, 29, 8, 911, DateTimeKind.Local).AddTicks(6626), "42bcbeda-d1ef-421b-b6c1-1fd7cd5c88d3", "geovany54_koss@hotmail.com", false, 0, false, null, null, null, "6gM2eWXg", "750.642.2776 x88633", false, null, false, "Shea.Murazik" },
                    { new Guid("0fe0f671-e3fb-37f2-5d0c-55ad7d39500a"), 0, "226 Monte Hill, Port Stephen, Swaziland", new DateTime(2005, 9, 29, 22, 2, 18, 525, DateTimeKind.Local).AddTicks(8746), "569be9e3-5169-4667-86b7-32ad7782ddec", "keira.fisher55_bradtke19@gmail.com", false, 0, false, null, null, null, "sCdu92KE", "(363) 824-0815 x2036", false, null, false, "Magdalen.Olson" },
                    { new Guid("188b9678-f1f2-e805-3723-7a6379846bd5"), 0, "797 Carlotta Ville, Port Gudrun, Burkina Faso", new DateTime(1977, 4, 20, 2, 7, 41, 819, DateTimeKind.Local).AddTicks(3362), "c22fc1fb-7614-4416-a907-683633cb250e", "eldridge.sawayn3943@hotmail.com", false, 1, false, null, null, null, "WUFbGg_w", "442.314.0169", false, null, false, "Itzel84" },
                    { new Guid("1edc633a-eb58-0460-93f2-469721327248"), 0, "23898 Claudine Highway, Keeblerville, Anguilla", new DateTime(1984, 12, 11, 10, 35, 7, 747, DateTimeKind.Local).AddTicks(7179), "2227235c-7732-4dc3-adab-1f43b90931fc", "ramiro36.russel27@yahoo.com", false, 2, false, null, null, null, "dybHvRbK", "(659) 333-8111 x37632", false, null, false, "Lauriane79" },
                    { new Guid("2c7f94c0-5269-da7d-8b15-25aed81b4828"), 0, "0231 Gusikowski Islands, Volkmanstad, Fiji", new DateTime(1989, 7, 28, 20, 10, 8, 93, DateTimeKind.Local).AddTicks(9169), "1a41d752-39d4-4dc7-880e-cc5eba90206f", "benton.hegmann8.connelly@gmail.com", false, 0, false, null, null, null, "qj35wSfC", "1-576-382-0259 x1836", false, null, false, "Sasha60" },
                    { new Guid("32952328-a625-0058-c459-efa52e7579fc"), 0, "66185 Quitzon Islands, Boscofort, Kyrgyz Republic", new DateTime(1989, 11, 26, 10, 7, 18, 649, DateTimeKind.Local).AddTicks(7629), "8a078b45-d7b4-4dc3-8589-e87985384682", "orion_rowe.cremin@gmail.com", false, 0, false, null, null, null, "UbAspWCD", "204.515.4529 x96604", false, null, false, "Randy.Bechtelar4" },
                    { new Guid("65fe9d12-046c-8c7d-81ab-98f5fef85920"), 0, "60613 Auer Extension, Maxieview, Vietnam", new DateTime(2003, 5, 25, 4, 24, 2, 675, DateTimeKind.Local).AddTicks(5087), "a8b2afc1-f148-44f4-bd87-53d2f486754a", "ferne_feeney10_pouros34@hotmail.com", false, 1, false, null, null, null, "g3y49Zt1", "1-505-346-0520 x60065", false, null, false, "Reynold88" },
                    { new Guid("819e64b4-6891-08bd-4780-ca13eef3f19d"), 0, "3428 Thiel Lights, Port Ebonyport, Reunion", new DateTime(1980, 1, 15, 6, 15, 38, 477, DateTimeKind.Local).AddTicks(2743), "39419cf5-f3eb-440d-9d31-e20c1efb69e5", "lenora_legros.emard@gmail.com", false, 2, false, null, null, null, "Z3GxzGQd", "(641) 465-6613 x3068", false, null, false, "Sierra.Trantow" },
                    { new Guid("8542967a-fe58-9bdb-da0d-ce62b5bb6b9e"), 0, "038 Antonio Grove, Watersborough, Saint Vincent and the Grenadines", new DateTime(1990, 11, 14, 0, 24, 21, 734, DateTimeKind.Local).AddTicks(64), "5f6c553b-a338-46ed-98e5-3253bdbc7024", "seamus.cassin7270@gmail.com", false, 1, false, null, null, null, "eNJpH81o", "526-208-9622 x53494", false, null, false, "Monica_Smitham97" },
                    { new Guid("8d420207-2656-00f5-4685-b1a8497678a1"), 0, "81450 Ratke Island, Lake Devin, Senegal", new DateTime(1977, 9, 9, 19, 42, 39, 209, DateTimeKind.Local).AddTicks(404), "a45136e7-9ccb-482a-b1cd-eb321fb6eeab", "cleta.hansen2.schumm@yahoo.com", false, 2, false, null, null, null, "C2oGbRt9", "480.855.9266 x6371", false, null, false, "Wilfredo.Brekke" },
                    { new Guid("99673ac9-226b-adb3-eae0-00aa70fe1d52"), 0, "459 Justen Shoals, East Harrison, Italy", new DateTime(1987, 7, 22, 15, 0, 32, 942, DateTimeKind.Local).AddTicks(173), "6e285fa2-6167-4409-b06b-17cd6d93f36d", "lew.deckow13@hotmail.com", false, 2, false, null, null, null, "0Eh8pw4w", "1-783-936-8645 x5557", false, null, false, "Mellie48" },
                    { new Guid("a861cd8c-6f4d-0271-90e0-f4d3630f4638"), 0, "176 McCullough Shore, New Rupert, Kiribati", new DateTime(1980, 12, 18, 0, 52, 0, 682, DateTimeKind.Local).AddTicks(6678), "21061545-678a-42ba-a4d7-b70d3928b030", "linnie0.murray31@gmail.com", false, 0, false, null, null, null, "pB0DBwqI", "(412) 771-9724 x03736", false, null, false, "Alisha47" },
                    { new Guid("b1669005-104d-7088-efb1-9cd4848c0d2d"), 0, "598 Eloise Coves, Crystalfort, Denmark", new DateTime(1982, 9, 12, 16, 51, 15, 879, DateTimeKind.Local).AddTicks(6247), "7532cc6f-272b-423f-a33d-fda976067217", "aron.stoltenberg.shields11@yahoo.com", false, 1, false, null, null, null, "_dbHQ1Xm", "1-931-297-8016 x2654", false, null, false, "Carolyn_Wuckert" },
                    { new Guid("bbc727c4-e3f6-ea08-762e-4a664c0240b4"), 0, "36694 Romaguera Union, Taureanstad, Chile", new DateTime(1991, 7, 10, 3, 28, 4, 995, DateTimeKind.Local).AddTicks(1909), "c0c58c4e-ab35-47e4-8511-658aa926cd1b", "oswaldo_borer18.macgyver5@hotmail.com", false, 2, false, null, null, null, "KX0558ex", "451-998-6675", false, null, false, "Karl_Nader" },
                    { new Guid("d337cbe5-ee4b-ab0e-eaf8-fa16ff7d98f8"), 0, "479 Lowe Stream, Devantechester, Serbia", new DateTime(2006, 4, 12, 15, 34, 28, 881, DateTimeKind.Local).AddTicks(1710), "96b55799-3ce5-4f99-89be-f85d47ff70f8", "amos1435@gmail.com", false, 1, false, null, null, null, "kzsoQahs", "928.259.4112 x84584", false, null, false, "Micah14" },
                    { new Guid("df997d26-fd9b-9ed9-194c-d8c062494b18"), 0, "12548 Friesen Fork, Stuartville, Jamaica", new DateTime(1995, 6, 2, 20, 36, 38, 269, DateTimeKind.Local).AddTicks(6639), "36152f94-ba8d-45e9-8014-285115fc83b2", "demetris9297@hotmail.com", false, 0, false, null, null, null, "SmY8g3oh", "1-622-760-8298", false, null, false, "Clint63" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(3955), "Soluta magni expedita nisi asperiores voluptas ratione dolorem tempora possimus.", new Guid("d65ca312-a177-40a0-944d-b10c7efdb6f0") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Chocolates", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4261), "Qui occaecati laudantium praesentium rerum magnam.", new Guid("79b93f8c-a474-4bc6-a9c6-ce835142067a") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Coffees", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4321), "Officia ducimus maxime enim molestiae odit quia eos dolorem.", new Guid("abdd7b2a-cce7-4fd1-9c1c-b0b0c6d61251") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Cakes", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4357), "Perspiciatis eligendi eius hic unde consectetur et consequatur nobis hic.", new Guid("2d2ad7c4-6275-4902-950b-5918635b947a") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Coffees", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4394), "Modi minus quia recusandae eaque beatae.", new Guid("3c1f83a3-c9fb-442a-89bc-0591fdaef92f") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Snacks", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4425), "Asperiores totam autem sit numquam sequi tempora modi.", new Guid("cbd14d20-746c-4800-9fad-d93ac58a7db5") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Salads", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4454), "İd quaerat quis dicta quasi et est et.", new Guid("c07305df-af21-440c-9282-b352d0e0b14a") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Chocolates", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4484), "Quisquam aut sit dolor voluptatibus.", new Guid("92e15de4-0a52-4ca5-9b64-cbe0466f2aec") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Cakes", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4515), "Eos molestiae et saepe reiciendis totam.", new Guid("b35ca0d1-bee7-4394-8f37-999c8d22964b") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Salads", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4557), "Voluptas quis eos quidem.", new Guid("d1e2e5f4-cd47-41a8-b5d5-41d1ad08a936") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Fruit Juices", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4574), "Quia quis dolores qui velit culpa consequatur ducimus fugiat.", new Guid("82a33134-6602-4217-a081-6dd42b5355c8") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Snacks", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4601), "Quod amet quam nobis nemo.", new Guid("05e2a536-adf7-4d63-86d6-7ea59704b3c8") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4618), "Dignissimos qui quibusdam dolore quibusdam.", new Guid("9bdfb603-afec-485e-bbe5-70d0cb7fd9a5") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4636), "Unde quibusdam ab ab placeat.", new Guid("981e81b3-323f-40c3-8832-b15f73f32fc2") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Coffees", new DateTime(2024, 7, 26, 14, 43, 25, 943, DateTimeKind.Local).AddTicks(4653), "Vero quas suscipit.", new Guid("f3f945b4-4716-4827-8d0c-98652e390aeb") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate" },
                values: new object[] { new DateTime(2024, 7, 26, 14, 43, 25, 947, DateTimeKind.Local).AddTicks(6024), new Guid("fc9b5ed4-f1fc-4e6b-b87d-c8a91ae77628"), new DateTime(2024, 7, 26, 14, 43, 25, 947, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1594), 0.050000000000000003, "https://picsum.photos/640/480/?image=489", new Guid("c4d28997-2dc6-4961-ac05-5ed904d9e156"), 468.99m, "Coffee Milkshake", (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 9, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1835), 0.13, "https://picsum.photos/640/480/?image=468", new Guid("5e81041a-81ce-4f00-8c9c-dd436eabe2ea"), 556.23m, "Pudding", (short)2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 7, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1847), 0.41999999999999998, "https://picsum.photos/640/480/?image=413", new Guid("212f4853-8816-4086-9170-fa1164bc5138"), 985.68m, "Brownie", (short)94 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 1, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1879), 0.22, "https://picsum.photos/640/480/?image=857", new Guid("542b0a66-cdb5-425c-9684-8b489bcbed38"), 752.75m, "Muffin", (short)6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1888), 0.17000000000000001, "https://picsum.photos/640/480/?image=672", new Guid("3cf62775-733f-4bf9-b94e-ccbf81b8ade4"), 231.57m, "Coffee Milkshake", (short)98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 6, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1899), 0.33000000000000002, "https://picsum.photos/640/480/?image=472", new Guid("5b05f86a-adcb-4c4a-9d0a-589c5fa6ef32"), 112.60m, "Affogato", (short)14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 1, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1908), 0.070000000000000007, "https://picsum.photos/640/480/?image=678", new Guid("ee5d1e1e-8ccf-4272-8410-4c096429fe36"), 108.40m, "Macaron", (short)35 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1918), 0.080000000000000002, "https://picsum.photos/640/480/?image=283", new Guid("55f983b0-2a23-4c82-93b7-c27ad1197eba"), 23.99m, "Latte", (short)98 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 3, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1927), 0.23999999999999999, "https://picsum.photos/640/480/?image=545", new Guid("75eca608-bea8-4abd-87bf-566d81a94388"), 403.34m, "Cookie", (short)87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 7, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1939), 0.29999999999999999, "https://picsum.photos/640/480/?image=245", new Guid("b74b14e0-f632-4835-8d1f-4928632eac8a"), 569.61m, "Coffee Milkshake", (short)33 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 6, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1948), 0.25, "https://picsum.photos/640/480/?image=922", new Guid("b208cd22-6b5f-4b50-b6d3-34b89b13e4b9"), 300.24m, "Cupcake", (short)38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1957), 0.46999999999999997, "https://picsum.photos/640/480/?image=578", new Guid("db69c51a-e1ab-4ac4-9315-89c4e49b39f8"), 657.14m, "Trifle", (short)11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1965), 0.28999999999999998, "https://picsum.photos/640/480/?image=350", new Guid("497d89a8-71f8-4621-a184-042bdf805360"), 740.56m, "Espresso", (short)18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1974), 0.02, "https://picsum.photos/640/480/?image=546", new Guid("1f0fdc03-e975-482a-b774-0a91a44fe053"), 990.24m, "Ice Cream", (short)19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(1995), 0.28000000000000003, "https://picsum.photos/640/480/?image=675", new Guid("65a2cfed-26af-4940-b96d-c141933a13e7"), 913.37m, "Macchiato", (short)5 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(2005), 0.13, "https://picsum.photos/640/480/?image=215", new Guid("b09b0574-d605-4a9b-8f72-76de8a017f1d"), 512.09m, "Ice Cream", (short)25 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 7, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(2013), 0.20999999999999999, "https://picsum.photos/640/480/?image=937", new Guid("558176a5-307e-45ba-98be-395d0bf84492"), 931.47m, "Turkish Coffee", (short)11 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(2026), 0.26000000000000001, "https://picsum.photos/640/480/?image=30", new Guid("226c6a87-392f-4b22-8f82-95d33e25961a"), 519.13m, "Panna Cotta", (short)28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 9, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(2035), 0.40999999999999998, "https://picsum.photos/640/480/?image=978", new Guid("3136c887-837d-4011-9f0c-71e0a9c02d80"), 50.09m, "Fruit Salad", (short)65 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 3, new DateTime(2024, 7, 26, 14, 43, 25, 945, DateTimeKind.Local).AddTicks(2044), 0.040000000000000001, "https://picsum.photos/640/480/?image=874", new Guid("17ea1530-3aab-4c37-b98f-ac88ce6430e0"), 274.85m, "Brownie", (short)88 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0d3b6889-fb92-6c61-75f2-6cfca1638992"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0fe0f671-e3fb-37f2-5d0c-55ad7d39500a"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("188b9678-f1f2-e805-3723-7a6379846bd5"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("1edc633a-eb58-0460-93f2-469721327248"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c7f94c0-5269-da7d-8b15-25aed81b4828"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("32952328-a625-0058-c459-efa52e7579fc"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("65fe9d12-046c-8c7d-81ab-98f5fef85920"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("819e64b4-6891-08bd-4780-ca13eef3f19d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8542967a-fe58-9bdb-da0d-ce62b5bb6b9e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("8d420207-2656-00f5-4685-b1a8497678a1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("99673ac9-226b-adb3-eae0-00aa70fe1d52"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a861cd8c-6f4d-0271-90e0-f4d3630f4638"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b1669005-104d-7088-efb1-9cd4848c0d2d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("bbc727c4-e3f6-ea08-762e-4a664c0240b4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("d337cbe5-ee4b-ab0e-eaf8-fa16ff7d98f8"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("df997d26-fd9b-9ed9-194c-d8c062494b18"));

            migrationBuilder.AddColumn<int>(
                name: "ProductStatus",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0b55b5bf-cf31-290b-e607-f2d826b36524"), 0, "652 Eduardo Village, Waynestad, Bahamas", new DateTime(1989, 4, 4, 7, 22, 36, 14, DateTimeKind.Local).AddTicks(7165), "08149602-7e71-4a8b-b0fb-ba26d787a9b9", "leif.pfeffer7215@yahoo.com", false, 2, false, null, null, null, "FSHsNb7w", "1-539-557-7697 x3861", false, null, false, "Delbert.Cummings" },
                    { new Guid("23fdc4bb-a78c-e76c-b94b-2d11e81e25dd"), 0, "546 Altenwerth Ridge, Wilkinsonfurt, Western Sahara", new DateTime(1997, 9, 24, 15, 31, 41, 556, DateTimeKind.Local).AddTicks(5064), "c9ed4544-0aff-4162-98ea-b2ab10e3f549", "milan.connelly1675@hotmail.com", false, 2, false, null, null, null, "UtCk2z9k", "(360) 778-8835 x68589", false, null, false, "Kenneth.Swaniawski50" },
                    { new Guid("28aa96c6-b5ab-2281-2d6b-ffda8118cbd4"), 0, "27994 Crystel Manors, Port Kellen, Singapore", new DateTime(2005, 12, 28, 11, 56, 28, 885, DateTimeKind.Local).AddTicks(110), "fea15dae-b4cc-43b4-9917-8549efdb8275", "jeff1446@hotmail.com", false, 0, false, null, null, null, "ASqlisMf", "(274) 355-8955 x98081", false, null, false, "Gregg.Ziemann" },
                    { new Guid("34b8baeb-90d2-65a5-9f7d-b8d51c32e598"), 0, "56495 Quigley Springs, Lake Velmaview, New Caledonia", new DateTime(1996, 8, 2, 10, 2, 55, 779, DateTimeKind.Local).AddTicks(8378), "c1748e3e-8813-4ff5-84db-d1fdb8142f9b", "sheldon.toy_dicki1@yahoo.com", false, 0, false, null, null, null, "ai9BvwYU", "(839) 421-6979 x83487", false, null, false, "Rhianna_Cronin10" },
                    { new Guid("402db502-0d0f-1060-a518-b2a38ca8284f"), 0, "7829 Abelardo Course, Lake Andrewberg, Isle of Man", new DateTime(1977, 10, 17, 23, 0, 41, 161, DateTimeKind.Local).AddTicks(2813), "f49a453a-1833-4905-83a9-7b6f28e9f4a9", "yadira87.von@hotmail.com", false, 0, false, null, null, null, "o8SJkkb4", "747.630.9634 x2912", false, null, false, "America_Walter" },
                    { new Guid("447c85c8-7675-ed79-b7ce-3644d48868bf"), 0, "55249 Kessler Fork, Purdyton, Cyprus", new DateTime(1983, 3, 8, 10, 48, 57, 951, DateTimeKind.Local).AddTicks(9838), "217ceda8-d676-4789-86aa-cf0f88dbd32d", "ludie.white6.wisoky75@gmail.com", false, 2, false, null, null, null, "ellp6khw", "1-348-450-6034", false, null, false, "Domingo.Kunze" },
                    { new Guid("53816cb6-227a-0e0e-8c47-d4c07db1c6fe"), 0, "934 Junius Lake, Corwinville, Guernsey", new DateTime(1987, 12, 15, 5, 35, 0, 466, DateTimeKind.Local).AddTicks(3090), "ce07052c-84cd-48d8-bac4-dd76706752ad", "kendrick.thompson62.johnson@yahoo.com", false, 1, false, null, null, null, "GLUUjLP6", "339.499.9177", false, null, false, "Alexzander_Feil18" },
                    { new Guid("65e42b15-67a6-eacd-4ecd-8fe4bfb95423"), 0, "7303 Sandra Greens, West Kurtfurt, Republic of Korea", new DateTime(1992, 3, 2, 14, 37, 58, 338, DateTimeKind.Local).AddTicks(9849), "3ac7dcde-df4e-482a-ba97-ff6729ed978b", "hermina9541@hotmail.com", false, 2, false, null, null, null, "AIEwGaPQ", "(667) 862-3879 x50320", false, null, false, "Grace64" },
                    { new Guid("76c1d0ed-7b9c-ddd0-1408-9823e6a97f13"), 0, "121 Milan Fall, Port Karlie, Uganda", new DateTime(2000, 8, 11, 14, 51, 53, 136, DateTimeKind.Local).AddTicks(6531), "f196adf1-d2f4-4580-bf0d-454e4bee0f31", "chauncey.rippin5074@gmail.com", false, 0, false, null, null, null, "xuLb2ppg", "1-412-675-6182 x65252", false, null, false, "Cassidy49" },
                    { new Guid("8d4b8c15-fa37-4857-fb3b-24061248a06a"), 0, "849 Ariel Loaf, West Kole, Italy", new DateTime(2003, 9, 4, 3, 8, 9, 420, DateTimeKind.Local).AddTicks(2244), "adc5d860-7fff-4dc9-9db6-08202b4a8076", "jamar67.kunde24@gmail.com", false, 1, false, null, null, null, "S_ES0Q5o", "294-910-1926", false, null, false, "Elwin35" },
                    { new Guid("b4f40006-7b22-d36b-0340-b6379a2cda07"), 0, "269 McDermott Crossing, Port Orrinburgh, Mauritania", new DateTime(2002, 2, 4, 23, 41, 20, 653, DateTimeKind.Local).AddTicks(6487), "efb99988-e630-4545-9400-12dcc3d76838", "pamela7.oconner@hotmail.com", false, 1, false, null, null, null, "_3uKJ7uT", "1-437-831-0196 x22881", false, null, false, "Vella.Hickle" },
                    { new Guid("bcc36900-cbcc-33d9-56ba-b14f3b3998ad"), 0, "587 Ankunding Spring, South Gerryfort, Vietnam", new DateTime(1983, 3, 13, 15, 43, 3, 197, DateTimeKind.Local).AddTicks(2641), "934508d6-4e3b-4259-b2e5-15c7e6081fd4", "kyra.green45@yahoo.com", false, 0, false, null, null, null, "as8h6sSY", "(403) 499-1456", false, null, false, "Keven.Emmerich" },
                    { new Guid("c1add858-9f99-d4fb-ed7c-444ff682b0be"), 0, "8376 McLaughlin Prairie, South Ahmad, United States of America", new DateTime(1986, 11, 24, 1, 56, 50, 624, DateTimeKind.Local).AddTicks(7141), "b6276640-3b7d-48d1-abea-25bb10db0ff5", "cassie6085@gmail.com", false, 0, false, null, null, null, "SQLPzOKO", "(231) 382-6798 x49606", false, null, false, "Brody.Langosh28" },
                    { new Guid("c1f6a2fe-7b6f-dd8f-5c89-c9ce688ac94f"), 0, "73964 Benjamin Causeway, Koelpinchester, Cape Verde", new DateTime(2001, 1, 28, 20, 23, 8, 395, DateTimeKind.Local).AddTicks(1472), "751f8621-f8e8-46c9-b8ab-17c5d35e3888", "linda.nitzsche60@hotmail.com", false, 2, false, null, null, null, "OZeLneDE", "598-771-3342 x745", false, null, false, "Larry.Lynch26" },
                    { new Guid("ca1e4265-3b1e-e976-8d64-9d41a598f40a"), 0, "69611 Mallie Harbors, Lake Savionburgh, Macao", new DateTime(2000, 4, 14, 17, 45, 17, 389, DateTimeKind.Local).AddTicks(2309), "5eca1c5b-e4ec-4fb0-9b88-dd281be0ea50", "tyrique_douglas8_kessler@yahoo.com", false, 2, false, null, null, null, "nQm9xluJ", "680.387.3546 x3044", false, null, false, "Berry.Smitham81" },
                    { new Guid("f573315c-2886-ed76-26dd-ead324af36a0"), 0, "8856 Dewitt Light, South Hollie, United States of America", new DateTime(1998, 11, 17, 16, 12, 12, 431, DateTimeKind.Local).AddTicks(3513), "19db1057-11f6-43a3-980b-41d229df6aec", "chelsea.keeling_runolfsdottir38@yahoo.com", false, 0, false, null, null, null, "_wGojin5", "1-573-622-3888 x3568", false, null, false, "Kathryne_Stanton49" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(1447), "Magni nesciunt odio qui molestiae nesciunt eum omnis quae.", new Guid("a9d10cd7-c68b-49b5-8aba-382edfdc5861") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Sandwiches", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(1819), "Sint ut aut dignissimos provident.", new Guid("c3318e50-c77d-4acf-a644-9af0de5e8f76") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Ice Creams", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(1847), "Numquam enim ut delectus quia.", new Guid("5906cace-756d-4a79-94da-116bcfcfb98e") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Chocolates", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(1871), "Ut architecto aut.", new Guid("a90a117f-6558-4ca1-9a7b-313b6a4ed238") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Chocolates", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(1888), "İn rerum ipsa.", new Guid("f48a4817-2818-48f2-ad9b-cf2b24dad499") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Salads", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(1905), "Sequi et amet neque animi voluptatem.", new Guid("d61fee98-f9c4-4686-b6ad-f5773d19d694") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Chocolates", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(1929), "Dolor repudiandae facilis sunt nostrum id rerum nemo.", new Guid("973b7d6d-f4df-4276-8f15-1612ed24d4e7") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Fruit Juices", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(1961), "Enim consequatur ea eos at velit aperiam iste quas.", new Guid("0d4e757e-4110-4c07-830a-7c64b94dd533") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Fruit Juices", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(1993), "Et non debitis saepe tenetur deleniti.", new Guid("892a6c91-32f8-4be5-a284-c012dbeea673") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Chocolates", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(2028), "Dolorum accusantium velit velit ullam.", new Guid("6d94d2c6-47f3-4831-8910-877224e28947") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Teas", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(2075), "Asperiores nostrum quaerat.", new Guid("27db7d95-456a-4453-b08e-638ef95265bc") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Chocolates", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(2091), "Minima amet tempore maxime nulla sit natus et sed exercitationem.", new Guid("b2d0fd2f-6d8d-4e0b-8e9b-7a60aedc5a92") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(2121), "Occaecati aut dolore impedit aut laborum eum qui ullam.", new Guid("cc1924f5-6593-43b4-86dc-b6c494a11dd3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(2149), "Sint quis animi.", new Guid("095867cb-69a8-4fd7-a1c7-3aba115f979d") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Cakes", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(2164), "Doloremque quaerat doloribus veritatis saepe reprehenderit eligendi quisquam est.", new Guid("fc61ccd9-9067-4fa9-83da-7569e2eb8503") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 58, 1, 453, DateTimeKind.Local).AddTicks(7199), new Guid("cf8021e0-d358-4429-9df2-956f5641b6e1"), new DateTime(2024, 7, 22, 11, 58, 1, 453, DateTimeKind.Local).AddTicks(7230) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 7, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(7835), 0.47999999999999998, "https://picsum.photos/640/480/?image=922", new Guid("d426c01f-a929-4de1-aede-6f5b7bc6b90e"), 638.19m, "Cupcake", 0, (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8044), 0.02, "https://picsum.photos/640/480/?image=404", new Guid("57b97bfd-1dd8-4196-8ad5-3f5d5f9e0b4c"), 70.78m, "Turkish Coffee", 0, (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8062), 0.080000000000000002, "https://picsum.photos/640/480/?image=615", new Guid("d2446dc7-eb62-4369-ac54-53560ff00a85"), 925.64m, "Espresso", 0, (short)38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8103), 0.17000000000000001, "https://picsum.photos/640/480/?image=354", new Guid("35a30263-ed06-48d9-9c4d-7f3140405642"), 886.87m, "Tiramisu", 0, (short)19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8112), 0.35999999999999999, "https://picsum.photos/640/480/?image=166", new Guid("90dbb136-90ec-492c-90c7-de1b66cff30e"), 674.49m, "Cold Brew", 0, (short)2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8122), 0.080000000000000002, "https://picsum.photos/640/480/?image=1069", new Guid("7e344b08-0cbd-4905-be78-b924620ffbfb"), 976.16m, "Cheesecake", 0, (short)48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8130), 0.12, "https://picsum.photos/640/480/?image=824", new Guid("ba9b3348-573e-469b-b475-3a3a4fa6cafc"), 971.90m, "Cappuccino", 0, (short)58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8139), 0.13, "https://picsum.photos/640/480/?image=310", new Guid("e34bfec6-7d59-4c09-8862-b99f18a5bd1c"), 257.52m, "Mocha", 0, (short)18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8147), 0.42999999999999999, "https://picsum.photos/640/480/?image=928", new Guid("56eff728-9f27-49f8-9522-6bddd147b2a2"), 213.67m, "Brownie", 0, (short)16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 3, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8157), 0.33000000000000002, "https://picsum.photos/640/480/?image=463", new Guid("471c5bf7-d2e0-4135-a088-e79f4edfd8b8"), 657.78m, "Ice Cream", 0, (short)49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8168), 0.33000000000000002, "https://picsum.photos/640/480/?image=395", new Guid("94322016-3c18-4a7e-bc47-c1b8d22ad0ee"), 342.49m, "Coffee Soda", 0, (short)71 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 4, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8176), 0.47999999999999998, "https://picsum.photos/640/480/?image=155", new Guid("3d0216ed-b5aa-42c5-b39e-fecb24aa2d62"), 306.57m, "Pancake", 0, (short)91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8186), 0.42999999999999999, "https://picsum.photos/640/480/?image=775", new Guid("b36a5b4f-1ff6-40c2-9d81-6f47b53439e8"), 351.87m, "Chocolate Fondue", 0, (short)41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 7, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8194), 0.39000000000000001, "https://picsum.photos/640/480/?image=839", new Guid("64b07f13-1358-4f0b-baf3-0969834a3917"), 56.26m, "Donut", 0, (short)73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 8, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8224), 0.070000000000000007, "https://picsum.photos/640/480/?image=930", new Guid("881cffa5-b2a9-4587-93c0-1428d3b69f01"), 948.75m, "Coffee Milkshake", 0, (short)72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8233), 0.12, "https://picsum.photos/640/480/?image=773", new Guid("5579a13f-39cd-47b8-acac-2bc464ba484d"), 209.51m, "Macaron", 0, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 8, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8242), 0.02, "https://picsum.photos/640/480/?image=378", new Guid("2abf96ca-eab2-468f-a851-0ff4b9cecf01"), 805.03m, "Éclair", 0, (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8252), 0.48999999999999999, "https://picsum.photos/640/480/?image=262", new Guid("910bd2fa-9353-4fb2-8e86-761b8f68802e"), 954.81m, "Profiterole", 0, (short)36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8262), 0.12, "https://picsum.photos/640/480/?image=256", new Guid("b94227bf-ccd5-4170-958d-2b72c4749b66"), 254.48m, "Affogato", 0, (short)31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "ProductStatus", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8271), 0.44, "https://picsum.photos/640/480/?image=679", new Guid("780b263d-4966-4372-b202-e888a047ea84"), 856.49m, "Macaron", 0, (short)54 });
        }
    }
}
