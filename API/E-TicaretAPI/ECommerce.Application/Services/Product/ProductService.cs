
using E_Ticaret.DTOs.Product;
using E_Ticaret.Entities;
using E_Ticaret.Repositories;
using E_Ticaret.Services.Product_S;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Interfaces;


namespace ECommerce.Services.Product_S
{
    public class ProductService : GenericService<Product, ProductDto, CreateProductDto, UpdateProductDto>, IProductService
    {

        private readonly IProductRepository _productRepository;
        public ProductService(IGenericRepository<Product> repository, IProductRepository productRepository, AutoMapper.IMapper mapper)
            : base(repository, mapper)
        {
            _productRepository = productRepository;

        }

        public async Task<List<ProductDto>> GetProductsByCategoryAsync(int categoryId)
        {
            var products = await _productRepository.GetProductsByCategory(categoryId);
            return _mapper.Map<List<ProductDto>>(products);
        }
    }
}
