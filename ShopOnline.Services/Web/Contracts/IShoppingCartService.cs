using ShopOnline.DataAccess.DTOs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Services.Web.Contracts
{
    public interface IShoppingCartService
    {
        Task<List<CartItemDTO>> GetCartItems(int userID);
        Task<CartItemDTO> AddCartItem(CartItemToAddDTO cartItemToAddDTO);
        Task<CartItemDTO> DeleteCartItem(int id);
        Task<CartItemDTO> UpdateCount(CartItemCountUpdateDTO updateDTO);
    }
}
