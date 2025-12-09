
using ECommerce.Entities;
using ECommerce.Repositories;

namespace ECommerce.Domain.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<bool> HasProducts(int categoryId);
    }
}
