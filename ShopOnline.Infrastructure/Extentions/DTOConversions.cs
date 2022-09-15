using ShopOnline.DataAccess.DTOs;
using ShopOnline.DataAccess.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Infrastructure.Extentions
{
    public static class DTOConversions
    {
        public static IEnumerable<ProductDTO> ConvertToDTO(
            this IEnumerable<Product> products, IEnumerable<Category> categories)
        {
            return (from product in products
                    join category in categories
                    on product.CategoryId equals category.Id
                    select new ProductDTO
                    {
                        Id=product.Id,
                        Name = product.Name,
                        Description = product.Description,
                        ImageURL = product.ImageURL,
                        RetailPrice = product.RetailPrice,
                        Count = product.Count,
                        CategoryId = product.CategoryId,
                        CategoryName=category.Name
                    }).ToList();
        }
        public static ProductDTO ConvertToDTO(
    this Product product, Category category)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name=product.Name,
                Description=product.Description,
                ImageURL=product.ImageURL,
                RetailPrice=product.RetailPrice,
                Count=product.Count,
                CategoryId=product.CategoryId,
                CategoryName=category.Name
            };
        }
        public static IEnumerable<CartItemDTO> ConvertToDTO(
            this IEnumerable<CartItem> cartItems, IEnumerable<Product> products)
        {
            return (from cartItem in cartItems
                    join product in products
                    on cartItem.ProductId equals product.Id
                    select new CartItemDTO
                    {
                        Id = cartItem.Id,
                        ProductName = product.Name,
                        ProductDescription = product.Description,
                        ProductImageURL = product.ImageURL,
                        RetailPrice = product.RetailPrice,
                        CartId = cartItem.CartId,
                        Count = cartItem.Count,
                        TotalPrice = product.RetailPrice * cartItem.Count
                    }).ToList();
        }
        public static CartItemDTO ConvertToDTO(
            this CartItem cartItem, Product product)
        {
            return new CartItemDTO
            {
                Id = cartItem.Id,
                ProductName = product.Name,
                ProductDescription = product.Description,
                ProductImageURL = product.ImageURL,
                RetailPrice = product.RetailPrice,
                CartId = cartItem.CartId,
                Count = cartItem.Count,
                TotalPrice = product.RetailPrice * cartItem.Count
            };
        }
    }
}
