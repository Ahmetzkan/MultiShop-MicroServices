using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiShop.Discount.Dtos;
using MultiShop.Discount.Services;

namespace MultiShop.Discount.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;

        public DiscountsController(IDiscountService discountService)
        {
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCouponDiscountAsync()
        {
            var result = await _discountService.GetAllDiscountCouponAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdCouponDiscountAsync(int id)
        {
            var result = await _discountService.GetByIdDiscountCouponAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCouponDiscountAsync(CreateDiscountCouponDto createCouponDto)
        {
            await _discountService.CreateDiscountCouponAsync(createCouponDto);
            return Ok("Coupon Discount added successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCouponDiscountAsync(UpdateDiscountCouponDto updateCouponDto)
        {
            await _discountService.UpdateDiscountCouponAsync(updateCouponDto);
            return Ok("Coupon Discount updated successfully");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCouponDiscountAsync(int id)
        {
            await _discountService.DeleteDiscountCouponAsync(id);
            return Ok("Coupon Discount deleted successfully");
        }
    }
}
