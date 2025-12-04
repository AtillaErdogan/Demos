using AutoMapper;
using Demo2.DTOs.Category;
using Demo2.Entities;

namespace Demo2.Mappings
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryCreateDto, Category>();
        }
    }
}
