using AutoMapper;
using Demo2.DTOs.Category;
using Demo2.Entities;
using Demo2.Repositories;

namespace Demo2.Services
{
    public class CategoryService
    {
        private readonly ICategoryRepository _repo;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        public async Task<List<CategoryDto>> GetAll()
        {
            var categories = await _repo.GetAll();
            return _mapper.Map<List<CategoryDto>>(categories);
        }

        public async Task<CategoryDto> Add(CategoryCreateDto dto)
        {
            var entity = _mapper.Map<Category>(dto);
            await _repo.Add(entity);
            return _mapper.Map<CategoryDto>(entity);
        }
    }
}
