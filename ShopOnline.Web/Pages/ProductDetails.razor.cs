using Microsoft.AspNetCore.Components;

using ShopOnline.DataAccess.DTOs;
using ShopOnline.Services.Web.Contracts;

namespace ShopOnline.Web.Pages
{
    public partial class ProductDetails
    {
        [Parameter]
        public int Id { get; set; }
        public IProductService ProductService { get; set; }
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
    }
}
