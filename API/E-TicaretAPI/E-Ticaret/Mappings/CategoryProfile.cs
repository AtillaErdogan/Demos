using AutoMapper;
using E_Ticaret.DTOs.Category;
using E_Ticaret.Entities;

namespace E_Ticaret.Mappings
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
