
using ECommerce.Application.Interfaces;
using ECommerce.DTOs.Product;
using ECommerce.Entities;

namespace ECommerce.Services.Product_S
{
    public interface IProductService: IGenericService<Product,ProductDto, CreateProductDto, UpdateProductDto>
    {
        
        Task<List<ProductDto>> GetProductsByCategoryAsync(int categoryId);
    }
}
