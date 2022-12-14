// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopOnline.DataAccess;

#nullable disable

namespace ShopOnline.Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220918162304_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShopOnline.DataAccess.Entities.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("ShopOnline.DataAccess.Entities.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int?>("Count")
                        .HasColumnType("int");

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("ShopOnline.DataAccess.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IconCSS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-spa",
                            Name = "Косметика"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-couch",
                            Name = "Мебель"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-headphones",
                            Name = "Электроника"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-shoe-prints",
                            Name = "Обувь"
                        });
                });

            modelBuilder.Entity("ShopOnline.DataAccess.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Article")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int?>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsInShopping")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("PurshasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("RetailPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Count = 100,
                            Description = "Набор от Glossier, содержащий средства по уходу за кожей, волосами и другую косметику",
                            ImageURL = "/Images/Beauty/Beauty1.png",
                            Name = "Glossier - Косметический набор",
                            RetailPrice = 100m
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Count = 45,
                            Description = "Набор, предоставленный Curology, содержащий средства по уходу за кожей",
                            ImageURL = "/Images/Beauty/Beauty2.png",
                            Name = "Curology - Набор ухода за кожей",
                            RetailPrice = 50m
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Count = 30,
                            Description = "Набор, предоставленный Curology, содержащий средства по уходу за кожей",
                            ImageURL = "/Images/Beauty/Beauty3.png",
                            Name = "Cocooil - Органическое Кокосовое масло",
                            RetailPrice = 20m
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Count = 60,
                            Description = "Набор от Schwarzkopf, содержащий средства по уходу за кожей и волосами",
                            ImageURL = "/Images/Beauty/Beauty4.png",
                            Name = "Schwarzkopf - Набор для ухода за волосами и кожей",
                            RetailPrice = 50m
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Count = 85,
                            Description = "Набор для ухода за кожей, содержащий средства по уходу за кожей и волосами",
                            ImageURL = "/Images/Beauty/Beauty5.png",
                            Name = "Набор для ухода за кожей",
                            RetailPrice = 30m
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Count = 120,
                            Description = "Air Pods - знаменитые беспроводные наушники-вкладыши от яблочной компании",
                            ImageURL = "/Images/Electronic/Electronics1.png",
                            Name = "Air Pods",
                            RetailPrice = 100m
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Count = 200,
                            Description = "Наушники On-ear Golden - эти наушники не являются беспроводными",
                            ImageURL = "/Images/Electronic/Electronics2.png",
                            Name = "Наушники On-ear Golden",
                            RetailPrice = 40m
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Count = 300,
                            Description = "Наушники On-ear Black - эти наушники не являются беспроводными",
                            ImageURL = "/Images/Electronic/Electronics3.png",
                            Name = "Наушники On-ear Black",
                            RetailPrice = 40m
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Count = 20,
                            Description = "Sennheiser Цифровая камера - Высококачественная цифровая камера от Sennheiser - включает в себя штатив",
                            ImageURL = "/Images/Electronic/Electronic4.png",
                            Name = "Sennheiser Цифровая камера со штативом",
                            RetailPrice = 600m
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Count = 15,
                            Description = "Цифровая камера Canon - Высококачественная цифровая камера, предоставляемая компанией Canon",
                            ImageURL = "/Images/Electronic/Electronic5.png",
                            Name = "Цифровая камера Canon",
                            RetailPrice = 500m
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Count = 60,
                            Description = "Gameboy - Предоставлено Nintendo",
                            ImageURL = "/Images/Electronic/technology6.png",
                            Name = "Nintendo Gameboy",
                            RetailPrice = 100m
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Count = 212,
                            Description = "Очень удобное офисное кресло из черной кожи",
                            ImageURL = "/Images/Furniture/Furniture1.png",
                            Name = "Офисное Кресло Из Черной Кожи",
                            RetailPrice = 50m
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Count = 112,
                            Description = "Очень удобное офисное кресло из розовой кожи",
                            ImageURL = "/Images/Furniture/Furniture2.png",
                            Name = "Розовое Кожаное Офисное Кресло",
                            RetailPrice = 50m
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Count = 90,
                            Description = "Очень удобное кресло для отдыха",
                            ImageURL = "/Images/Furniture/Furniture3.png",
                            Name = "Кресло для отдыха",
                            RetailPrice = 70m
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Count = 95,
                            Description = "Очень удобное серое кресло для отдыха",
                            ImageURL = "/Images/Furniture/Furniture4.png",
                            Name = "Серое Кресло Для Отдыха",
                            RetailPrice = 120m
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Count = 100,
                            Description = "Бело-голубая фарфоровая настольная лампа",
                            ImageURL = "/Images/Furniture/Furniture6.png",
                            Name = "Фарфоровая настольная Лампа",
                            RetailPrice = 15m
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Count = 73,
                            Description = "Офисная Настольная Лампа",
                            ImageURL = "/Images/Furniture/Furniture7.png",
                            Name = "Офисная Настольная Лампа",
                            RetailPrice = 20m
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Count = 50,
                            Description = "Удобные кроссовки Puma большинства размеров",
                            ImageURL = "/Images/Shoes/Shoes1.png",
                            Name = "Кроссовки Puma",
                            RetailPrice = 100m
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Count = 60,
                            Description = "Разноцветные кеды - доступны в большинстве размеров",
                            ImageURL = "/Images/Shoes/Shoes2.png",
                            Name = "Разноцветные кеды",
                            RetailPrice = 150m
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Count = 70,
                            Description = "Синие кроссовки Nike - доступны в большинстве размеров",
                            ImageURL = "/Images/Shoes/Shoes3.png",
                            Name = "Синие кроссовки Nike",
                            RetailPrice = 200m
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Count = 120,
                            Description = "Разноцветные кеды Hummel - доступны в большинстве размеров",
                            ImageURL = "/Images/Shoes/Shoes4.png",
                            Name = "Разноцветные кеды Hummel",
                            RetailPrice = 120m
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Count = 100,
                            Description = "Красные кроссовки Nike - доступны в большинстве размеров",
                            ImageURL = "/Images/Shoes/Shoes5.png",
                            Name = "Красные кроссовки Nike",
                            RetailPrice = 200m
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Count = 150,
                            Description = "Сандали Birkenstock - доступны в большинстве размеров",
                            ImageURL = "/Images/Shoes/Shoes6.png",
                            Name = "Сандали Birkenstock",
                            RetailPrice = 50m
                        });
                });

            modelBuilder.Entity("ShopOnline.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Владимир"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Светлана"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
