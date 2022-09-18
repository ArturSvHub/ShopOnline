using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ShopOnline.DataAccess.DTOs;
using ShopOnline.DataAccess.Repository.Contracts;
using ShopOnline.Infrastructure.Extentions;

namespace ShopOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly IShoppingCartRepository shoppingCartRepository;
        private readonly IProductRepository productRepository;

        public CartController(IShoppingCartRepository shoppingCartRepository,
            IProductRepository productRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.productRepository = productRepository;
        }
        [HttpGet]
        [Route("{userId}/getItems")]
        public async Task<ActionResult<IEnumerable<CartItemDTO>>> GetItems(int userId)
        {
            try
            {
                var cartItems = await shoppingCartRepository.GetItemsForUser(userId);
                if (cartItems == null)
                {
                    return NoContent();
                }
                var products = await productRepository.GetProducts();

                if (products == null)
                {
                    throw new Exception("Товары не завезли...");
                }
                var cartItemDTOs = cartItems.ConvertToDTO(products);
                return Ok(cartItemDTOs);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        public async Task<ActionResult<CartItemDTO>> GetItem(int id)
        {
            try
            {
                var cartItem = await shoppingCartRepository.GetItem(id);
                if (cartItem == null)
                {
                    return NotFound();
                }
                var product = await productRepository.GetProduct(id);
                if (product == null)
                {
                    return NotFound();
                }
                var cartItemDTO = cartItem.ConvertToDTO(product);
                return Ok(cartItemDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPost]
        public async Task<ActionResult<CartItemDTO>> PostItemToCart(
            [FromBody] CartItemToAddDTO cartItemToAddDTO)
        {
            try
            {
                var newCartItem = await shoppingCartRepository.AddItem(cartItemToAddDTO);
                if (newCartItem == null)
                {
                    return NoContent();
                }
                var product = await productRepository.GetProduct(newCartItem.ProductId.GetValueOrDefault());
                if (product == null)
                {
                    throw new Exception($"Что то пошло не так с добавлением товара c id: {cartItemToAddDTO.ProductId}");
                }
                var newCartItemDTO = newCartItem.ConvertToDTO(product);
                return CreatedAtAction(nameof(GetItem), new { id = newCartItemDTO.Id }, newCartItemDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<CartItemDTO>> DeleteItemFromCart(int id)
        {
            try
            {
                var cartItem = await shoppingCartRepository.DeleteItem(id);
                if (cartItem == null)
                {
                    return NotFound();
                }
                var product = await productRepository.GetProduct(cartItem.ProductId.GetValueOrDefault());
                if (product == null)
                {
                    return NotFound();
                }
                var cartItemDTO = cartItem.ConvertToDTO(product);
                return Ok(cartItemDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
        [HttpPatch("{id:int}")]
        public async Task <ActionResult> UpdateCount(int id,CartItemCountUpdateDTO cartItemCountUpdateDTO)
        {
            try
            {
                var cartItem = await shoppingCartRepository.UpdateCount(id, cartItemCountUpdateDTO);
                if(cartItem == null)
                {
                    return NotFound();
                }
                var product = await productRepository.GetProduct(cartItem.ProductId.GetValueOrDefault());
                var cartItemDTO = cartItem.ConvertToDTO(product);
                return Ok(cartItemDTO);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
