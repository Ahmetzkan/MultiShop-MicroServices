using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Catalog.Dtos.ProductDetailDtos;
using MultiShop.Catalog.Services.ProductDetailServices;

namespace MultiShop.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailService _ProductDetailsService;

        public ProductDetailsController(IProductDetailService ProductDetailsService)
        {
            _ProductDetailsService = ProductDetailsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductDetailAsync()
        {
            var values = await _ProductDetailsService.GetAllProductDetailAsync();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdProductDetailAsync(string id)
        {
            var values = await _ProductDetailsService.GetByIdProductDetailAsync(id);
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductDetailAsync(CreateProductDetailDto createProductDetailsDto)
        {
            await _ProductDetailsService.CreateProductDetailAsync(createProductDetailsDto);
            return Ok("Product Details added succesfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailsDto)
        {
            await _ProductDetailsService.UpdateProductDetailAsync(updateProductDetailsDto);
            return Ok("Product Details updated succesfully");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductDetailAsync(string id)
        {
            await _ProductDetailsService.DeleteProductDetailAsync(id);
            return Ok("Product Details deleted succesfully");
        }
    }
}
