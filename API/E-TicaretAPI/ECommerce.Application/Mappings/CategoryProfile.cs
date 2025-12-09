using AutoMapper;


using ECommerce.DTOs.Category;
using ECommerce.Entities;

namespace ECommerce.Application.Mappings
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            //.ReverseMap() eklenince, tersi de otomatik eklenir
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
        }
    }
}
