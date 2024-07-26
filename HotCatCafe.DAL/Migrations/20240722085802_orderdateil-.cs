using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotCatCafe.DAL.Migrations
{
    /// <inheritdoc />
    public partial class orderdateil : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0249c268-5b31-3cfa-3428-b7491f53b314"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0bd1974a-f867-9b42-fd1e-8d655966c1d1"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("0e9b292f-b2ee-e055-40de-23f2fcdaa4a4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("11f9940a-519e-f64e-61d0-f5b51160df62"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("26d04ba5-ca75-371d-1b19-5fbc5f7a5d87"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2abdd852-84fc-62a4-b438-55474a1c7c90"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c942bdf-f5fc-b7b4-e70c-1c9ac0f0005e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("45723f44-600e-2498-8842-f0b6a28cbd99"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("5b910a51-8525-5deb-2bee-ee67ea4624ef"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a2250307-8ed9-13b0-4ed1-9b7f2fba9dd6"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("a29c5d95-60cf-5bb4-d263-f1d2275dbf0f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b42c0355-5fe3-c805-7e62-7dc643421d6d"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("b6db5c9b-6985-6be4-cf6d-f5cb05b09d00"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cfcd2d2d-ce41-f20e-6d5a-cf875da51612"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("efa59c22-b85f-34b1-1d8c-2ee0c10fa065"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("f24f6078-2fd4-e7b2-23f3-beff00d2e27a"));

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
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Ice Creams", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(1447), "Magni nesciunt odio qui molestiae nesciunt eum omnis quae.", new Guid("a9d10cd7-c68b-49b5-8aba-382edfdc5861") });

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
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Cakes", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(2121), "Occaecati aut dolore impedit aut laborum eum qui ullam.", new Guid("cc1924f5-6593-43b4-86dc-b6c494a11dd3") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Snacks", new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(2149), "Sint quis animi.", new Guid("095867cb-69a8-4fd7-a1c7-3aba115f979d") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 58, 1, 449, DateTimeKind.Local).AddTicks(2164), "Doloremque quaerat doloribus veritatis saepe reprehenderit eligendi quisquam est.", new Guid("fc61ccd9-9067-4fa9-83da-7569e2eb8503") });

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
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 7, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(7835), 0.47999999999999998, "https://picsum.photos/640/480/?image=922", new Guid("d426c01f-a929-4de1-aede-6f5b7bc6b90e"), 638.19m, "Cupcake", (short)10 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8044), 0.02, "https://picsum.photos/640/480/?image=404", new Guid("57b97bfd-1dd8-4196-8ad5-3f5d5f9e0b4c"), 70.78m, "Turkish Coffee", (short)42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8062), 0.080000000000000002, "https://picsum.photos/640/480/?image=615", new Guid("d2446dc7-eb62-4369-ac54-53560ff00a85"), 925.64m, "Espresso", (short)38 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8103), 0.17000000000000001, "https://picsum.photos/640/480/?image=354", new Guid("35a30263-ed06-48d9-9c4d-7f3140405642"), 886.87m, "Tiramisu", (short)19 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8112), 0.35999999999999999, "https://picsum.photos/640/480/?image=166", new Guid("90dbb136-90ec-492c-90c7-de1b66cff30e"), 674.49m, "Cold Brew", (short)2 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8122), 0.080000000000000002, "https://picsum.photos/640/480/?image=1069", new Guid("7e344b08-0cbd-4905-be78-b924620ffbfb"), 976.16m, "Cheesecake", (short)48 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8130), 0.12, "https://picsum.photos/640/480/?image=824", new Guid("ba9b3348-573e-469b-b475-3a3a4fa6cafc"), 971.90m, "Cappuccino", (short)58 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 1, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8139), 0.13, "https://picsum.photos/640/480/?image=310", new Guid("e34bfec6-7d59-4c09-8862-b99f18a5bd1c"), 257.52m, "Mocha", (short)18 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8147), 0.42999999999999999, "https://picsum.photos/640/480/?image=928", new Guid("56eff728-9f27-49f8-9522-6bddd147b2a2"), 213.67m, "Brownie", (short)16 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 3, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8157), 0.33000000000000002, "https://picsum.photos/640/480/?image=463", new Guid("471c5bf7-d2e0-4135-a088-e79f4edfd8b8"), 657.78m, "Ice Cream", (short)49 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8168), 0.33000000000000002, "https://picsum.photos/640/480/?image=395", new Guid("94322016-3c18-4a7e-bc47-c1b8d22ad0ee"), 342.49m, "Coffee Soda", (short)71 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 4, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8176), 0.47999999999999998, "https://picsum.photos/640/480/?image=155", new Guid("3d0216ed-b5aa-42c5-b39e-fecb24aa2d62"), 306.57m, "Pancake", (short)91 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 3, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8186), 0.42999999999999999, "https://picsum.photos/640/480/?image=775", new Guid("b36a5b4f-1ff6-40c2-9d81-6f47b53439e8"), 351.87m, "Chocolate Fondue", (short)41 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 7, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8194), 0.39000000000000001, "https://picsum.photos/640/480/?image=839", new Guid("64b07f13-1358-4f0b-baf3-0969834a3917"), 56.26m, "Donut", (short)73 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 8, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8224), 0.070000000000000007, "https://picsum.photos/640/480/?image=930", new Guid("881cffa5-b2a9-4587-93c0-1428d3b69f01"), 948.75m, "Coffee Milkshake", (short)72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8233), 0.12, "https://picsum.photos/640/480/?image=773", new Guid("5579a13f-39cd-47b8-acac-2bc464ba484d"), 209.51m, (short)80 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 8, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8242), 0.02, "https://picsum.photos/640/480/?image=378", new Guid("2abf96ca-eab2-468f-a851-0ff4b9cecf01"), 805.03m, "Éclair", (short)24 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8252), 0.48999999999999999, "https://picsum.photos/640/480/?image=262", new Guid("910bd2fa-9353-4fb2-8e86-761b8f68802e"), 954.81m, "Profiterole", (short)36 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8262), 0.12, "https://picsum.photos/640/480/?image=256", new Guid("b94227bf-ccd5-4170-958d-2b72c4749b66"), 254.48m, "Affogato", (short)31 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 22, 11, 58, 1, 450, DateTimeKind.Local).AddTicks(8271), 0.44, "https://picsum.photos/640/480/?image=679", new Guid("780b263d-4966-4372-b202-e888a047ea84"), 856.49m, "Macaron", (short)54 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("0249c268-5b31-3cfa-3428-b7491f53b314"), 0, "7392 Gleichner Club, Issacton, Norway", new DateTime(1980, 8, 5, 1, 45, 2, 327, DateTimeKind.Local).AddTicks(4300), "2c29e142-016e-460c-b422-dfb2e2b28ee8", "bettye_kshlerin93@yahoo.com", false, 2, false, null, null, null, "DVRoNmgt", "1-407-989-3385", false, null, false, "Herman_OKon" },
                    { new Guid("0bd1974a-f867-9b42-fd1e-8d655966c1d1"), 0, "79183 Casey Mill, Weissnatstad, Vietnam", new DateTime(1977, 3, 25, 13, 22, 53, 356, DateTimeKind.Local).AddTicks(4397), "784d6ef4-2469-4236-8d00-ba67bf0f336e", "lenore90_roob@gmail.com", false, 1, false, null, null, null, "feVFyGNj", "578-589-1104", false, null, false, "Cornelius.Jakubowski55" },
                    { new Guid("0e9b292f-b2ee-e055-40de-23f2fcdaa4a4"), 0, "69876 Javon Mountain, Port Virginia, Gabon", new DateTime(1997, 5, 19, 16, 42, 35, 294, DateTimeKind.Local).AddTicks(2465), "d54e239c-7acb-4c23-bae1-f6f9213e6153", "dina.maggio.baumbach@gmail.com", false, 2, false, null, null, null, "V0W1D6MN", "465.943.1997 x15805", false, null, false, "Eloy70" },
                    { new Guid("11f9940a-519e-f64e-61d0-f5b51160df62"), 0, "725 April Turnpike, South Sienna, Saint Lucia", new DateTime(2006, 1, 21, 20, 16, 44, 644, DateTimeKind.Local).AddTicks(1903), "96b7c811-bf3b-405e-b678-b71d7b4b4f79", "amalia.robel41_lockman@hotmail.com", false, 0, false, null, null, null, "NjLqfFGu", "1-525-609-2012", false, null, false, "Kenna.Cartwright30" },
                    { new Guid("26d04ba5-ca75-371d-1b19-5fbc5f7a5d87"), 0, "444 Gibson Square, New Anya, Gibraltar", new DateTime(1976, 11, 6, 21, 4, 38, 969, DateTimeKind.Local).AddTicks(7153), "a74b62aa-e7ff-4351-96b0-65a4319734b7", "nella8447@yahoo.com", false, 1, false, null, null, null, "8Fy_NQ2X", "900.912.3055 x82515", false, null, false, "Keenan.Gaylord35" },
                    { new Guid("2abdd852-84fc-62a4-b438-55474a1c7c90"), 0, "53287 Braulio Hollow, North Kevin, Algeria", new DateTime(2001, 5, 9, 8, 45, 40, 272, DateTimeKind.Local).AddTicks(4160), "b936302c-514f-4ddf-89c6-b3426da81ec6", "michele_kilback34.reinger60@gmail.com", false, 0, false, null, null, null, "Luuze__H", "688-637-5737", false, null, false, "Quinton_Pollich" },
                    { new Guid("2c942bdf-f5fc-b7b4-e70c-1c9ac0f0005e"), 0, "45096 Kailey Haven, Jedchester, Montserrat", new DateTime(1985, 8, 18, 2, 30, 10, 287, DateTimeKind.Local).AddTicks(4133), "46203ff3-6bd1-44ba-aba1-067fd1be26bd", "madyson.feil86.mclaughlin@yahoo.com", false, 2, false, null, null, null, "RPTHXGVH", "(364) 724-1377 x23157", false, null, false, "Minerva_Ledner4" },
                    { new Guid("45723f44-600e-2498-8842-f0b6a28cbd99"), 0, "696 Nienow Knoll, West Danielle, Equatorial Guinea", new DateTime(1980, 11, 9, 9, 6, 39, 312, DateTimeKind.Local).AddTicks(3220), "e5a71208-4d08-400f-8740-27cd3f7abb5f", "sammie_thiel92@yahoo.com", false, 1, false, null, null, null, "5jbVr3WP", "1-951-833-1005 x318", false, null, false, "Brice.Graham" },
                    { new Guid("5b910a51-8525-5deb-2bee-ee67ea4624ef"), 0, "340 Rachael Fork, Conroyland, Antigua and Barbuda", new DateTime(1984, 3, 4, 18, 18, 27, 499, DateTimeKind.Local).AddTicks(5922), "337a0769-76af-40ea-b584-a87f49711d67", "earlene38.tillman1@gmail.com", false, 2, false, null, null, null, "f3WyuD9O", "454-767-5266 x6772", false, null, false, "Humberto_Hand92" },
                    { new Guid("a2250307-8ed9-13b0-4ed1-9b7f2fba9dd6"), 0, "912 Murazik Common, Veronatown, Burkina Faso", new DateTime(1986, 8, 14, 21, 17, 49, 762, DateTimeKind.Local).AddTicks(3330), "00834414-c445-45e2-b19b-41dcdc775c5c", "charlene_damore26_hudson@gmail.com", false, 0, false, null, null, null, "5N9cLeFO", "1-634-403-7697 x05660", false, null, false, "Loma_Miller21" },
                    { new Guid("a29c5d95-60cf-5bb4-d263-f1d2275dbf0f"), 0, "18758 Bernier Highway, Millsfort, Trinidad and Tobago", new DateTime(1994, 11, 15, 14, 43, 39, 277, DateTimeKind.Local).AddTicks(4472), "57042b90-a597-43fe-9c86-255e5f18a664", "savion.kling68_tromp33@gmail.com", false, 0, false, null, null, null, "lz7CribO", "292.612.4416", false, null, false, "Janessa.Stroman" },
                    { new Guid("b42c0355-5fe3-c805-7e62-7dc643421d6d"), 0, "5533 Brooks Inlet, South Jennings, Saint Barthelemy", new DateTime(1976, 12, 3, 15, 32, 59, 429, DateTimeKind.Local).AddTicks(5407), "aabf083b-6c8d-43ad-a601-22ebef9392f7", "earl20_rath@hotmail.com", false, 0, false, null, null, null, "qGTPJha4", "671-396-1859 x5861", false, null, false, "Dejah_Yost81" },
                    { new Guid("b6db5c9b-6985-6be4-cf6d-f5cb05b09d00"), 0, "21314 Zemlak Stream, East Jordyton, Saint Barthelemy", new DateTime(1995, 12, 2, 10, 48, 6, 765, DateTimeKind.Local).AddTicks(5985), "95c2edda-1c59-44b0-9f85-4f57f85a980d", "eleanora39.wunsch39@hotmail.com", false, 2, false, null, null, null, "yc6fezdm", "521-232-9500 x8815", false, null, false, "Anahi.Yost" },
                    { new Guid("cfcd2d2d-ce41-f20e-6d5a-cf875da51612"), 0, "5619 Feil Shores, East Ellen, Cook Islands", new DateTime(1994, 11, 6, 23, 8, 0, 368, DateTimeKind.Local).AddTicks(9807), "d8643ce4-280b-4ff9-ac52-831dbcc5e0aa", "mariela62.grady33@gmail.com", false, 2, false, null, null, null, "K2dct4H3", "1-711-341-5171 x5334", false, null, false, "Rolando97" },
                    { new Guid("efa59c22-b85f-34b1-1d8c-2ee0c10fa065"), 0, "4081 Gibson Neck, Metzshire, Marshall Islands", new DateTime(1980, 3, 28, 11, 7, 22, 293, DateTimeKind.Local).AddTicks(9068), "717a5212-beed-4606-aca9-74c0926138fa", "hollis4648@gmail.com", false, 0, false, null, null, null, "k7zrsrsT", "880.323.0925", false, null, false, "Alf_MacGyver" },
                    { new Guid("f24f6078-2fd4-e7b2-23f3-beff00d2e27a"), 0, "61801 Dach Squares, North Alexa, Republic of Korea", new DateTime(2006, 2, 8, 6, 20, 35, 711, DateTimeKind.Local).AddTicks(5624), "59a94b5c-1e23-47f2-95ed-5e7139abeb17", "gertrude.wiegand6_mertz6@hotmail.com", false, 2, false, null, null, null, "sJULFw3_", "(288) 422-2730 x04412", false, null, false, "Darien71" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Teas", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(8538), "Adipisci autem eum nihil eveniet.", new Guid("273cb2f2-54a1-482f-ae1b-53a170c15528") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Cakes", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(8804), "Nulla eum quisquam.", new Guid("8daf3ade-70c1-48f3-936b-6c81283c3fba") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Sandwiches", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(8823), "Nihil aut tempora nostrum eos possimus aut iure.", new Guid("c357ec65-6be0-4746-b82f-fda7e87ec519") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Cakes", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(8860), "Quo quas voluptatem in et ut asperiores non.", new Guid("8be1e9a1-6e48-4b06-8612-44113baed5c2") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Cakes", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(8890), "Rerum beatae saepe aut omnis nemo.", new Guid("57a72e95-2fe3-430e-ae5f-94dcacd8cce5") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Sandwiches", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(8918), "Dicta enim rerum vitae est sequi aut vitae.", new Guid("2777b180-f53d-4fe8-99d7-48de088f2b09") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Coffees", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(8959), "Cupiditate enim id totam libero.", new Guid("f2cd4fb0-c829-4dd5-8ac1-b058b405f9ac") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Ice Creams", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(8994), "Omnis odio officia et.", new Guid("255ceea4-12fc-4a68-95fa-2f749cddd91d") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Desserts", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(9012), "Numquam tenetur quia illo occaecati consequatur perspiciatis.", new Guid("a5154ffb-754f-43d0-a8c1-9470c74700ae") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Fruit Juices", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(9038), "Placeat ratione voluptatem.", new Guid("76051767-5c5f-4c3a-99d5-fb0aaade97be") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Cakes", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(9052), "Cumque sequi sint adipisci voluptas voluptas ut.", new Guid("d0a2254a-ec3c-42c8-b504-bd63814ead5c") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Ice Creams", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(9077), "Odit veniam exercitationem vel.", new Guid("038fbf5e-5e42-4787-9050-f230c84e2aac") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Chocolates", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(9093), "Velit dolores est minima commodi autem dolor dolore.", new Guid("25061acc-ada7-4a39-9c69-2793e7852d5b") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryName", "CreatedDate", "Description", "MasterId" },
                values: new object[] { "Cakes", new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(9119), "Et voluptas quo ex delectus omnis.", new Guid("91095540-c42e-4645-a0f9-7d9b8b91a9e8") });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "MasterId" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 53, 29, 397, DateTimeKind.Local).AddTicks(9140), "Voluptatum consequatur omnis quisquam aliquam aut distinctio repellat rem.", new Guid("13e48e12-059e-4d59-a91c-15a98ddfd0d5") });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CreatedDate", "MasterId", "OrderDate" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 53, 29, 402, DateTimeKind.Local).AddTicks(2694), new Guid("d151cceb-d9f1-43bb-ab3c-24f173b4bcce"), new DateTime(2024, 7, 22, 11, 53, 29, 402, DateTimeKind.Local).AddTicks(2723) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 9, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5467), 0.19, "https://picsum.photos/640/480/?image=1000", new Guid("a49f8116-82cd-4035-a060-313bceb105ee"), 533.20m, "Coffee Soda", (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 6, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5705), 0.38, "https://picsum.photos/640/480/?image=870", new Guid("7ed55595-1f9b-4529-bc19-f7abff23945f"), 403.42m, "Coffee Soda", (short)52 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 9, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5718), 0.01, "https://picsum.photos/640/480/?image=644", new Guid("e69dda6e-579e-47a2-a883-cc5403a1e811"), 388.76m, "Profiterole", (short)12 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 4, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5727), 0.33000000000000002, "https://picsum.photos/640/480/?image=874", new Guid("d7f4e40d-51f0-4cca-9a3d-7b6e5da23c61"), 315.87m, "Muffin", (short)0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 6, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5737), 0.12, "https://picsum.photos/640/480/?image=158", new Guid("1b5cc216-1369-40d3-999a-ae090f2851ef"), 165.08m, "Panna Cotta", (short)30 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5747), 0.22, "https://picsum.photos/640/480/?image=281", new Guid("ddd6b580-1f41-4b44-9597-7d52d7a305cb"), 229.68m, "Macaron", (short)82 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 4, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5755), 0.059999999999999998, "https://picsum.photos/640/480/?image=65", new Guid("bea47933-f1ef-40f3-a3b2-b14a4dbed82c"), 857.86m, "Brownie", (short)47 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 6, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5764), 0.37, "https://picsum.photos/640/480/?image=1079", new Guid("900930ae-ccbf-4df6-85a3-a0b2ca01faf6"), 125.46m, "Chocolate Fondue", (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5782), 0.11, "https://picsum.photos/640/480/?image=374", new Guid("1c16cc32-9303-41ac-b895-0d94d118cef6"), 555.14m, "Pudding", (short)28 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 8, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5792), 0.040000000000000001, "https://picsum.photos/640/480/?image=388", new Guid("2ab08321-5e01-42f8-bb6a-7a20caa9a062"), 745.25m, "Macaron", (short)69 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 3, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5801), 0.29999999999999999, "https://picsum.photos/640/480/?image=402", new Guid("2550f0e9-4f0f-44c7-b053-f1f46405a51d"), 209.89m, "Brownie", (short)87 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 8, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5810), 0.40000000000000002, "https://picsum.photos/640/480/?image=601", new Guid("ab5b84e8-5447-4d8e-92e7-384f3d56e241"), 131.31m, "Coffee Martini", (short)59 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 5, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5847), 0.040000000000000001, "https://picsum.photos/640/480/?image=1035", new Guid("84ea44c0-b3a4-4063-955a-48f6e1a20142"), 730.51m, "Cold Brew", (short)70 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 8, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5857), 0.40000000000000002, "https://picsum.photos/640/480/?image=933", new Guid("b04533d4-bc4e-4df2-a2b1-9005d8716224"), 622.26m, "Cold Brew", (short)77 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 9, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5866), 0.059999999999999998, "https://picsum.photos/640/480/?image=724", new Guid("83229a36-c45d-49bc-9b76-836cd47bda7b"), 574.96m, "Affogato", (short)14 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "Stock" },
                values: new object[] { 10, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5875), 0.40000000000000002, "https://picsum.photos/640/480/?image=905", new Guid("6ae83b00-56e6-4451-8622-2c8594c15275"), 290.35m, (short)88 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 2, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5886), 0.41999999999999998, "https://picsum.photos/640/480/?image=131", new Guid("1d39eff6-7a9f-40d2-af5b-6ff0de8d1c4d"), 34.59m, "Cappuccino", (short)8 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5896), 0.38, "https://picsum.photos/640/480/?image=429", new Guid("ed6daf50-9880-4186-9cb7-7a8a3b36a23c"), 710.64m, "Flat White", (short)50 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 8, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5905), 0.26000000000000001, "https://picsum.photos/640/480/?image=781", new Guid("69cf5534-4593-4f06-8af2-afd4f2da5b4b"), 704.20m, "Cookie", (short)72 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "CategoryId", "CreatedDate", "Discount", "ImagePath", "MasterId", "Price", "ProductName", "Stock" },
                values: new object[] { 9, new DateTime(2024, 7, 22, 11, 53, 29, 399, DateTimeKind.Local).AddTicks(5914), 0.050000000000000003, "https://picsum.photos/640/480/?image=14", new Guid("54ab401b-14ce-40ad-8c8e-86e58aca0482"), 891.22m, "Panna Cotta", (short)58 });
        }
    }
}
