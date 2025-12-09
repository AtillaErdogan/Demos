using AutoMapper;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Interfaces;
using ECommerce.DTOs.Product;
using ECommerce.Entities;
using ECommerce.Repositories;


namespace ECommerce.Services.Product_S
{
    public class ProductService : GenericService<Product, ProductDto, CreateProductDto, UpdateProductDto>, IProductService
    {

        private readonly IProductRepository _repo;
        private readonly IMapper _mapper;
        public ProductService(IGenericRepository<Product> repository, IProductRepository productRepository, AutoMapper.IMapper mapper)
            : base(repository, mapper)
        {
            _repo = productRepository;
            _mapper = mapper;

            

        }

        public Task<List<ProductDto>> GetProductsByCategoryAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
