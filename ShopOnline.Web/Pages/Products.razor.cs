using Microsoft.AspNetCore.Components;

using ShopOnline.DataAccess.DTOs;
using ShopOnline.Services.Web.Contracts;

namespace ShopOnline.Web.Pages
{
    public partial class Products
    {
        [Inject]
        public IProductService? ProductService { get; set; }
        public IEnumerable<ProductDTO> ProductsList { get; set; }
        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
    }
}
