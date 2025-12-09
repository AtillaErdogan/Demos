using AutoMapper;
using ECommerce.DTOs.Product;
using ECommerce.Entities;

namespace ECommerce.Application.Mappings
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
