using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeanHop.Database.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "Price",
                keyColumn: "PriceID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Price",
                keyColumn: "PriceID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Price",
                keyColumn: "PriceID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Price",
                keyColumn: "PriceID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RoastLevel",
                keyColumn: "RoastLevelID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoastLevel",
                keyColumn: "RoastLevelID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RoastLevel",
                keyColumn: "RoastLevelID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RoastLevel",
                keyColumn: "RoastLevelID",
                keyValue: 1);

            migrationBuilder.AddColumn<string>(
                name: "ConfirmationToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ConfirmationToken",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "RegistrationTime",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, null, "CUSTOMER", "Customer", "customer" },
                    { 2, null, "STAFF", "Staff", "staff" },
                    { 3, null, "ADMIN", "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "HCM", "1ecdd931-9c4a-48c6-bcb1-482c067fe9eb", "member1@gmail.com", true, "Name1", "LastName1", false, null, null, null, "AQAAAAIAAYagAAAAEFj0uOTk5XlV4Z6Kmck40q0avmn2y+cMwiJa1ApMchyCyYXcmaJzLpJlR73Lv8ushg==", "1", false, "", true, false, "member1@gmail.com" },
                    { 2, 0, "HCM", "bf8bd8d5-4039-42fe-b868-5b966322b3fe", "member2@gmail.com", true, "Name2", "LastName2", false, null, null, null, "AQAAAAIAAYagAAAAEN1OvoMDK6RU5TlZ/houlZGVQeX8NrH7+l5RPFUQ556FOKG3uVmhJjPHlOHvjLVyHQ==", "2", false, "", true, false, "member2@gmail.com" },
                    { 3, 0, "HCM", "5a6d58cf-8c28-4d00-9dd2-29875e748f23", "member3@gmail.com", true, "Name3", "LastName3", false, null, null, null, "AQAAAAIAAYagAAAAEBhW9rj+7Z8m6B91CT3kRYQO+IV8uLc9Eir3eNOpgFNyRdu1//CPD15/SwqEgfPQbg==", "3", false, "", true, false, "member3@gmail.com" },
                    { 4, 0, "HCM", "4b981b16-d725-41b7-a9ae-9a731dee8a95", "member4@gmail.com", true, "Name4", "LastName4", false, null, null, null, "AQAAAAIAAYagAAAAEJwftIiYRtcAAtu8RjuY1cv1KakgR5qu+2BnVS2PXEkKkHOU8wKLKrBYw4yH1lLqQA==", "4", false, "", true, false, "member4@gmail.com" },
                    { 5, 0, "HCM", "6f4851ec-44e8-4808-a62c-5219fb814453", "member5@gmail.com", true, "Name5", "LastName5", false, null, null, null, "AQAAAAIAAYagAAAAEFsdYBF4Z62uBWFQ/YuuJstlowbjKKQThjxmZoEUbIguc0hDDaYnq9auVe6UDCTksg==", "5", false, "", true, false, "member5@gmail.com" },
                    { 6, 0, "HCM", "42c2380c-0557-4b8e-88d0-2fe238b66e84", "member6@gmail.com", true, "Name6", "LastName6", false, null, null, null, "AQAAAAIAAYagAAAAEFSKVvLHgv3tUp66vpGBEl/4C5eEAy6W161PLdwNsfSnAFVcrrS1TZrMP/8uwWCxPw==", "6", false, "", true, false, "member6@gmail.com" },
                    { 7, 0, "HCM", "62bcea09-fc49-4415-a419-9b43c64fff4c", "member7@gmail.com", true, "Name7", "LastName7", false, null, null, null, "AQAAAAIAAYagAAAAEKfpYN9uNsXjmYZ7gbuL09pYagjwlssXdJcNBUloHDexg8RlkvGHhODMMvYpUG218A==", "7", false, "", true, false, "member7@gmail.com" },
                    { 8, 0, "HCM", "9ed32da0-8f01-434a-a2d2-1ebc04b69f45", "member8@gmail.com", true, "Name8", "LastName8", false, null, null, null, "AQAAAAIAAYagAAAAEAZKFRh0n3mBqJzmFNbmPAP3Oad9R7dlRwRzMKqjqrp3vX0SytPAASyMwsFa92j+gg==", "8", false, "", true, false, "member8@gmail.com" },
                    { 9, 0, "HCM", "425dfa2c-32b6-41e3-a7f1-de138c420d87", "member9@gmail.com", true, "Name9", "LastName9", false, null, null, null, "AQAAAAIAAYagAAAAEO7ikwikoPZe81FjgDxb45/PQlHJxfIV916/GUDvtNOYHAwzQcMj+MZGZrwlvz4Vrg==", "9", false, "", true, false, "member9@gmail.com" },
                    { 10, 0, "HCM", "2cc49cf6-6e83-4c55-892c-2e9e5389e8d2", "member10@gmail.com", true, "Name10", "LastName10", false, null, null, null, "AQAAAAIAAYagAAAAEBTM9WIOFHDrb7FiKDdZQlPI8ZHYGq/PN0ACeYLwEPQT/bab3h59q9lR2pfL024olQ==", "10", false, "", true, false, "member10@gmail.com" },
                    { 11, 0, "HCM", "0f565c9c-8294-4d7d-8d4a-c479ee72c91a", "staff11@gmail.com", true, "Name11", "LastName11", false, null, null, null, "AQAAAAIAAYagAAAAEHmg+qx/prwZZdPxbK3cxrEZTgZI9sEeEeZSEq4559x8K7rHgXV1+SIobsem499X+w==", "11", false, "", true, false, "staff11@gmail.com" },
                    { 12, 0, "HCM", "333e6d0f-3108-462f-9375-199675d23817", "staff12@gmail.com", true, "Name12", "LastName12", false, null, null, null, "AQAAAAIAAYagAAAAENycUCIwfu0Fw+J9XgxwLlyo2YkxS7/+qtHSUI1qJp7yUfCujG/jqfqnJfQVdf1zfA==", "12", false, "", true, false, "staff12@gmail.com" },
                    { 13, 0, "HCM", "dda0276e-3c1b-4ecf-b7d8-2d27d22f96f4", "staff13@gmail.com", true, "Name13", "LastName13", false, null, null, null, "AQAAAAIAAYagAAAAEKsU9aKi02Xu+4EDJKcjIRCKHGwC1AkMa9QyUMsLwCWN+aZRWSQQEpLBaJnnDQLXQg==", "13", false, "", true, false, "staff13@gmail.com" },
                    { 14, 0, "HCM", "13603003-7f50-4082-809f-bfd62b3cc6d9", "staff14@gmail.com", true, "Name14", "LastName14", false, null, null, null, "AQAAAAIAAYagAAAAEHkon0mwGuICgb3LP64ASmvkqv3fWXfBfCkyXMzSXWVjntPhsG6w5W0GxlkipWx4fA==", "14", false, "", true, false, "staff14@gmail.com" },
                    { 15, 0, "HCM", "22d5154c-2d13-459b-9683-6d38be6fd841", "staff15@gmail.com", true, "Name15", "LastName15", false, null, null, null, "AQAAAAIAAYagAAAAEB83TuN/EyYhkxHnoXfNOJ9FVbBIFkMkpoWv9Ou3XXZp0bqFQHOkhZvkgnavIHjmcw==", "15", false, "", true, false, "staff15@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "RoastLevel",
                columns: new[] { "RoastLevelID", "RoastName" },
                values: new object[,]
                {
                    { 1, "Light" },
                    { 2, "Medium" },
                    { 3, "Medium Dark" },
                    { 4, "Dark" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CreateDate", "Description", "ExpextDate", "Introduction", "ProductName", "RoastLevelID", "UpdatetDate", "status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 29, 19, 2, 42, 204, DateTimeKind.Local).AddTicks(3857), "Nằm ở độ cao 1500-1600m so với mực nước biển, Núi Min (xã Trạm Hành, Lâm Đồng) là vùng đất được thiên nhiên ưu ái khí hậu và thổ nhưỡng phù hợp phát triển cà phê Arabica. Hạt cà phê Núi Min đạt được những nốt hương tinh tế từ trái cây, socola, hạt khô, và quan trọng trên hết là sự cân bằng của vị chua-ngọt cùng cảm nhận êm ái tới tận hậu vị. \r\nVốn ý thức được từ sớm về giá trị của việc phát triển cà phê chất lượng cao, các nông hộ tại Núi Min vẫn luôn quan tâm tới chất lượng trồng trọt và thu hái, đảm bảo thu hoạch trái chín, hái bằng tay, sơ chế đúng tiêu chuẩn...\r\nCà phê Núi Min, Trạm Hành được xưởng rang BeanHop gửi tới khách hàng là hạt được sơ chế ướt bởi Lâm Tuyền Farm, sàng cỡ 18 đồng đều, hạt đẹp không lỗi. BeanHop cung cấp hai mức rang khác nhau là Light Roast và Medium Roast, đáp ứng nhu cầu đa dạng của khách hàng uống pha máy espresso/mokapot/phin cũng như khách hàng yêu thích cà phê rang light pha thủ công/ủ coldbrew\"\r\nDưới đây là một số công thức pha:\r\n- Công thức pha  Pour over (giấy lọc) - Hạt Light Roast\r\nCà phê sử dụng: 15GR\r\nTỉ lệ pha: 1:13 - 1:15\r\nNhiệt độ nước: 93*C\r\nThời gian pha: 2 phút 30 giây\r\n- Công thức pha máy Espresso - Hạt Medium Roast\r\nCà phê sử dụng: 18GR (doubleshot)\r\nThu được 36GR Espresso\r\nTỉ lệ gram in-out: 1:2\r\nNhiệt độ nước: 93-94*C\r\nThời gian pha: 27-3 giây\r\n- Công thức pha Ủ Coldbrew: \r\nTỉ lệ cà phê-nước 1:12 . Thời gian ủ 12 tiếng cho rang Medium, 15-18 tiếng cho rang Light \r\nSau khi lọc xong bã thì giữ lạnh coldbrew trong tủ lạnh thêm 2 tiếng trước khi thưởng thức", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thông tin cơ bản:\r\n- Farm : Lâm Tuyền, Núi Min, Trạm Hành\r\n- Giống: Catimor\r\n- Sơ chế: Full Washed\r\n- Độ cao: 1500 - 1600m\r\n- Hương vị: Plum Acidity, Caramel, Smooth body and sweetness", "Cà phê Arabica Núi Min Rang Medium Pha Máy Pha Phin Ủ Coldbrew", 1, null, true },
                    { 2, new DateTime(2024, 1, 29, 19, 2, 42, 204, DateTimeKind.Local).AddTicks(3893), "An Coffee Farm là Farm Robusta chất lượng cao nằm ở độ cao 1000m, thuộc xã Hoài Đức, Lâm Hà, Lâm Đồng. Nông hộ cà phê được trực tiếp quản lý chất lượng bởi chị Duyên Anh, một người dành rất nhiều tâm huyết với hạt Robusta Việt Nam, luôn cố gắng cải thiện công nghệ cũng như chất lượng gieo trồng để mỗi vụ mùa đều cho ra sản phẩm hạt Robusta tốt hơn. \r\nLà một khách hàng của An Coffee Farm, xưởng rang BeanHop hoàn toàn yên tâm về chất lượng hạt, mỗi mùa vụ đều đạt độ tinh tế về hương vị  ổn định hoặc tốt hơn mùa trước. Cà phê Robusta Lâm Hà sơ chế Honey (hình thức sơ chế phơi khô khi phần vỏ ngoài và thịt của trái cà phê được loại bỏ 1 phần) được xưởng BeanHop cung cấp với mức rang Medium Roast hoặc Medium-Dark Roast. Hạt thể hiện rất tốt hương vị chua nhẹ trái cây, ngọt béo dày dặn, hậu vị êm ái khi sử dụng cho pha phin, pha máy espresso, ấm mokapot, ủ coldbrew...\r\n\r\nCông thức pha máy Espresso - Hạt Medium Roast \r\nCà phê sử dụng: 18GR (doubleshot) \r\nThu được 40GR Espresso \r\nTỉ lệ gram in-out: 1:2,2\r\nNhiệt độ nước: 92-93*C \r\nThời gian pha: 25-27 giây\r\n", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thông tin vùng trồng hạt cà phê:\r\n- Farm : An Coffee Farm - Farm Robusta chất lượng cao\r\n- Giống: Búp Tím\r\n- Sơ chế: Honey\r\n- Độ cao: 1000 -1100m\r\n- Hương vị: Chua nhẹ, Béo và êm, độ đậm vừa phải", "Cà phê Robusta Lâm Hà Honey GU NHẸ Rang Medium Pha Phin Pha Máy", 1, null, true },
                    { 3, new DateTime(2024, 1, 29, 19, 2, 42, 204, DateTimeKind.Local).AddTicks(3906), "Cà phê là sự phối trộn giữa 2 dòng cà phê chất lượng cao:\r\n.  80% Robusta Lâm Hà (Natural)\r\n. 20% Arabica Cầu Đất (Washed)\r\nĐem tới Hương vị: Hương Dark Chocolate Mạnh, Có hậu vị dài\r\nĐậm đà, Ngọt béo, Dày vị\r\n\r\nThông tin về dòng cà phê Arabica và Robusta: \r\n- ROBUSTA LÂM HÀ\r\nVùng: Xã Hoài Đức, Lâm Hà, Lâm Đồng\r\nĐộ cao: 1000M\r\nGiống: BÚP TÍM\r\nSơ chế: Natural\r\nHương vị: Thơm hương Dark Chocolate, Đậm đà, Ngọt sâu, Hậu vị dài. Có chút đắng nhẹ hậu vị\r\n- VIỆT NAM ARABICA CẦU ĐẤT\r\nVùng: Cầu Đất, Đà Lạt, Lâm Đồng\r\nĐộ cao: 1500M\r\nGiống: Catimor\r\nSơ chế: WASHED\r\nHương vị: Đậm Đà, Chocote, Vị béo cao của hạt khô (Nutty), Chua nhẹ", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "COFFEE BLENDED: 8 ROBUSTA - 2 ARABICA\r\nDÀNH CHO GU UỐNG ĐẬM\r\nPHÙ HỢP PHA PHIN, PHA MÁY (GU ĐẬM)", "Cà phê Blend GU ĐẬM 8 Robusta 2 Arabica Pha Phin", 2, null, true },
                    { 4, new DateTime(2024, 1, 29, 19, 2, 42, 204, DateTimeKind.Local).AddTicks(3917), "Cà phê là sự phối trộn giữa 2 dòng cà phê chất lượng cao:\r\n. 70% Arabica Cầu Đất (Washed)\r\n. 30% Robusta Lâm Hà (Honey)\r\nĐem tới hương vị: Chua thanh, Ngọt hậu\r\nHương Chocolate, Caramel Ngọt béo, Độ đậm vừa phải\r\n\r\nThông tin về dòng cà phê Arabica và Robusta: \r\n- VIỆT NAM ARABICA NÚI MIN\r\nVùng: Lâm Tuyền, Núi Min, Xã Trạm Hành\r\nĐộ cao: 1600M+\r\nGiống: Catimor\r\nSơ chế: WASHED\r\nHương vị: Chua thanh trái cây (Hương giống trái cam, mận), Ngọt hậu, hương socola và caramel nhẹ nhàng\r\n- ROBUSTA LÂM HÀ\r\nVùng: Xã Hoài Đức, Lâm Hà, Lâm Đồng\r\nĐộ cao: 1000M\r\nGiống: Búp Tím\r\nSơ chế: Honey\r\nHương vị: Chua nhẹ, Ngọt dịu, Độ béo cao, Hậu vị êm", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "COFFEE BLENDED: 7 ARABICA - 3 ROBUSTA\r\nDÀNH CHO GU UỐNG NHẸ\r\nPHÙ HỢP PHA PHIN, PHA ESPRESSO (MÁY, DỤNG CỤ PHA CẦM TAY, ẤM MOKA...)\r\nỦ COLDBREW", "Cà phê Blend GU NHẸ 7 Arabica 3 Robusta Pha Phin Pha Máy", 3, null, true },
                    { 5, new DateTime(2024, 1, 29, 19, 2, 42, 204, DateTimeKind.Local).AddTicks(3950), "An Coffee Farm là Farm Robusta chất lượng cao nằm ở độ cao 1000m, thuộc xã Hoài Đức, Lâm Hà, Lâm Đồng. Nông hộ cà phê được trực tiếp quản lý chất lượng bởi chị Duyên Anh, một người dành rất nhiều tâm huyết với hạt Robusta Việt Nam, luôn cố gắng cải thiện công nghệ cũng như chất lượng gieo trồng để mỗi vụ mùa đều cho ra sản phẩm hạt Robusta tốt hơn. \r\nLà một khách hàng của An Coffee Farm, xưởng rang BeanHop hoàn toàn yên tâm về chất lượng hạt, mỗi mùa vụ đều đạt độ tinh tế về hương vị tốt hơn mùa trước. Cà phê Robusta Lâm Hà sơ chế Natural được xưởng BeanHop cung cấp với mức rang Medium-Dark Roast. Hạt thể hiện rất tốt hương vị cà phê đậm đà phong cách truyền thống, ngọt béo dày dặn, hậu vị hơi đắng nhẹ khi sử dụng cho pha phin, pha máy espresso, ấm mokapot\r\n\r\nCT máy Espresso - Hạt Medium Roast \r\nCà phê sử dụng: 18GR (doubleshot) \r\nThu được 40GR Espresso \r\nTỉ lệ gram in-out: 1:2,2\r\nNhiệt độ nước: 92-93*C \r\nThời gian pha: 25-27 giây", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thông tin vùng trồng hạt cà phê:\r\n- Farm : An Coffee Farm - Farm Robusta chất lượng cao\r\n- Giống: Búp tím\r\n- Sơ chế: Natural\r\n- Độ cao: 1000 -1100m\r\n- Hương vị: Đậm đà, Ngọt Béo, Đắng nhẹ", "Cà phê Robusta Lâm Hà Natural GU ĐẬM Rang Medium Pha Máy Pha Phin", 3, null, true }
                });

            migrationBuilder.InsertData(
                table: "Price",
                columns: new[] { "PriceID", "Cost", "PackagingType", "ProductID", "Weight", "status" },
                values: new object[,]
                {
                    { 1, 51000.0, "Nguyên Hạt", 1, 200.0, true },
                    { 2, 102000.0, "Thô vừa", 1, 500.0, true },
                    { 3, 51000.0, "Nguyên Hạt", 2, 200.0, true },
                    { 4, 102000.0, "Thô vừa", 2, 500.0, true }
                });
        }
    }
}
