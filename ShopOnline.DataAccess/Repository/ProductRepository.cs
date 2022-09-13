using Microsoft.EntityFrameworkCore;

using ShopOnline.DataAccess.Entities;
using ShopOnline.DataAccess.Repository.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Category>> GetCategories()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories;
        }

        public async Task<Category> GetCategory(int id)
        {
            var category = await _context.Categories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetProduct(int id)
        {
            var product = await _context.Products.SingleOrDefaultAsync(c => c.Id == id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return products;
        }
    }
}
