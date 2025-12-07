using E_Ticaret.DTOs.Category;
using E_Ticaret.Entities;
using E_Ticaret.Repositories;
using E_Ticaret.Repositories.Category_R;
using E_Ticaret.Repositories.Product_R;
using E_Ticaret.Services;

namespace E_Ticaret.Services.Category_S
{


    public class CategoryService : GenericService<Category, CategoryDto, CreateCategoryDto, UpdateCategoryDto>, ICategoryService
    {

        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(IGenericRepository<Category> repository, ICategoryRepository categoryRepository, AutoMapper.IMapper mapper)
            : base(repository, mapper)
        {
            _categoryRepository = categoryRepository;
        }
        public override async Task DeleteAsync(int id)
        {
            var category = await _categoryRepository.GetByIdAsync(id);
            if (category == null)
                throw new Exception("Kategori bulunamadı!");

            if (await _categoryRepository.HasProducts(id))
                throw new Exception("Bu kategoriye bağlı ürünler olduğu için silinemez!");

            _categoryRepository.Delete(category);
            await _categoryRepository.SaveChangesAsync();
        }

    }
}

