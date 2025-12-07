using E_Ticaret.Entities;

namespace E_Ticaret.Repositories.Product_R
{
    public interface IProductRepository : IGenericRepository<Product>
    {

        Task<List<Product>> GetProductsByCategory(int categoryId);
    }
}
