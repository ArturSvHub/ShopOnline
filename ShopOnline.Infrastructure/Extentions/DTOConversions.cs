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
    }
}
