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
                    { 1, null, "fas fa-spa", "Beauty" },
                    { 2, null, "fas fa-couch", "Furniture" },
                    { 3, null, "fas fa-headphones", "Electronics" },
                    { 4, null, "fas fa-shoe-prints", "Shoes" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Article", "CategoryId", "Count", "Description", "ImageURL", "IsInShopping", "Name", "PurshasePrice", "RetailPrice" },
                values: new object[,]
                {
                    { 1, null, 1, 100, "A kit provided by Glossier, containing skin care, hair care and makeup products", "/Images/Beauty/Beauty1.png", null, "Glossier - Beauty Kit", null, 100m },
                    { 2, null, 1, 45, "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty2.png", null, "Curology - Skin Care Kit", null, 50m },
                    { 3, null, 1, 30, "A kit provided by Curology, containing skin care products", "/Images/Beauty/Beauty3.png", null, "Cocooil - Organic Coconut Oil", null, 20m },
                    { 4, null, 1, 60, "A kit provided by Schwarzkopf, containing skin care and hair care products", "/Images/Beauty/Beauty4.png", null, "Schwarzkopf - Hair Care and Skin Care Kit", null, 50m },
                    { 5, null, 1, 85, "Skin Care Kit, containing skin care and hair care products", "/Images/Beauty/Beauty5.png", null, "Skin Care Kit", null, 30m },
                    { 6, null, 3, 120, "Air Pods - in-ear wireless headphones", "/Images/Electronic/Electronics1.png", null, "Air Pods", null, 100m },
                    { 7, null, 3, 200, "On-ear Golden Headphones - these headphones are not wireless", "/Images/Electronic/Electronics2.png", null, "On-ear Golden Headphones", null, 40m },
                    { 8, null, 3, 300, "On-ear Black Headphones - these headphones are not wireless", "/Images/Electronic/Electronics3.png", null, "On-ear Black Headphones", null, 40m },
                    { 9, null, 3, 20, "Sennheiser Digital Camera - High quality digital camera provided by Sennheiser - includes tripod", "/Images/Electronic/Electronic4.png", null, "Sennheiser Digital Camera with Tripod", null, 600m },
                    { 10, null, 3, 15, "Canon Digital Camera - High quality digital camera provided by Canon", "/Images/Electronic/Electronic5.png", null, "Canon Digital Camera", null, 500m },
                    { 11, null, 3, 60, "Gameboy - Provided by Nintendo", "/Images/Electronic/technology6.png", null, "Nintendo Gameboy", null, 100m },
                    { 12, null, 2, 212, "Very comfortable black leather office chair", "/Images/Furniture/Furniture1.png", null, "Black Leather Office Chair", null, 50m },
                    { 13, null, 2, 112, "Very comfortable pink leather office chair", "/Images/Furniture/Furniture2.png", null, "Pink Leather Office Chair", null, 50m },
                    { 14, null, 2, 90, "Very comfortable lounge chair", "/Images/Furniture/Furniture3.png", null, "Lounge Chair", null, 70m },
                    { 15, null, 2, 95, "Very comfortable Silver lounge chair", "/Images/Furniture/Furniture4.png", null, "Silver Lounge Chair", null, 120m },
                    { 16, null, 2, 100, "White and blue Porcelain Table Lamp", "/Images/Furniture/Furniture6.png", null, "Porcelain Table Lamp", null, 15m },
                    { 17, null, 2, 73, "Office Table Lamp", "/Images/Furniture/Furniture7.png", null, "Office Table Lamp", null, 20m },
                    { 18, null, 4, 50, "Comfortable Puma Sneakers in most sizes", "/Images/Shoes/Shoes1.png", null, "Puma Sneakers", null, 100m },
                    { 19, null, 4, 60, "Colorful trainsers - available in most sizes", "/Images/Shoes/Shoes2.png", null, "Colorful Trainers", null, 150m },
                    { 20, null, 4, 70, "Blue Nike Trainers - available in most sizes", "/Images/Shoes/Shoes3.png", null, "Blue Nike Trainers", null, 200m },
                    { 21, null, 4, 120, "Colorful Hummel Trainers - available in most sizes", "/Images/Shoes/Shoes4.png", null, "Colorful Hummel Trainers", null, 120m },
                    { 22, null, 4, 100, "Red Nike Trainers - available in most sizes", "/Images/Shoes/Shoes5.png", null, "Red Nike Trainers", null, 200m },
                    { 23, null, 4, 150, "Birkenstock Sandles - available in most sizes", "/Images/Shoes/Shoes6.png", null, "Birkenstock Sandles", null, 50m }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1, "Bob" },
                    { 2, "Sarah" }
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
