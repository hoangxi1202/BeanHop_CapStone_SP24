using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeanHop.Database.Migrations
{
    /// <inheritdoc />
    public partial class AddFakedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "ConfirmationToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "ConfirmationToken", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegistrationTime", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "HCM", "e9118435-324a-490c-8a6a-239187bd76e9", null, "member1@gmail.com", true, "Name1", "LastName1", false, null, null, null, "AQAAAAIAAYagAAAAEOoSa2gylzSnjXbY7Yb3vRe0Tw7WyQ6n6ljbpJYksJSC8B6m9zIO684P3hBtbIsZ6w==", "1", false, null, "", true, false, "member1@gmail.com" },
                    { 2, 0, "HCM", "cf6fe556-afc7-4970-bcaf-7ce0ed9b028a", null, "member2@gmail.com", true, "Name2", "LastName2", false, null, null, null, "AQAAAAIAAYagAAAAEPm/n5NSIv4wU69NL0D3X14m4wcDXIpeWiattblN6rTgQX97OOFqHfplHv4grvNZYA==", "2", false, null, "", true, false, "member2@gmail.com" },
                    { 3, 0, "HCM", "8df41f62-92b3-4dd2-9e07-ead73786df18", null, "member3@gmail.com", true, "Name3", "LastName3", false, null, null, null, "AQAAAAIAAYagAAAAEKgKkf+6a30HKAQUuUhfxPvtIP9rrbSjrN3o66ZZVSl8KeCiSNGK77shvMwzBw+SnQ==", "3", false, null, "", true, false, "member3@gmail.com" },
                    { 4, 0, "HCM", "a2443c70-e186-4577-b697-a1ab279a006e", null, "member4@gmail.com", true, "Name4", "LastName4", false, null, null, null, "AQAAAAIAAYagAAAAELtUUSbzJJdH8O2pYRb5oyNUako+teS88p7t8BLGganqhiKNBjhJr4ORjkaihavIJQ==", "4", false, null, "", true, false, "member4@gmail.com" },
                    { 5, 0, "HCM", "f4aaace4-73c0-4dd6-8ded-5a3e48841633", null, "member5@gmail.com", true, "Name5", "LastName5", false, null, null, null, "AQAAAAIAAYagAAAAEHpqJef4o0eMaCopIxqqYX9iprv/gcZFW8+FycaxLciLe0LWFK7KDaFsdTGsBBTSsA==", "5", false, null, "", true, false, "member5@gmail.com" },
                    { 6, 0, "HCM", "488bbceb-4cab-473f-b48e-33089a91eb2a", null, "member6@gmail.com", true, "Name6", "LastName6", false, null, null, null, "AQAAAAIAAYagAAAAEB5+e/a8ZLfEggDuOgjfvlild0jm8+jQ5Oei/hnCuRY0Sz3RaQxRE8Uv2mvuq0PVsw==", "6", false, null, "", true, false, "member6@gmail.com" },
                    { 7, 0, "HCM", "c6d9f9f5-c55e-4490-b7be-ddfe4bfcc3dc", null, "member7@gmail.com", true, "Name7", "LastName7", false, null, null, null, "AQAAAAIAAYagAAAAELxKV8Dcz7EeWmqjORWNFyM0QmTj4RqiHWQctkCb5/gqoS0SCwvpKXsmbMAfeDFmaQ==", "7", false, null, "", true, false, "member7@gmail.com" },
                    { 8, 0, "HCM", "9a0267cf-2436-4d55-ab94-2459f5ceb026", null, "member8@gmail.com", true, "Name8", "LastName8", false, null, null, null, "AQAAAAIAAYagAAAAEC/23LlvpaeGTJKhId6SG78W8kjyVKO3wdmwun9hlqbcpYjQalAaE8kfmtMmpG0dTw==", "8", false, null, "", true, false, "member8@gmail.com" },
                    { 9, 0, "HCM", "eabf68b4-a17b-4ada-9781-b517e5142689", null, "member9@gmail.com", true, "Name9", "LastName9", false, null, null, null, "AQAAAAIAAYagAAAAEBS98e8n/D1lCeZdOAOeYUgLkxTbNrJQdo6heMbxKox0hUmp7Cn88eMgpU1Mfrd3tw==", "9", false, null, "", true, false, "member9@gmail.com" },
                    { 10, 0, "HCM", "f661182b-6ce3-4d6d-bb13-9361f54c6bd0", null, "member10@gmail.com", true, "Name10", "LastName10", false, null, null, null, "AQAAAAIAAYagAAAAED2LXzwVUK+tOWJ5P8ogrnyOW/xkThF8udQH/pD2jqvTAZDSa2g1iYz+jRqch7EmiQ==", "10", false, null, "", true, false, "member10@gmail.com" },
                    { 11, 0, "HCM", "30994dcc-c3a1-4d93-837a-47b023b4c9a6", null, "staff11@gmail.com", true, "Name11", "LastName11", false, null, null, null, "AQAAAAIAAYagAAAAEPnCzhQBh1eiZ2JtxgF77ndmxgFVB4hMX3EaWUToSRbPz88+MI2xjsAgVWERcO+zFA==", "11", false, null, "", true, false, "staff11@gmail.com" },
                    { 12, 0, "HCM", "6b6688f5-2126-406d-b3ee-ae3e3ba02ac4", null, "staff12@gmail.com", true, "Name12", "LastName12", false, null, null, null, "AQAAAAIAAYagAAAAEC9rd9IDuzK45LgR6ZVJpZzOTezsqxOXBcEsFt+lDiVNFQFTzeQH2aN9p18HnJdUUw==", "12", false, null, "", true, false, "staff12@gmail.com" },
                    { 13, 0, "HCM", "ba20a3c2-b2b0-46c3-a48a-95f09a2e99c3", null, "staff13@gmail.com", true, "Name13", "LastName13", false, null, null, null, "AQAAAAIAAYagAAAAEEFYRoV0RUmywnB0PGi/PWteBioYrgzX/481jwAa+u+7pizBuXL4u8ctgbE0vQz0Cg==", "13", false, null, "", true, false, "staff13@gmail.com" },
                    { 14, 0, "HCM", "6cd9854b-c787-4ccd-9d8b-026156e55716", null, "staff14@gmail.com", true, "Name14", "LastName14", false, null, null, null, "AQAAAAIAAYagAAAAEBI6dW1VyJZcT/NKYdOaEp0QUr0x9h/2nArATG7XcUmD/4NouwpqsYc7Hr8r9Dcn+Q==", "14", false, null, "", true, false, "staff14@gmail.com" },
                    { 15, 0, "HCM", "fbb79924-a28f-4805-964c-d13ffc59b7fe", null, "staff15@gmail.com", true, "Name15", "LastName15", false, null, null, null, "AQAAAAIAAYagAAAAEOgs9dq/dex/++bfBycZ0YVYoPcwSTjB4DUUnKgE8zPzbqallk01NSBd16tYlOghaw==", "15", false, null, "", true, false, "staff15@gmail.com" }
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
                    { 1, new DateTime(2024, 2, 2, 23, 10, 59, 550, DateTimeKind.Local).AddTicks(5168), "Nằm ở độ cao 1500-1600m so với mực nước biển, Núi Min (xã Trạm Hành, Lâm Đồng) là vùng đất được thiên nhiên ưu ái khí hậu và thổ nhưỡng phù hợp phát triển cà phê Arabica. Hạt cà phê Núi Min đạt được những nốt hương tinh tế từ trái cây, socola, hạt khô, và quan trọng trên hết là sự cân bằng của vị chua-ngọt cùng cảm nhận êm ái tới tận hậu vị. \r\nVốn ý thức được từ sớm về giá trị của việc phát triển cà phê chất lượng cao, các nông hộ tại Núi Min vẫn luôn quan tâm tới chất lượng trồng trọt và thu hái, đảm bảo thu hoạch trái chín, hái bằng tay, sơ chế đúng tiêu chuẩn...\r\nCà phê Núi Min, Trạm Hành được xưởng rang BeanHop gửi tới khách hàng là hạt được sơ chế ướt bởi Lâm Tuyền Farm, sàng cỡ 18 đồng đều, hạt đẹp không lỗi. BeanHop cung cấp hai mức rang khác nhau là Light Roast và Medium Roast, đáp ứng nhu cầu đa dạng của khách hàng uống pha máy espresso/mokapot/phin cũng như khách hàng yêu thích cà phê rang light pha thủ công/ủ coldbrew\"\r\nDưới đây là một số công thức pha:\r\n- Công thức pha  Pour over (giấy lọc) - Hạt Light Roast\r\nCà phê sử dụng: 15GR\r\nTỉ lệ pha: 1:13 - 1:15\r\nNhiệt độ nước: 93*C\r\nThời gian pha: 2 phút 30 giây\r\n- Công thức pha máy Espresso - Hạt Medium Roast\r\nCà phê sử dụng: 18GR (doubleshot)\r\nThu được 36GR Espresso\r\nTỉ lệ gram in-out: 1:2\r\nNhiệt độ nước: 93-94*C\r\nThời gian pha: 27-3 giây\r\n- Công thức pha Ủ Coldbrew: \r\nTỉ lệ cà phê-nước 1:12 . Thời gian ủ 12 tiếng cho rang Medium, 15-18 tiếng cho rang Light \r\nSau khi lọc xong bã thì giữ lạnh coldbrew trong tủ lạnh thêm 2 tiếng trước khi thưởng thức", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thông tin cơ bản:\r\n- Farm : Lâm Tuyền, Núi Min, Trạm Hành\r\n- Giống: Catimor\r\n- Sơ chế: Full Washed\r\n- Độ cao: 1500 - 1600m\r\n- Hương vị: Plum Acidity, Caramel, Smooth body and sweetness", "Cà phê Arabica Núi Min Rang Medium Pha Máy Pha Phin Ủ Coldbrew", 1, null, true },
                    { 2, new DateTime(2024, 2, 2, 23, 10, 59, 550, DateTimeKind.Local).AddTicks(5209), "An Coffee Farm là Farm Robusta chất lượng cao nằm ở độ cao 1000m, thuộc xã Hoài Đức, Lâm Hà, Lâm Đồng. Nông hộ cà phê được trực tiếp quản lý chất lượng bởi chị Duyên Anh, một người dành rất nhiều tâm huyết với hạt Robusta Việt Nam, luôn cố gắng cải thiện công nghệ cũng như chất lượng gieo trồng để mỗi vụ mùa đều cho ra sản phẩm hạt Robusta tốt hơn. \r\nLà một khách hàng của An Coffee Farm, xưởng rang BeanHop hoàn toàn yên tâm về chất lượng hạt, mỗi mùa vụ đều đạt độ tinh tế về hương vị  ổn định hoặc tốt hơn mùa trước. Cà phê Robusta Lâm Hà sơ chế Honey (hình thức sơ chế phơi khô khi phần vỏ ngoài và thịt của trái cà phê được loại bỏ 1 phần) được xưởng BeanHop cung cấp với mức rang Medium Roast hoặc Medium-Dark Roast. Hạt thể hiện rất tốt hương vị chua nhẹ trái cây, ngọt béo dày dặn, hậu vị êm ái khi sử dụng cho pha phin, pha máy espresso, ấm mokapot, ủ coldbrew...\r\n\r\nCông thức pha máy Espresso - Hạt Medium Roast \r\nCà phê sử dụng: 18GR (doubleshot) \r\nThu được 40GR Espresso \r\nTỉ lệ gram in-out: 1:2,2\r\nNhiệt độ nước: 92-93*C \r\nThời gian pha: 25-27 giây\r\n", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thông tin vùng trồng hạt cà phê:\r\n- Farm : An Coffee Farm - Farm Robusta chất lượng cao\r\n- Giống: Búp Tím\r\n- Sơ chế: Honey\r\n- Độ cao: 1000 -1100m\r\n- Hương vị: Chua nhẹ, Béo và êm, độ đậm vừa phải", "Cà phê Robusta Lâm Hà Honey GU NHẸ Rang Medium Pha Phin Pha Máy", 1, null, true },
                    { 3, new DateTime(2024, 2, 2, 23, 10, 59, 550, DateTimeKind.Local).AddTicks(5221), "Cà phê là sự phối trộn giữa 2 dòng cà phê chất lượng cao:\r\n.  80% Robusta Lâm Hà (Natural)\r\n. 20% Arabica Cầu Đất (Washed)\r\nĐem tới Hương vị: Hương Dark Chocolate Mạnh, Có hậu vị dài\r\nĐậm đà, Ngọt béo, Dày vị\r\n\r\nThông tin về dòng cà phê Arabica và Robusta: \r\n- ROBUSTA LÂM HÀ\r\nVùng: Xã Hoài Đức, Lâm Hà, Lâm Đồng\r\nĐộ cao: 1000M\r\nGiống: BÚP TÍM\r\nSơ chế: Natural\r\nHương vị: Thơm hương Dark Chocolate, Đậm đà, Ngọt sâu, Hậu vị dài. Có chút đắng nhẹ hậu vị\r\n- VIỆT NAM ARABICA CẦU ĐẤT\r\nVùng: Cầu Đất, Đà Lạt, Lâm Đồng\r\nĐộ cao: 1500M\r\nGiống: Catimor\r\nSơ chế: WASHED\r\nHương vị: Đậm Đà, Chocote, Vị béo cao của hạt khô (Nutty), Chua nhẹ", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "COFFEE BLENDED: 8 ROBUSTA - 2 ARABICA\r\nDÀNH CHO GU UỐNG ĐẬM\r\nPHÙ HỢP PHA PHIN, PHA MÁY (GU ĐẬM)", "Cà phê Blend GU ĐẬM 8 Robusta 2 Arabica Pha Phin", 2, null, true },
                    { 4, new DateTime(2024, 2, 2, 23, 10, 59, 550, DateTimeKind.Local).AddTicks(5233), "Cà phê là sự phối trộn giữa 2 dòng cà phê chất lượng cao:\r\n. 70% Arabica Cầu Đất (Washed)\r\n. 30% Robusta Lâm Hà (Honey)\r\nĐem tới hương vị: Chua thanh, Ngọt hậu\r\nHương Chocolate, Caramel Ngọt béo, Độ đậm vừa phải\r\n\r\nThông tin về dòng cà phê Arabica và Robusta: \r\n- VIỆT NAM ARABICA NÚI MIN\r\nVùng: Lâm Tuyền, Núi Min, Xã Trạm Hành\r\nĐộ cao: 1600M+\r\nGiống: Catimor\r\nSơ chế: WASHED\r\nHương vị: Chua thanh trái cây (Hương giống trái cam, mận), Ngọt hậu, hương socola và caramel nhẹ nhàng\r\n- ROBUSTA LÂM HÀ\r\nVùng: Xã Hoài Đức, Lâm Hà, Lâm Đồng\r\nĐộ cao: 1000M\r\nGiống: Búp Tím\r\nSơ chế: Honey\r\nHương vị: Chua nhẹ, Ngọt dịu, Độ béo cao, Hậu vị êm", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "COFFEE BLENDED: 7 ARABICA - 3 ROBUSTA\r\nDÀNH CHO GU UỐNG NHẸ\r\nPHÙ HỢP PHA PHIN, PHA ESPRESSO (MÁY, DỤNG CỤ PHA CẦM TAY, ẤM MOKA...)\r\nỦ COLDBREW", "Cà phê Blend GU NHẸ 7 Arabica 3 Robusta Pha Phin Pha Máy", 3, null, true },
                    { 5, new DateTime(2024, 2, 2, 23, 10, 59, 550, DateTimeKind.Local).AddTicks(5244), "An Coffee Farm là Farm Robusta chất lượng cao nằm ở độ cao 1000m, thuộc xã Hoài Đức, Lâm Hà, Lâm Đồng. Nông hộ cà phê được trực tiếp quản lý chất lượng bởi chị Duyên Anh, một người dành rất nhiều tâm huyết với hạt Robusta Việt Nam, luôn cố gắng cải thiện công nghệ cũng như chất lượng gieo trồng để mỗi vụ mùa đều cho ra sản phẩm hạt Robusta tốt hơn. \r\nLà một khách hàng của An Coffee Farm, xưởng rang BeanHop hoàn toàn yên tâm về chất lượng hạt, mỗi mùa vụ đều đạt độ tinh tế về hương vị tốt hơn mùa trước. Cà phê Robusta Lâm Hà sơ chế Natural được xưởng BeanHop cung cấp với mức rang Medium-Dark Roast. Hạt thể hiện rất tốt hương vị cà phê đậm đà phong cách truyền thống, ngọt béo dày dặn, hậu vị hơi đắng nhẹ khi sử dụng cho pha phin, pha máy espresso, ấm mokapot\r\n\r\nCT máy Espresso - Hạt Medium Roast \r\nCà phê sử dụng: 18GR (doubleshot) \r\nThu được 40GR Espresso \r\nTỉ lệ gram in-out: 1:2,2\r\nNhiệt độ nước: 92-93*C \r\nThời gian pha: 25-27 giây", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thông tin vùng trồng hạt cà phê:\r\n- Farm : An Coffee Farm - Farm Robusta chất lượng cao\r\n- Giống: Búp tím\r\n- Sơ chế: Natural\r\n- Độ cao: 1000 -1100m\r\n- Hương vị: Đậm đà, Ngọt Béo, Đắng nhẹ", "Cà phê Robusta Lâm Hà Natural GU ĐẬM Rang Medium Pha Máy Pha Phin", 3, null, true }
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationTime",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ConfirmationToken",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
