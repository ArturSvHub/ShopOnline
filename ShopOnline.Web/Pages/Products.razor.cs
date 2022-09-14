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
        protected override async Task OnInitializedAsync()
        {
            ProductsList = await ProductService.GetProducts();
        }
        protected IOrderedEnumerable
            <IGrouping<int?,ProductDTO>>GetGroupedProductsByCategory()
        {
             return from product in ProductsList
                    group product by product.CategoryId
                    into prodByCatGroup 
                    orderby prodByCatGroup.Key
                    select prodByCatGroup;
        }
        protected string GetCategoryName
            (IGrouping<int?,ProductDTO> groupedProductDTOs)
        {
            return groupedProductDTOs
                .FirstOrDefault(pg => pg.CategoryId == groupedProductDTOs.Key).CategoryName;
        }
    }
}
