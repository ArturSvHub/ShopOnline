using Microsoft.AspNetCore.Components;

using ShopOnline.DataAccess.DTOs;
using ShopOnline.Services.Web.Contracts;

using System.Globalization;

namespace ShopOnline.Web.Pages
{
    public partial class Cart
    {
        [Inject]
        IShoppingCartService ShoppingCartService { get; set; }
        public List<CartItemDTO> CartItems { get; set; }
        public string ErrorMessage { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? TotalCount { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                CartItems = await ShoppingCartService.GetCartItems(MockUserForTest.UserId);
                SetValuesOnPage();
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
        protected async Task DeleteCartItem(int id)
        {
            var cartItemDTO = await ShoppingCartService.DeleteCartItem(id);
            RemoveCartItem(id);
            SetValuesOnPage();
        }
        protected async Task UpdateCountCartItem(int id,int count)
        {
            try
            {
                if(count>0)
                {
                    var updateItemDTO = new CartItemCountUpdateDTO
                    {
                        CartItemId = id,
                        Count = count
                    };
                    var returnedUpdateItemDTO= await ShoppingCartService.UpdateCount(updateItemDTO);
                    UpdateItemTotalPrice(returnedUpdateItemDTO);
                    SetValuesOnPage();
                }
                else
                {
                    var item=CartItems.FirstOrDefault(i=>i.Id==id);
                    if(item!=null)
                    {
                        item.Count = 1;
                        item.TotalPrice=item.RetailPrice;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private CartItemDTO GetCartItem(int id)
        {
            return CartItems.FirstOrDefault(i => i.Id == id);
        }
        private void RemoveCartItem(int id)
        {
            var cartItemDTO = GetCartItem(id);
            CartItems.Remove(cartItemDTO);
        }
        private void SetValuesOnPage()
        {
            TotalPrice = CartItems.Sum(p => p.TotalPrice);
            TotalCount = CartItems.Sum(c=>c.Count);
        }
        private void UpdateItemTotalPrice(CartItemDTO cartItemDTO)
        {
            var item = GetCartItem(cartItemDTO.Id);
            if(item!=null)
            {
                item.TotalPrice = cartItemDTO.RetailPrice * cartItemDTO.Count;
            }
        }
    }
}
