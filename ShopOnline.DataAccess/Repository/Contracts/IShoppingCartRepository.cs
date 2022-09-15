using ShopOnline.DataAccess.DTOs;
using ShopOnline.DataAccess.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.DataAccess.Repository.Contracts
{
    public interface IShoppingCartRepository
    {
        Task<CartItem> AddItem(CartItemToAddDTO cartItemToAddDTO);
        Task<CartItem> GetItem(int id);
        Task<CartItem> UpdateCount(int id,CartItemCountUpdateDTO cartItemCountUpdateDTO);
        Task<CartItem> DeleteItem(int id);
        Task<IEnumerable<CartItem>> GetItemsForUser(int userId);
    }
}
