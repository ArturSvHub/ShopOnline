using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CartId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IconCSS = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RetailPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PurshasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Count = table.Column<int>(type: "int", nullable: true),
                    Article = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsInShopping = table.Column<bool>(type: "bit", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "UserId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "IconCSS", "Name" },
                values: new object[,]
                {
                    { 1, null, "fas fa-spa", "Косметика" },
                    { 2, null, "fas fa-couch", "Мебель" },
                    { 3, null, "fas fa-headphones", "Электроника" },
                    { 4, null, "fas fa-shoe-prints", "Обувь" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "CategoryId", "Count", "Description", "ImageURL", "IsInShopping", "Name", "PurshasePrice", "RetailPrice" },
                values: new object[,]
                {
                    { 1, null, 1, 100, "Набор от Glossier, содержащий средства по уходу за кожей, волосами и другую косметику", "/Images/Beauty/Beauty1.png", null, "Glossier - Косметический набор", null, 100m },
                    { 2, null, 1, 45, "Набор, предоставленный Curology, содержащий средства по уходу за кожей", "/Images/Beauty/Beauty2.png", null, "Curology - Набор ухода за кожей", null, 50m },
                    { 3, null, 1, 30, "Набор, предоставленный Curology, содержащий средства по уходу за кожей", "/Images/Beauty/Beauty3.png", null, "Cocooil - Органическое Кокосовое масло", null, 20m },
                    { 4, null, 1, 60, "Набор от Schwarzkopf, содержащий средства по уходу за кожей и волосами", "/Images/Beauty/Beauty4.png", null, "Schwarzkopf - Набор для ухода за волосами и кожей", null, 50m },
                    { 5, null, 1, 85, "Набор для ухода за кожей, содержащий средства по уходу за кожей и волосами", "/Images/Beauty/Beauty5.png", null, "Набор для ухода за кожей", null, 30m },
                    { 6, null, 3, 120, "Air Pods - знаменитые беспроводные наушники-вкладыши от яблочной компании", "/Images/Electronic/Electronics1.png", null, "Air Pods", null, 100m },
                    { 7, null, 3, 200, "Наушники On-ear Golden - эти наушники не являются беспроводными", "/Images/Electronic/Electronics2.png", null, "Наушники On-ear Golden", null, 40m },
                    { 8, null, 3, 300, "Наушники On-ear Black - эти наушники не являются беспроводными", "/Images/Electronic/Electronics3.png", null, "Наушники On-ear Black", null, 40m },
                    { 9, null, 3, 20, "Sennheiser Цифровая камера - Высококачественная цифровая камера от Sennheiser - включает в себя штатив", "/Images/Electronic/Electronic4.png", null, "Sennheiser Цифровая камера со штативом", null, 600m },
                    { 10, null, 3, 15, "Цифровая камера Canon - Высококачественная цифровая камера, предоставляемая компанией Canon", "/Images/Electronic/Electronic5.png", null, "Цифровая камера Canon", null, 500m },
                    { 11, null, 3, 60, "Gameboy - Предоставлено Nintendo", "/Images/Electronic/technology6.png", null, "Nintendo Gameboy", null, 100m },
                    { 12, null, 2, 212, "Очень удобное офисное кресло из черной кожи", "/Images/Furniture/Furniture1.png", null, "Офисное Кресло Из Черной Кожи", null, 50m },
                    { 13, null, 2, 112, "Очень удобное офисное кресло из розовой кожи", "/Images/Furniture/Furniture2.png", null, "Розовое Кожаное Офисное Кресло", null, 50m },
                    { 14, null, 2, 90, "Очень удобное кресло для отдыха", "/Images/Furniture/Furniture3.png", null, "Кресло для отдыха", null, 70m },
                    { 15, null, 2, 95, "Очень удобное серое кресло для отдыха", "/Images/Furniture/Furniture4.png", null, "Серое Кресло Для Отдыха", null, 120m },
                    { 16, null, 2, 100, "Бело-голубая фарфоровая настольная лампа", "/Images/Furniture/Furniture6.png", null, "Фарфоровая настольная Лампа", null, 15m },
                    { 17, null, 2, 73, "Офисная Настольная Лампа", "/Images/Furniture/Furniture7.png", null, "Офисная Настольная Лампа", null, 20m },
                    { 18, null, 4, 50, "Удобные кроссовки Puma большинства размеров", "/Images/Shoes/Shoes1.png", null, "Кроссовки Puma", null, 100m },
                    { 19, null, 4, 60, "Разноцветные кеды - доступны в большинстве размеров", "/Images/Shoes/Shoes2.png", null, "Разноцветные кеды", null, 150m },
                    { 20, null, 4, 70, "Синие кроссовки Nike - доступны в большинстве размеров", "/Images/Shoes/Shoes3.png", null, "Синие кроссовки Nike", null, 200m },
                    { 21, null, 4, 120, "Разноцветные кеды Hummel - доступны в большинстве размеров", "/Images/Shoes/Shoes4.png", null, "Разноцветные кеды Hummel", null, 120m },
                    { 22, null, 4, 100, "Красные кроссовки Nike - доступны в большинстве размеров", "/Images/Shoes/Shoes5.png", null, "Красные кроссовки Nike", null, 200m },
                    { 23, null, 4, 150, "Сандали Birkenstock - доступны в большинстве размеров", "/Images/Shoes/Shoes6.png", null, "Сандали Birkenstock", null, 50m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Владимир" },
                    { 2, "Светлана" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
