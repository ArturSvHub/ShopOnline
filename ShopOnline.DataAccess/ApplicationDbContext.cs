using Microsoft.EntityFrameworkCore;

using ShopOnline.DataAccess.Entities;

namespace ShopOnline.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //Products
            //Beauty Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 1,
                Name = "Glossier - Косметический набор",
                Description = "Набор от Glossier, содержащий средства по уходу за кожей, волосами и другую косметику",
                ImageURL = "/Images/Beauty/Beauty1.png",
                RetailPrice = 100,
                Count = 100,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 2,
                Name = "Curology - Набор ухода за кожей",
                Description = "Набор, предоставленный Curology, содержащий средства по уходу за кожей",
                ImageURL = "/Images/Beauty/Beauty2.png",
                RetailPrice = 50,
                Count = 45,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 3,
                Name = "Cocooil - Органическое Кокосовое масло",
                Description = "Набор, предоставленный Curology, содержащий средства по уходу за кожей",
                ImageURL = "/Images/Beauty/Beauty3.png",
                RetailPrice = 20,
                Count = 30,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 4,
                Name = "Schwarzkopf - Набор для ухода за волосами и кожей",
                Description = "Набор от Schwarzkopf, содержащий средства по уходу за кожей и волосами",
                ImageURL = "/Images/Beauty/Beauty4.png",
                RetailPrice = 50,
                Count = 60,
                CategoryId = 1

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 5,
                Name = "Набор для ухода за кожей",
                Description = "Набор для ухода за кожей, содержащий средства по уходу за кожей и волосами",
                ImageURL = "/Images/Beauty/Beauty5.png",
                RetailPrice = 30,
                Count = 85,
                CategoryId = 1

            });
            //Electronics Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 6,
                Name = "Air Pods",
                Description = "Air Pods - знаменитые беспроводные наушники-вкладыши от яблочной компании",
                ImageURL = "/Images/Electronic/Electronics1.png",
                RetailPrice = 100,
                Count = 120,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 7,
                Name = "Наушники On-ear Golden",
                Description = "Наушники On-ear Golden - эти наушники не являются беспроводными",
                ImageURL = "/Images/Electronic/Electronics2.png",
                RetailPrice = 40,
                Count = 200,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 8,
                Name = "Наушники On-ear Black",
                Description = "Наушники On-ear Black - эти наушники не являются беспроводными",
                ImageURL = "/Images/Electronic/Electronics3.png",
                RetailPrice = 40,
                Count = 300,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 9,
                Name = "Sennheiser Цифровая камера со штативом",
                Description = "Sennheiser Цифровая камера - Высококачественная цифровая камера от Sennheiser - включает в себя штатив",
                ImageURL = "/Images/Electronic/Electronic4.png",
                RetailPrice = 600,
                Count = 20,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 10,
                Name = "Цифровая камера Canon",
                Description = "Цифровая камера Canon - Высококачественная цифровая камера, предоставляемая компанией Canon",
                ImageURL = "/Images/Electronic/Electronic5.png",
                RetailPrice = 500,
                Count = 15,
                CategoryId = 3

            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 11,
                Name = "Nintendo Gameboy",
                Description = "Gameboy - Предоставлено Nintendo",
                ImageURL = "/Images/Electronic/technology6.png",
                RetailPrice = 100,
                Count = 60,
                CategoryId = 3
            });
            //Furniture Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 12,
                Name = "Офисное Кресло Из Черной Кожи",
                Description = "Очень удобное офисное кресло из черной кожи",
                ImageURL = "/Images/Furniture/Furniture1.png",
                RetailPrice = 50,
                Count = 212,
                CategoryId = 2
            });

            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 13,
                Name = "Розовое Кожаное Офисное Кресло",
                Description = "Очень удобное офисное кресло из розовой кожи",
                ImageURL = "/Images/Furniture/Furniture2.png",
                RetailPrice = 50,
                Count = 112,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 14,
                Name = "Кресло для отдыха",
                Description = "Очень удобное кресло для отдыха",
                ImageURL = "/Images/Furniture/Furniture3.png",
                RetailPrice = 70,
                Count = 90,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 15,
                Name = "Серое Кресло Для Отдыха",
                Description = "Очень удобное серое кресло для отдыха",
                ImageURL = "/Images/Furniture/Furniture4.png",
                RetailPrice = 120,
                Count = 95,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 16,
                Name = "Фарфоровая настольная Лампа",
                Description = "Бело-голубая фарфоровая настольная лампа",
                ImageURL = "/Images/Furniture/Furniture6.png",
                RetailPrice = 15,
                Count = 100,
                CategoryId = 2
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 17,
                Name = "Офисная Настольная Лампа",
                Description = "Офисная Настольная Лампа",
                ImageURL = "/Images/Furniture/Furniture7.png",
                RetailPrice = 20,
                Count = 73,
                CategoryId = 2
            });
            //Shoes Category
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 18,
                Name = "Кроссовки Puma",
                Description = "Удобные кроссовки Puma большинства размеров",
                ImageURL = "/Images/Shoes/Shoes1.png",
                RetailPrice = 100,
                Count = 50,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 19,
                Name = "Разноцветные кеды",
                Description = "Разноцветные кеды - доступны в большинстве размеров",
                ImageURL = "/Images/Shoes/Shoes2.png",
                RetailPrice = 150,
                Count = 60,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 20,
                Name = "Синие кроссовки Nike",
                Description = "Синие кроссовки Nike - доступны в большинстве размеров",
                ImageURL = "/Images/Shoes/Shoes3.png",
                RetailPrice = 200,
                Count = 70,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 21,
                Name = "Разноцветные кеды Hummel",
                Description = "Разноцветные кеды Hummel - доступны в большинстве размеров",
                ImageURL = "/Images/Shoes/Shoes4.png",
                RetailPrice = 120,
                Count = 120,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 22,
                Name = "Красные кроссовки Nike",
                Description = "Красные кроссовки Nike - доступны в большинстве размеров",
                ImageURL = "/Images/Shoes/Shoes5.png",
                RetailPrice = 200,
                Count = 100,
                CategoryId = 4
            });
            modelBuilder.Entity<Product>().HasData(new Product
            {
                Id = 23,
                Name = "Сандали Birkenstock",
                Description = "Сандали Birkenstock - доступны в большинстве размеров",
                ImageURL = "/Images/Shoes/Shoes6.png",
                RetailPrice = 50,
                Count = 150,
                CategoryId = 4
            });

            //Add users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Владимир"

            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Светлана"

            });

            //Create Shopping Cart for Users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1

            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2

            });
            //Add Product Categories
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 1,
                Name = "Косметика",
                IconCSS = "fas fa-spa"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 2,
                Name = "Мебель",
                IconCSS = "fas fa-couch"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 3,
                Name = "Электроника",
                IconCSS = "fas fa-headphones"
            });
            modelBuilder.Entity<Category>().HasData(new Category
            {
                Id = 4,
                Name = "Обувь",
                IconCSS = "fas fa-shoe-prints"
            });


        }

        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }
    }
}