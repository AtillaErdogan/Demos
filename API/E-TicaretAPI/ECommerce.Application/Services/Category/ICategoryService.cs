using E_Ticaret.DTOs.Category;
using E_Ticaret.Entities;
using ECommerce.Application.Interfaces;

namespace ECommerce.Services.Category_S
{
    public interface ICategoryService : IGenericService<Category, CategoryDto, CreateCategoryDto, UpdateCategoryDto>
    {
        
    }
}
