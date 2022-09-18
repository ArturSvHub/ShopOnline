using Newtonsoft.Json;

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
    public class ShoppingCartService : IShoppingCartService
    {
        private readonly HttpClient httpClient;

        public ShoppingCartService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<CartItemDTO> AddCartItem(CartItemToAddDTO cartItemToAddDTO)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("api/Cart", cartItemToAddDTO);
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default;
                    }
                    return await response.Content.ReadFromJsonAsync<CartItemDTO>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status:{response.StatusCode} Message - {message}");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<CartItemDTO> DeleteCartItem(int id)
        {
            try
            {
                var response = await httpClient.DeleteAsync($"api/Cart/{id}");
                if(response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CartItemDTO>();
                }
                return default(CartItemDTO);
            }
            catch (Exception)
            {
                //Log
                throw;
            }
        }

        public async Task<List<CartItemDTO>> GetCartItems(int userId)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Cart/{userId}/GetItems");
                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return Enumerable.Empty<CartItemDTO>().ToList();
                    }
                    return await response.Content.ReadFromJsonAsync<List<CartItemDTO>>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Http status:{response.StatusCode} Message - {message}");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public async Task<CartItemDTO> UpdateCount(CartItemCountUpdateDTO updateDTO)
        {
            try
            {
                var jsonRequest =JsonConvert.SerializeObject(updateDTO);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json-patch+json");
                var response = await httpClient.PatchAsync($"api/Cart/{updateDTO.CartItemId}",content);
                if(response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<CartItemDTO>();
                }
                return null;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
