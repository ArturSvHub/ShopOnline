using Microsoft.AspNetCore.Components;

using ShopOnline.DataAccess.DTOs;

namespace ShopOnline.Web.Components
{
    public partial class DisplayProducts
    {
        [Parameter]
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}
