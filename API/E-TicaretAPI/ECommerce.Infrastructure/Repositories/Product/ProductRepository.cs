
using E_Ticaret.Entities;
using ECommerce.Data;
using ECommerce.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret.Repositories.Product_R
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsByCategory(int categoryId)
        {
            return await _context.Products
                             .Where(x => x.CategoryId == categoryId)
                             .ToListAsync();
        }
    }

}

