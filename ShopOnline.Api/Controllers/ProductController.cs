using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using ShopOnline.DataAccess.DTOs;
using ShopOnline.DataAccess.Repository.Contracts;
using ShopOnline.Infrastructure.Extentions;

namespace ShopOnline.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            try
            {
                var products = await _repository.GetProducts();
                var categories = await _repository.GetCategories();
                if(products==null|| categories == null)
                {
                    return NotFound();
                }
                else
                {
                    var productDTOs = products.ConvertToDTO(categories);
                    return Ok(productDTOs);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Что то не так с базой данных");
            }
        }
    }
}