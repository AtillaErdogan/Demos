using E_Ticaret.DTOs.Product;
using E_Ticaret.Entities;
using ECommerce.Application.Interfaces;

namespace E_Ticaret.Services.Product_S
{
    public interface IProductService: IGenericService<Product,ProductDto, CreateProductDto, UpdateProductDto>
    {
        Task<List<ProductDto>> GetProductsByCategoryAsync(int categoryId);
    }
}
