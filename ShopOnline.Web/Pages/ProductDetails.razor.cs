using Microsoft.AspNetCore.Components;
using ShopOnline.DataAccess.DTOs;
using ShopOnline.Services.Web.Contracts;

namespace ShopOnline.Web.Pages
{
    public partial class ProductDetails
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public ProductDTO? Product { get; set; }
        public string ErrorMessage { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                Product = await ProductService.GetProductById(Id);
            }
            catch (Exception ex)
            {
                ErrorMessage=ex.Message;
            }
        }
        protected async Task AddToCart(CartItemToAddDTO cartItemToAddDTO)
        {
            try
            {
                var cartItemDTO = await ShoppingCartService.AddCartItem(cartItemToAddDTO);
                NavigationManager.NavigateTo("/cart");
            }
            catch (Exception)
            {

                //Log ex
            }
        }
    }
}
