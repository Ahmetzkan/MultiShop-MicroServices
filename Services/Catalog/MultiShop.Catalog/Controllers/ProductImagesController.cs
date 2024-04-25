using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductImageDtos;
using MultiShop.Catalog.Services.ProductImageServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImagesController : ControllerBase
    {

        private readonly IProductImageService _ProductImageService;

        public ProductImagesController(IProductImageService ProductImageService)
        {
            _ProductImageService = ProductImageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductImageAsync()
        {
            var values = await _ProductImageService.GetAllProductImageAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProductImageAsync(string id)
        {
            var values = await _ProductImageService.GetByIdProductImageAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductImageAsync(CreateProductImageDto createProductImageDto)
        {
            await _ProductImageService.CreateProductImageAsync(createProductImageDto);
            return Ok("Product Image added succesfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto)
        {
            await _ProductImageService.UpdateProductImageAsync(updateProductImageDto);
            return Ok("Product Image updated succesfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductImageAsync(string id)
        {
            await _ProductImageService.DeleteProductImageAsync(id);
            return Ok("Product Image deleted succesfully");
        }
    }
}