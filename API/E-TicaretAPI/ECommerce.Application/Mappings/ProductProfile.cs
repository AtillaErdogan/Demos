using AutoMapper;
using E_Ticaret.DTOs.Category;
using E_Ticaret.DTOs.Product;
using E_Ticaret.Entities;

namespace E_Ticaret.Mappings
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            //.ReverseMap() eklenince, tersi de otomatik eklenir
            //Read
            CreateMap<Product, ProductDto>()
               .ForMember(pdto => pdto.CategoryName, opt => opt.MapFrom(src => src.Category!.Name));
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
        }
    }
}
