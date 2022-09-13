using ShopOnline.DataAccess.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.DataAccess.Repository.Contracts
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProducts();
        Task<IEnumerable<Category>> GetCategories();
        Task<Product> GetProduct(int id);
        Task<Category> GetCategory(int id);

    }
}
