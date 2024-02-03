using BeanHop.Model.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeanHop.Database.Extensions
{
    public static class ModelBuilderExtensions
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            var customerRoleId = 1;
            var staffRoleId = 2;
            var AdminRoleId = 3;

            var hasher = new PasswordHasher<AppUser>();

            #region Role
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = customerRoleId,
                Name = "Customer",
                NormalizedName = "customer",
                Description = "CUSTOMER"
            });

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = staffRoleId,
                Name = "Staff",
                NormalizedName = "staff",
                Description = "STAFF"
            });

            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = AdminRoleId,
                Name = "Admin",
                NormalizedName = "admin",
                Description = "ADMIN"
            });
            #endregion

            #region Member
            for (int i = 1; i <= 10; i++)
            {
                modelBuilder.Entity<AppUser>().HasData(new AppUser
                {
                    Id = i,
                    UserName = "member" + i.ToString() + "@gmail.com",
                    Email = "member" + i.ToString() + "@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "12345678"),
                    SecurityStamp = string.Empty,
                    Firstname = "Name" + i.ToString(),
                    Lastname = "LastName" + i.ToString(),
                    Address = "HCM",
                    Status = true,
                    PhoneNumber= i.ToString(),
                });

                modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
                {
                    RoleId = customerRoleId,
                    UserId = i
                });

            }
            #endregion
          
            #region Staff
            for (int i = 11; i <= 15; i++)
            {
                modelBuilder.Entity<AppUser>().HasData(new AppUser
                {
                    Id = i,
                    UserName = "staff" + i.ToString() + "@gmail.com",
                    Email = "staff" + i.ToString() + "@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "12345678"),
                    SecurityStamp = string.Empty,
                    Firstname = "Name" + i.ToString(),
                    Lastname = "LastName" + i.ToString(),
                    Address = "HCM",
                    Status = true,
                    PhoneNumber = i.ToString(),
                });

                modelBuilder.Entity<IdentityUserRole<int>>().HasData(new IdentityUserRole<int>
                {
                    RoleId = staffRoleId,
                    UserId = i
                });
            }
            #endregion

            #region Roast Level
            modelBuilder.Entity<RoastLevel>().HasData(new RoastLevel
                {
                    RoastLevelID= 1,
                    RoastName= "Light",
                });
            modelBuilder.Entity<RoastLevel>().HasData(new RoastLevel
            {
                RoastLevelID = 2,
                RoastName = "Medium",
            });
            modelBuilder.Entity<RoastLevel>().HasData(new RoastLevel
            {
                RoastLevelID = 3,
                RoastName = "Medium Dark",
            });
            modelBuilder.Entity<RoastLevel>().HasData(new RoastLevel
            {
                RoastLevelID = 4,
                RoastName = "Dark",
            });
            #endregion           

            #region Product
            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 1,
                ProductName = "Cà phê Arabica Núi Min Rang Medium Pha Máy Pha Phin Ủ Coldbrew",
                Introduction = "Thông tin cơ bản:\r\n- Farm : Lâm Tuyền, Núi Min, Trạm Hành\r\n- Giống: Catimor\r\n- Sơ chế: Full Washed\r\n- Độ cao: 1500 - 1600m\r\n- Hương vị: Plum Acidity, Caramel, Smooth body and sweetness",
                Description = "Nằm ở độ cao 1500-1600m so với mực nước biển, Núi Min (xã Trạm Hành, Lâm Đồng) là vùng đất được thiên nhiên ưu ái khí hậu và thổ nhưỡng phù hợp phát triển cà phê Arabica. Hạt cà phê Núi Min đạt được những nốt hương tinh tế từ trái cây, socola, hạt khô, và quan trọng trên hết là sự cân bằng của vị chua-ngọt cùng cảm nhận êm ái tới tận hậu vị. \r\nVốn ý thức được từ sớm về giá trị của việc phát triển cà phê chất lượng cao, các nông hộ tại Núi Min vẫn luôn quan tâm tới chất lượng trồng trọt và thu hái, đảm bảo thu hoạch trái chín, hái bằng tay, sơ chế đúng tiêu chuẩn...\r\nCà phê Núi Min, Trạm Hành được xưởng rang BeanHop gửi tới khách hàng là hạt được sơ chế ướt bởi Lâm Tuyền Farm, sàng cỡ 18 đồng đều, hạt đẹp không lỗi. BeanHop cung cấp hai mức rang khác nhau là Light Roast và Medium Roast, đáp ứng nhu cầu đa dạng của khách hàng uống pha máy espresso/mokapot/phin cũng như khách hàng yêu thích cà phê rang light pha thủ công/ủ coldbrew\"\r\nDưới đây là một số công thức pha:\r\n- Công thức pha  Pour over (giấy lọc) - Hạt Light Roast\r\nCà phê sử dụng: 15GR\r\nTỉ lệ pha: 1:13 - 1:15\r\nNhiệt độ nước: 93*C\r\nThời gian pha: 2 phút 30 giây\r\n- Công thức pha máy Espresso - Hạt Medium Roast\r\nCà phê sử dụng: 18GR (doubleshot)\r\nThu được 36GR Espresso\r\nTỉ lệ gram in-out: 1:2\r\nNhiệt độ nước: 93-94*C\r\nThời gian pha: 27-3 giây\r\n- Công thức pha Ủ Coldbrew: \r\nTỉ lệ cà phê-nước 1:12 . Thời gian ủ 12 tiếng cho rang Medium, 15-18 tiếng cho rang Light \r\nSau khi lọc xong bã thì giữ lạnh coldbrew trong tủ lạnh thêm 2 tiếng trước khi thưởng thức",
                ExpextDate = DateTime.Parse("12/12/2024"),
                CreateDate= DateTime.Now,
                UpdatetDate = null,
                status = true,
                RoastLevelID = 1,

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 2,
                ProductName = "Cà phê Robusta Lâm Hà Honey GU NHẸ Rang Medium Pha Phin Pha Máy",
                Introduction = "Thông tin vùng trồng hạt cà phê:\r\n- Farm : An Coffee Farm - Farm Robusta chất lượng cao\r\n- Giống: Búp Tím\r\n- Sơ chế: Honey\r\n- Độ cao: 1000 -1100m\r\n- Hương vị: Chua nhẹ, Béo và êm, độ đậm vừa phải",
                Description = "An Coffee Farm là Farm Robusta chất lượng cao nằm ở độ cao 1000m, thuộc xã Hoài Đức, Lâm Hà, Lâm Đồng. Nông hộ cà phê được trực tiếp quản lý chất lượng bởi chị Duyên Anh, một người dành rất nhiều tâm huyết với hạt Robusta Việt Nam, luôn cố gắng cải thiện công nghệ cũng như chất lượng gieo trồng để mỗi vụ mùa đều cho ra sản phẩm hạt Robusta tốt hơn. \r\nLà một khách hàng của An Coffee Farm, xưởng rang BeanHop hoàn toàn yên tâm về chất lượng hạt, mỗi mùa vụ đều đạt độ tinh tế về hương vị  ổn định hoặc tốt hơn mùa trước. Cà phê Robusta Lâm Hà sơ chế Honey (hình thức sơ chế phơi khô khi phần vỏ ngoài và thịt của trái cà phê được loại bỏ 1 phần) được xưởng BeanHop cung cấp với mức rang Medium Roast hoặc Medium-Dark Roast. Hạt thể hiện rất tốt hương vị chua nhẹ trái cây, ngọt béo dày dặn, hậu vị êm ái khi sử dụng cho pha phin, pha máy espresso, ấm mokapot, ủ coldbrew...\r\n\r\nCông thức pha máy Espresso - Hạt Medium Roast \r\nCà phê sử dụng: 18GR (doubleshot) \r\nThu được 40GR Espresso \r\nTỉ lệ gram in-out: 1:2,2\r\nNhiệt độ nước: 92-93*C \r\nThời gian pha: 25-27 giây\r\n",
                ExpextDate = DateTime.Parse("12/12/2024"),
                CreateDate = DateTime.Now,
                UpdatetDate = null,
                status = true,
                RoastLevelID = 1,

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 3,
                ProductName = "Cà phê Blend GU ĐẬM 8 Robusta 2 Arabica Pha Phin",
                Introduction = "COFFEE BLENDED: 8 ROBUSTA - 2 ARABICA\r\nDÀNH CHO GU UỐNG ĐẬM\r\nPHÙ HỢP PHA PHIN, PHA MÁY (GU ĐẬM)",
                Description = "Cà phê là sự phối trộn giữa 2 dòng cà phê chất lượng cao:\r\n.  80% Robusta Lâm Hà (Natural)\r\n. 20% Arabica Cầu Đất (Washed)\r\nĐem tới Hương vị: Hương Dark Chocolate Mạnh, Có hậu vị dài\r\nĐậm đà, Ngọt béo, Dày vị\r\n\r\nThông tin về dòng cà phê Arabica và Robusta: \r\n- ROBUSTA LÂM HÀ\r\nVùng: Xã Hoài Đức, Lâm Hà, Lâm Đồng\r\nĐộ cao: 1000M\r\nGiống: BÚP TÍM\r\nSơ chế: Natural\r\nHương vị: Thơm hương Dark Chocolate, Đậm đà, Ngọt sâu, Hậu vị dài. Có chút đắng nhẹ hậu vị\r\n- VIỆT NAM ARABICA CẦU ĐẤT\r\nVùng: Cầu Đất, Đà Lạt, Lâm Đồng\r\nĐộ cao: 1500M\r\nGiống: Catimor\r\nSơ chế: WASHED\r\nHương vị: Đậm Đà, Chocote, Vị béo cao của hạt khô (Nutty), Chua nhẹ",
                ExpextDate = DateTime.Parse("12/12/2024"),
                CreateDate = DateTime.Now,
                UpdatetDate = null,
                status = true,
                RoastLevelID = 2,

            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 4,
                ProductName = "Cà phê Blend GU NHẸ 7 Arabica 3 Robusta Pha Phin Pha Máy",
                Introduction = "COFFEE BLENDED: 7 ARABICA - 3 ROBUSTA\r\nDÀNH CHO GU UỐNG NHẸ\r\nPHÙ HỢP PHA PHIN, PHA ESPRESSO (MÁY, DỤNG CỤ PHA CẦM TAY, ẤM MOKA...)\r\nỦ COLDBREW",
                Description = "Cà phê là sự phối trộn giữa 2 dòng cà phê chất lượng cao:\r\n. 70% Arabica Cầu Đất (Washed)\r\n. 30% Robusta Lâm Hà (Honey)\r\nĐem tới hương vị: Chua thanh, Ngọt hậu\r\nHương Chocolate, Caramel Ngọt béo, Độ đậm vừa phải\r\n\r\nThông tin về dòng cà phê Arabica và Robusta: \r\n- VIỆT NAM ARABICA NÚI MIN\r\nVùng: Lâm Tuyền, Núi Min, Xã Trạm Hành\r\nĐộ cao: 1600M+\r\nGiống: Catimor\r\nSơ chế: WASHED\r\nHương vị: Chua thanh trái cây (Hương giống trái cam, mận), Ngọt hậu, hương socola và caramel nhẹ nhàng\r\n- ROBUSTA LÂM HÀ\r\nVùng: Xã Hoài Đức, Lâm Hà, Lâm Đồng\r\nĐộ cao: 1000M\r\nGiống: Búp Tím\r\nSơ chế: Honey\r\nHương vị: Chua nhẹ, Ngọt dịu, Độ béo cao, Hậu vị êm",
                ExpextDate = DateTime.Parse("12/12/2024"),
                CreateDate = DateTime.Now,
                UpdatetDate = null,
                status = true,
                RoastLevelID = 3,
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                ProductID = 5,
                ProductName = "Cà phê Robusta Lâm Hà Natural GU ĐẬM Rang Medium Pha Máy Pha Phin",
                Introduction = "Thông tin vùng trồng hạt cà phê:\r\n- Farm : An Coffee Farm - Farm Robusta chất lượng cao\r\n- Giống: Búp tím\r\n- Sơ chế: Natural\r\n- Độ cao: 1000 -1100m\r\n- Hương vị: Đậm đà, Ngọt Béo, Đắng nhẹ",
                Description = "An Coffee Farm là Farm Robusta chất lượng cao nằm ở độ cao 1000m, thuộc xã Hoài Đức, Lâm Hà, Lâm Đồng. Nông hộ cà phê được trực tiếp quản lý chất lượng bởi chị Duyên Anh, một người dành rất nhiều tâm huyết với hạt Robusta Việt Nam, luôn cố gắng cải thiện công nghệ cũng như chất lượng gieo trồng để mỗi vụ mùa đều cho ra sản phẩm hạt Robusta tốt hơn. \r\nLà một khách hàng của An Coffee Farm, xưởng rang BeanHop hoàn toàn yên tâm về chất lượng hạt, mỗi mùa vụ đều đạt độ tinh tế về hương vị tốt hơn mùa trước. Cà phê Robusta Lâm Hà sơ chế Natural được xưởng BeanHop cung cấp với mức rang Medium-Dark Roast. Hạt thể hiện rất tốt hương vị cà phê đậm đà phong cách truyền thống, ngọt béo dày dặn, hậu vị hơi đắng nhẹ khi sử dụng cho pha phin, pha máy espresso, ấm mokapot\r\n\r\nCT máy Espresso - Hạt Medium Roast \r\nCà phê sử dụng: 18GR (doubleshot) \r\nThu được 40GR Espresso \r\nTỉ lệ gram in-out: 1:2,2\r\nNhiệt độ nước: 92-93*C \r\nThời gian pha: 25-27 giây",
                ExpextDate = DateTime.Parse("12/12/2024"),
                CreateDate = DateTime.Now,
                UpdatetDate = null,
                status = true,
                RoastLevelID = 3,
            });
            #endregion

            #region Price
            modelBuilder.Entity<Price>().HasData(new Price
            {
                PriceID= 1,
                Weight = 200, 
                PackagingType = "Nguyên Hạt",
                Cost = 51000,
                status= true,
                ProductID= 1,
            });
            modelBuilder.Entity<Price>().HasData(new Price
            {
                PriceID = 2,
                Weight = 500,
                PackagingType = "Thô vừa",
                Cost = 102000,
                status = true,
                ProductID = 1,
            });
            modelBuilder.Entity<Price>().HasData(new Price
            {
                PriceID = 3,
                Weight = 200,
                PackagingType = "Nguyên Hạt",
                Cost = 51000,
                status = true,
                ProductID = 2,
            });
            modelBuilder.Entity<Price>().HasData(new Price
            {
                PriceID = 4,
                Weight = 500,
                PackagingType = "Thô vừa",
                Cost = 102000,
                status = true,
                ProductID = 2,
            });
            #endregion
        }
    }
}
