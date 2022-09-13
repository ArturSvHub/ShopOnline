using ShopOnline.DataAccess.DTOs;
using ShopOnline.Services.Web.Contracts;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ShopOnline.Services.Web
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            try
            {
                var products = await httpClient
                    .GetFromJsonAsync<IEnumerable<ProductDTO>>("api/Product");
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
