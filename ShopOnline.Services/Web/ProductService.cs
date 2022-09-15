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

        public async Task<ProductDTO> GetProductById(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/product/{id}");
                if(response.IsSuccessStatusCode)
                {
                    if(response.StatusCode==System.Net.HttpStatusCode.NoContent)
                    {
                        return default(ProductDTO);
                    }
                    return await response.Content.ReadFromJsonAsync<ProductDTO>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            try
            {
                var response = await httpClient.GetAsync("api/Product");
                if(response.IsSuccessStatusCode)
                {
                    if(response.StatusCode==System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<ProductDTO>();
                    }
                    return await response.Content.ReadFromJsonAsync<IEnumerable<ProductDTO>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
