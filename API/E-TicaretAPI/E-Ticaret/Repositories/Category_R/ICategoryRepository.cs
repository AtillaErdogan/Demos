using E_Ticaret.Entities;

namespace E_Ticaret.Repositories.Category_R
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Task<bool> HasProducts(int categoryId);
    }
}
