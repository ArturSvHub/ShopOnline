using Microsoft.EntityFrameworkCore;

using ShopOnline.DataAccess.DTOs;
using ShopOnline.DataAccess.Entities;
using ShopOnline.DataAccess.Repository.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.DataAccess.Repository
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly ApplicationDbContext context;

        public ShoppingCartRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        private async Task<bool> CartItemExists(int cartId,int productId)
        {
            return await context.CartItems.AnyAsync(
                x => x.CartId == cartId 
                && x.ProductId == productId);
        }
        public async Task<CartItem> AddItem(CartItemToAddDTO cartItemToAddDTO)
        {
            if(await CartItemExists(cartItemToAddDTO.CartId,cartItemToAddDTO.ProductId)==false)
            {
                var item = await (from product in context.Products
                                  where product.Id == cartItemToAddDTO.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDTO.CartId,
                                      ProductId = product.Id,
                                      Count = cartItemToAddDTO.Count
                                  }).SingleOrDefaultAsync();
                if (item != null)
                {
                    var result = await context.CartItems.AddAsync(item);
                    await context.SaveChangesAsync();
                    return result.Entity;
                }
            }
            return null;
        }

        public Task<CartItem> DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in context.Carts
                          join cartItem in context.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Count = cartItem.Count,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItemsForUser(int userId)
        {
            return await (from cart in context.Carts
                          join cartItem in context.CartItems
                          on cart.Id equals cartItem.Id
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Count = cartItem.Count,
                              CartId = cartItem.CartId
                          }).ToListAsync();
        }

        public Task<CartItem> UpdateCount(int id, CartItemCountUpdateDTO cartItemCountUpdateDTO)
        {
            throw new NotImplementedException();
        }
    }
}
