using E_Ticaret.Entities;
using E_Ticaret.Repositories;

namespace ECommerce.Domain.Interfaces
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<bool> HasProducts(int categoryId);
    }
}
