using E_Ticaret.Entities;
using E_Ticaret.Repositories;

namespace ECommerce.Domain.Interfaces
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        Task<List<Product>> GetProductsByCategory(int categoryId);
    }
}
