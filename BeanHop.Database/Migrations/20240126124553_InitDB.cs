using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BeanHop.Database.Migrations
{
    /// <inheritdoc />
    public partial class InitDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Firstname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "RoastLevel",
                columns: table => new
                {
                    RoastLevelID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoastName = table.Column<string>(type: "ntext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoastLevel", x => x.RoastLevelID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
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
                name: "Favorite",
                columns: table => new
                {
                    FavoriteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorite", x => x.FavoriteID);
                    table.ForeignKey(
                        name: "FK_Favorite_AspNetUsers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Import",
                columns: table => new
                {
                    ImportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TotalWeight = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Import", x => x.ImportID);
                    table.ForeignKey(
                        name: "FK_Import_AspNetUsers_StaffID",
                        column: x => x.StaffID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    NotificationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "ntext", nullable: false),
                    Content = table.Column<string>(type: "ntext", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.NotificationID);
                    table.ForeignKey(
                        name: "FK_Notification_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalProductPrice = table.Column<double>(type: "float", nullable: false),
                    Discount = table.Column<double>(type: "float", nullable: false),
                    TotalOrderPrice = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_Order_AspNetUsers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "ntext", nullable: false),
                    Content = table.Column<string>(type: "ntext", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    StaffID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostID);
                    table.ForeignKey(
                        name: "FK_Post_AspNetUsers_StaffID",
                        column: x => x.StaffID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "ntext", nullable: false),
                    Introduction = table.Column<string>(type: "ntext", nullable: false),
                    Description = table.Column<string>(type: "ntext", nullable: false),
                    ExpextDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    RoastLevelID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Product_RoastLevel_RoastLevelID",
                        column: x => x.RoastLevelID,
                        principalTable: "RoastLevel",
                        principalColumn: "RoastLevelID");
                });

            migrationBuilder.CreateTable(
                name: "Bean",
                columns: table => new
                {
                    BeanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BeanName = table.Column<string>(type: "ntext", maxLength: 100, nullable: false),
                    Breed = table.Column<string>(type: "ntext", maxLength: 100, nullable: false),
                    Region = table.Column<string>(type: "ntext", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    ImportID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bean", x => x.BeanID);
                    table.ForeignKey(
                        name: "FK_Bean_Import_ImportID",
                        column: x => x.ImportID,
                        principalTable: "Import",
                        principalColumn: "ImportID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Method = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_Payment_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comment",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    PostID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comment", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comment_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Comment_Post_PostID",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteProduct",
                columns: table => new
                {
                    FavouriteID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    FavoriteID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteProduct", x => new { x.ProductID, x.FavouriteID });
                    table.ForeignKey(
                        name: "FK_FavoriteProduct_Favorite_FavoriteID",
                        column: x => x.FavoriteID,
                        principalTable: "Favorite",
                        principalColumn: "FavoriteID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FavoriteProduct_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    ImageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageName = table.Column<string>(type: "ntext", nullable: false),
                    ImageData = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: true),
                    PostID = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.ImageID);
                    table.ForeignKey(
                        name: "FK_Image_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Image_Post_PostID",
                        column: x => x.PostID,
                        principalTable: "Post",
                        principalColumn: "PostID");
                    table.ForeignKey(
                        name: "FK_Image_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID");
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<double>(type: "float", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Price",
                columns: table => new
                {
                    PriceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    PackagingType = table.Column<string>(type: "ntext", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Price", x => x.PriceID);
                    table.ForeignKey(
                        name: "FK_Price_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    RateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.RateID);
                    table.ForeignKey(
                        name: "FK_Rate_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Rate_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BeanProduct",
                columns: table => new
                {
                    BeanID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeanProduct", x => new { x.BeanID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_BeanProduct_Bean_BeanID",
                        column: x => x.BeanID,
                        principalTable: "Bean",
                        principalColumn: "BeanID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BeanProduct_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transport",
                columns: table => new
                {
                    TransportID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatetDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    PaymentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transport", x => x.TransportID);
                    table.ForeignKey(
                        name: "FK_Transport_Payment_PaymentID",
                        column: x => x.PaymentID,
                        principalTable: "Payment",
                        principalColumn: "PaymentID",
                        onDelete: ReferentialAction.Cascade);
                });

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
                    { 1, 0, "HCM", "76c547a2-c534-470d-85e0-d58fb468690d", "member1@gmail.com", true, "Name1", "LastName1", false, null, "member1@gmail.com", "member1@gmail.com", "AQAAAAIAAYagAAAAEDbtD0k66gQWohZqmjDb3vB3jPcPaOwSRRnGpXYWfHOfk5cviHcTxEaA50HBvCMSng==", null, false, "", true, false, "member1@gmail.com" },
                    { 2, 0, "HCM", "ec015e3c-65fe-4043-a69a-37c80540bc60", "member2@gmail.com", true, "Name2", "LastName2", false, null, "member2@gmail.com", "member2@gmail.com", "AQAAAAIAAYagAAAAEFFJPX3Qevton0JDQI8k4kGU3aEjAXDOidFC3/jTEQIjoXCh2dMwj07FpJgVnTViXg==", null, false, "", true, false, "member2@gmail.com" },
                    { 3, 0, "HCM", "affb5d9c-3eac-4a4f-b34c-5cfccde5de0a", "member3@gmail.com", true, "Name3", "LastName3", false, null, "member3@gmail.com", "member3@gmail.com", "AQAAAAIAAYagAAAAEKXvS5nJKEpYY4QtwtcBsx6d2wbpJ4sgcItAkKevqPpJVwbyANrMqFqshCwDqqfNeQ==", null, false, "", true, false, "member3@gmail.com" },
                    { 4, 0, "HCM", "8589b10e-ac62-470c-9fa8-1dc64dbee449", "member4@gmail.com", true, "Name4", "LastName4", false, null, "member4@gmail.com", "member4@gmail.com", "AQAAAAIAAYagAAAAEAsCGeC1ge9vvL2tZTmJf3uvo4kYrm0tNXqJGyfvfufo/68SaPwVXME1NhFe43DXuA==", null, false, "", true, false, "member4@gmail.com" },
                    { 5, 0, "HCM", "a95dbf93-8348-4685-a0ff-fc39053ccf02", "member5@gmail.com", true, "Name5", "LastName5", false, null, "member5@gmail.com", "member5@gmail.com", "AQAAAAIAAYagAAAAELgAjEhbt5QeAVvi9Cvbn8QHWS4BTps9J/TJsyEl7Wzy1SR00BLFR7C5PgPrEFtrRQ==", null, false, "", true, false, "member5@gmail.com" },
                    { 6, 0, "HCM", "c19ca8bf-a23e-4fe3-bf8a-07bd3bf157d0", "member6@gmail.com", true, "Name6", "LastName6", false, null, "member6@gmail.com", "member6@gmail.com", "AQAAAAIAAYagAAAAEMQyE7AVQIFm3ioJPrkqZf3uzfC9gmdDyMkf5AoLRfN+/HJ2y1ladHFUVsHQpVQQYg==", null, false, "", true, false, "member6@gmail.com" },
                    { 7, 0, "HCM", "0ff6e154-e97a-4fa2-8106-9ba5e894a564", "member7@gmail.com", true, "Name7", "LastName7", false, null, "member7@gmail.com", "member7@gmail.com", "AQAAAAIAAYagAAAAEBzfTy7T5464AChiLca340IOYi2bMhW4D6O59BsqE1LiCyPuBY//tt5CwRuZUuRtcA==", null, false, "", true, false, "member7@gmail.com" },
                    { 8, 0, "HCM", "65f103b4-36ca-488b-865a-11ad0394cdc2", "member8@gmail.com", true, "Name8", "LastName8", false, null, "member8@gmail.com", "member8@gmail.com", "AQAAAAIAAYagAAAAEK1GVjhuDzgBNC4frfLGG7NMe+76hDL7VGM8XsrTlWGhgKcxYs8boAf1yh7/acevzQ==", null, false, "", true, false, "member8@gmail.com" },
                    { 9, 0, "HCM", "798612c8-5ff4-483a-a5c6-ab5cf378d532", "member9@gmail.com", true, "Name9", "LastName9", false, null, "member9@gmail.com", "member9@gmail.com", "AQAAAAIAAYagAAAAEFeHDHUOipPYT4XWfx4NuByuBu9rzCYOjnWInYII4HDc7e4zGK9yL1IBYuaWMrPUUg==", null, false, "", true, false, "member9@gmail.com" },
                    { 10, 0, "HCM", "4c887226-52d5-471a-b4a7-5179f65d9820", "member10@gmail.com", true, "Name10", "LastName10", false, null, "member10@gmail.com", "member10@gmail.com", "AQAAAAIAAYagAAAAEBsYL2gGKpwnG8h0WovB8beQmQrZEL4vHaLW3VWiv8lZ4KjvlvsVu0zRPUiuwf7opQ==", null, false, "", true, false, "member10@gmail.com" },
                    { 11, 0, "HCM", "fdd0b814-bfc6-46d8-9501-b76ec091b7a7", "staff11@gmail.com", true, "Name11", "LastName11", false, null, "staff11@gmail.com", "staff11@gmail.com", "AQAAAAIAAYagAAAAEETGpcr/+8x7vCF5u+QjFpfUOMpVIEIcYyZX3FK1SgoUs3hg+Bp7as/1N2QudIyPug==", null, false, "", true, false, "staff11@gmail.com" },
                    { 12, 0, "HCM", "16dd9f8c-d843-49a9-878b-248bba433d00", "staff12@gmail.com", true, "Name12", "LastName12", false, null, "staff12@gmail.com", "staff12@gmail.com", "AQAAAAIAAYagAAAAEKL4tcOOCHzWQwuVAzfKCDEuvV4Yv9cdRpDQzG7BDm5Zys6rpTOH21ggvshxiyIaXA==", null, false, "", true, false, "staff12@gmail.com" },
                    { 13, 0, "HCM", "7b07c7aa-209e-46d3-ace0-68933de3c146", "staff13@gmail.com", true, "Name13", "LastName13", false, null, "staff13@gmail.com", "staff13@gmail.com", "AQAAAAIAAYagAAAAEBP6s3bJl0utl7YDHK8JPZwnco6jKVlCRT0SXlyM+C/OgzUq/ZgNt8w+HNOy2Opa2A==", null, false, "", true, false, "staff13@gmail.com" },
                    { 14, 0, "HCM", "beb26a04-b1c4-4108-a062-e7566449e2c8", "staff14@gmail.com", true, "Name14", "LastName14", false, null, "staff14@gmail.com", "staff14@gmail.com", "AQAAAAIAAYagAAAAEArxZWojs1A0t2QiShAvzCraAZE5lfHLqLnlzw8DtbH2oUZ+x6PIARfWUTSkh64unA==", null, false, "", true, false, "staff14@gmail.com" },
                    { 15, 0, "HCM", "566a70d1-9ade-45dd-929a-747377f26d6f", "staff15@gmail.com", true, "Name15", "LastName15", false, null, "staff15@gmail.com", "staff15@gmail.com", "AQAAAAIAAYagAAAAEHzQA5vNFTAZ0OxLU720ev4hI+hirE+Pre0Z3ZmL3atFOHzLHRjpawAy3djJ9/EEkg==", null, false, "", true, false, "staff15@gmail.com" }
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
                    { 1, new DateTime(2024, 1, 26, 19, 45, 52, 825, DateTimeKind.Local).AddTicks(2226), "Nằm ở độ cao 1500-1600m so với mực nước biển, Núi Min (xã Trạm Hành, Lâm Đồng) là vùng đất được thiên nhiên ưu ái khí hậu và thổ nhưỡng phù hợp phát triển cà phê Arabica. Hạt cà phê Núi Min đạt được những nốt hương tinh tế từ trái cây, socola, hạt khô, và quan trọng trên hết là sự cân bằng của vị chua-ngọt cùng cảm nhận êm ái tới tận hậu vị. \r\nVốn ý thức được từ sớm về giá trị của việc phát triển cà phê chất lượng cao, các nông hộ tại Núi Min vẫn luôn quan tâm tới chất lượng trồng trọt và thu hái, đảm bảo thu hoạch trái chín, hái bằng tay, sơ chế đúng tiêu chuẩn...\r\nCà phê Núi Min, Trạm Hành được xưởng rang BeanHop gửi tới khách hàng là hạt được sơ chế ướt bởi Lâm Tuyền Farm, sàng cỡ 18 đồng đều, hạt đẹp không lỗi. BeanHop cung cấp hai mức rang khác nhau là Light Roast và Medium Roast, đáp ứng nhu cầu đa dạng của khách hàng uống pha máy espresso/mokapot/phin cũng như khách hàng yêu thích cà phê rang light pha thủ công/ủ coldbrew\"\r\nDưới đây là một số công thức pha:\r\n- Công thức pha  Pour over (giấy lọc) - Hạt Light Roast\r\nCà phê sử dụng: 15GR\r\nTỉ lệ pha: 1:13 - 1:15\r\nNhiệt độ nước: 93*C\r\nThời gian pha: 2 phút 30 giây\r\n- Công thức pha máy Espresso - Hạt Medium Roast\r\nCà phê sử dụng: 18GR (doubleshot)\r\nThu được 36GR Espresso\r\nTỉ lệ gram in-out: 1:2\r\nNhiệt độ nước: 93-94*C\r\nThời gian pha: 27-3 giây\r\n- Công thức pha Ủ Coldbrew: \r\nTỉ lệ cà phê-nước 1:12 . Thời gian ủ 12 tiếng cho rang Medium, 15-18 tiếng cho rang Light \r\nSau khi lọc xong bã thì giữ lạnh coldbrew trong tủ lạnh thêm 2 tiếng trước khi thưởng thức", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thông tin cơ bản:\r\n- Farm : Lâm Tuyền, Núi Min, Trạm Hành\r\n- Giống: Catimor\r\n- Sơ chế: Full Washed\r\n- Độ cao: 1500 - 1600m\r\n- Hương vị: Plum Acidity, Caramel, Smooth body and sweetness", "Cà phê Arabica Núi Min Rang Medium Pha Máy Pha Phin Ủ Coldbrew", 1, null, true },
                    { 2, new DateTime(2024, 1, 26, 19, 45, 52, 825, DateTimeKind.Local).AddTicks(2265), "An Coffee Farm là Farm Robusta chất lượng cao nằm ở độ cao 1000m, thuộc xã Hoài Đức, Lâm Hà, Lâm Đồng. Nông hộ cà phê được trực tiếp quản lý chất lượng bởi chị Duyên Anh, một người dành rất nhiều tâm huyết với hạt Robusta Việt Nam, luôn cố gắng cải thiện công nghệ cũng như chất lượng gieo trồng để mỗi vụ mùa đều cho ra sản phẩm hạt Robusta tốt hơn. \r\nLà một khách hàng của An Coffee Farm, xưởng rang BeanHop hoàn toàn yên tâm về chất lượng hạt, mỗi mùa vụ đều đạt độ tinh tế về hương vị  ổn định hoặc tốt hơn mùa trước. Cà phê Robusta Lâm Hà sơ chế Honey (hình thức sơ chế phơi khô khi phần vỏ ngoài và thịt của trái cà phê được loại bỏ 1 phần) được xưởng BeanHop cung cấp với mức rang Medium Roast hoặc Medium-Dark Roast. Hạt thể hiện rất tốt hương vị chua nhẹ trái cây, ngọt béo dày dặn, hậu vị êm ái khi sử dụng cho pha phin, pha máy espresso, ấm mokapot, ủ coldbrew...\r\n\r\nCông thức pha máy Espresso - Hạt Medium Roast \r\nCà phê sử dụng: 18GR (doubleshot) \r\nThu được 40GR Espresso \r\nTỉ lệ gram in-out: 1:2,2\r\nNhiệt độ nước: 92-93*C \r\nThời gian pha: 25-27 giây\r\n", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thông tin vùng trồng hạt cà phê:\r\n- Farm : An Coffee Farm - Farm Robusta chất lượng cao\r\n- Giống: Búp Tím\r\n- Sơ chế: Honey\r\n- Độ cao: 1000 -1100m\r\n- Hương vị: Chua nhẹ, Béo và êm, độ đậm vừa phải", "Cà phê Robusta Lâm Hà Honey GU NHẸ Rang Medium Pha Phin Pha Máy", 1, null, true },
                    { 3, new DateTime(2024, 1, 26, 19, 45, 52, 825, DateTimeKind.Local).AddTicks(2278), "Cà phê là sự phối trộn giữa 2 dòng cà phê chất lượng cao:\r\n.  80% Robusta Lâm Hà (Natural)\r\n. 20% Arabica Cầu Đất (Washed)\r\nĐem tới Hương vị: Hương Dark Chocolate Mạnh, Có hậu vị dài\r\nĐậm đà, Ngọt béo, Dày vị\r\n\r\nThông tin về dòng cà phê Arabica và Robusta: \r\n- ROBUSTA LÂM HÀ\r\nVùng: Xã Hoài Đức, Lâm Hà, Lâm Đồng\r\nĐộ cao: 1000M\r\nGiống: BÚP TÍM\r\nSơ chế: Natural\r\nHương vị: Thơm hương Dark Chocolate, Đậm đà, Ngọt sâu, Hậu vị dài. Có chút đắng nhẹ hậu vị\r\n- VIỆT NAM ARABICA CẦU ĐẤT\r\nVùng: Cầu Đất, Đà Lạt, Lâm Đồng\r\nĐộ cao: 1500M\r\nGiống: Catimor\r\nSơ chế: WASHED\r\nHương vị: Đậm Đà, Chocote, Vị béo cao của hạt khô (Nutty), Chua nhẹ", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "COFFEE BLENDED: 8 ROBUSTA - 2 ARABICA\r\nDÀNH CHO GU UỐNG ĐẬM\r\nPHÙ HỢP PHA PHIN, PHA MÁY (GU ĐẬM)", "Cà phê Blend GU ĐẬM 8 Robusta 2 Arabica Pha Phin", 2, null, true },
                    { 4, new DateTime(2024, 1, 26, 19, 45, 52, 825, DateTimeKind.Local).AddTicks(2290), "Cà phê là sự phối trộn giữa 2 dòng cà phê chất lượng cao:\r\n. 70% Arabica Cầu Đất (Washed)\r\n. 30% Robusta Lâm Hà (Honey)\r\nĐem tới hương vị: Chua thanh, Ngọt hậu\r\nHương Chocolate, Caramel Ngọt béo, Độ đậm vừa phải\r\n\r\nThông tin về dòng cà phê Arabica và Robusta: \r\n- VIỆT NAM ARABICA NÚI MIN\r\nVùng: Lâm Tuyền, Núi Min, Xã Trạm Hành\r\nĐộ cao: 1600M+\r\nGiống: Catimor\r\nSơ chế: WASHED\r\nHương vị: Chua thanh trái cây (Hương giống trái cam, mận), Ngọt hậu, hương socola và caramel nhẹ nhàng\r\n- ROBUSTA LÂM HÀ\r\nVùng: Xã Hoài Đức, Lâm Hà, Lâm Đồng\r\nĐộ cao: 1000M\r\nGiống: Búp Tím\r\nSơ chế: Honey\r\nHương vị: Chua nhẹ, Ngọt dịu, Độ béo cao, Hậu vị êm", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "COFFEE BLENDED: 7 ARABICA - 3 ROBUSTA\r\nDÀNH CHO GU UỐNG NHẸ\r\nPHÙ HỢP PHA PHIN, PHA ESPRESSO (MÁY, DỤNG CỤ PHA CẦM TAY, ẤM MOKA...)\r\nỦ COLDBREW", "Cà phê Blend GU NHẸ 7 Arabica 3 Robusta Pha Phin Pha Máy", 3, null, true },
                    { 5, new DateTime(2024, 1, 26, 19, 45, 52, 825, DateTimeKind.Local).AddTicks(2301), "An Coffee Farm là Farm Robusta chất lượng cao nằm ở độ cao 1000m, thuộc xã Hoài Đức, Lâm Hà, Lâm Đồng. Nông hộ cà phê được trực tiếp quản lý chất lượng bởi chị Duyên Anh, một người dành rất nhiều tâm huyết với hạt Robusta Việt Nam, luôn cố gắng cải thiện công nghệ cũng như chất lượng gieo trồng để mỗi vụ mùa đều cho ra sản phẩm hạt Robusta tốt hơn. \r\nLà một khách hàng của An Coffee Farm, xưởng rang BeanHop hoàn toàn yên tâm về chất lượng hạt, mỗi mùa vụ đều đạt độ tinh tế về hương vị tốt hơn mùa trước. Cà phê Robusta Lâm Hà sơ chế Natural được xưởng BeanHop cung cấp với mức rang Medium-Dark Roast. Hạt thể hiện rất tốt hương vị cà phê đậm đà phong cách truyền thống, ngọt béo dày dặn, hậu vị hơi đắng nhẹ khi sử dụng cho pha phin, pha máy espresso, ấm mokapot\r\n\r\nCT máy Espresso - Hạt Medium Roast \r\nCà phê sử dụng: 18GR (doubleshot) \r\nThu được 40GR Espresso \r\nTỉ lệ gram in-out: 1:2,2\r\nNhiệt độ nước: 92-93*C \r\nThời gian pha: 25-27 giây", new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thông tin vùng trồng hạt cà phê:\r\n- Farm : An Coffee Farm - Farm Robusta chất lượng cao\r\n- Giống: Búp tím\r\n- Sơ chế: Natural\r\n- Độ cao: 1000 -1100m\r\n- Hương vị: Đậm đà, Ngọt Béo, Đắng nhẹ", "Cà phê Robusta Lâm Hà Natural GU ĐẬM Rang Medium Pha Máy Pha Phin", 3, null, true }
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
                name: "IX_Bean_ImportID",
                table: "Bean",
                column: "ImportID");

            migrationBuilder.CreateIndex(
                name: "IX_BeanProduct_ProductID",
                table: "BeanProduct",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_PostID",
                table: "Comment",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Comment_UserID",
                table: "Comment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Favorite_CustomerID",
                table: "Favorite",
                column: "CustomerID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteProduct_FavoriteID",
                table: "FavoriteProduct",
                column: "FavoriteID");

            migrationBuilder.CreateIndex(
                name: "IX_Image_PostID",
                table: "Image",
                column: "PostID");

            migrationBuilder.CreateIndex(
                name: "IX_Image_ProductID",
                table: "Image",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Image_UserID",
                table: "Image",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Import_StaffID",
                table: "Import",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_UserID",
                table: "Notification",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerID",
                table: "Order",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductID",
                table: "OrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_OrderID",
                table: "Payment",
                column: "OrderID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Post_StaffID",
                table: "Post",
                column: "StaffID");

            migrationBuilder.CreateIndex(
                name: "IX_Price_ProductID",
                table: "Price",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_RoastLevelID",
                table: "Product",
                column: "RoastLevelID");

            migrationBuilder.CreateIndex(
                name: "IX_Rate_ProductID",
                table: "Rate",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Rate_UserID",
                table: "Rate",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Transport_PaymentID",
                table: "Transport",
                column: "PaymentID",
                unique: true);
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
                name: "BeanProduct");

            migrationBuilder.DropTable(
                name: "Comment");

            migrationBuilder.DropTable(
                name: "FavoriteProduct");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Price");

            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DropTable(
                name: "Transport");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Bean");

            migrationBuilder.DropTable(
                name: "Favorite");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Import");

            migrationBuilder.DropTable(
                name: "RoastLevel");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
