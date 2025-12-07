using AutoMapper;

using E_Ticaret.DTOs.Category;
using E_Ticaret.Entities;
using E_Ticaret.Services.Category_S;
using ECommerce.Services.Category_S;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace E_Ticaret.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _categoryService.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _categoryService.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Create(CreateCategoryDto dto) => Ok(await _categoryService.CreateAsync(dto));

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateCategoryDto dto)
        {
            await _categoryService.UpdateAsync(id, dto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryService.DeleteAsync(id);
            return NoContent();
        }
    }
}
