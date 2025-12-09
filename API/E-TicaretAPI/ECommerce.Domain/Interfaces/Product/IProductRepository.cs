
using ECommerce.Entities;
using ECommerce.Repositories;

namespace ECommerce.Domain.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetAllWithCategoryAsync();


    }
}
