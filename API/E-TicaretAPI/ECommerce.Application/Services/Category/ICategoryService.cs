
using ECommerce.Application.Interfaces;
using ECommerce.DTOs.Category;
using ECommerce.Entities;

namespace ECommerce.Services.Category_S
{
    public interface ICategoryService : IGenericService<Category, CategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        
    }
}
