using E_Ticaret.DTOs.Category;
using E_Ticaret.DTOs.Product;
using E_Ticaret.Services.Category_S;
using E_Ticaret.Services.Product_S;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productservice;

        public ProductController(IProductService productService)
        {
            _productservice = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _productservice.GetAllAsync());



        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _productservice.GetByIdAsync(id));

       
        [HttpGet("by-categoryId")]
        public  async Task<IActionResult> GetProductsByCategory(int categoryId)
        {
            var result = await _productservice.GetProductsByCategoryAsync(categoryId);
            return Ok(result);
        }



        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto dto) => Ok(await _productservice.CreateAsync(dto));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateProductDto dto)
        {
            await _productservice.UpdateAsync(id, dto);
            return NoContent();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _productservice.DeleteAsync(id);
            return NoContent();
        }


    }
}
