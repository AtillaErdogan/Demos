

using ECommerce.Data;
using ECommerce.Domain.Interfaces;
using ECommerce.Entities;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Repositories.Product_R
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {

        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetAllWithCategoryAsync()
        {
            return await _context.Products
                                 .Include(p => p.Category) // Category yükleniyor
                                 .ToListAsync();
        }

        public async Task<List<Product>> GetProductsByCategoryAsync(int categoryId)
        {

            return await _context.Products
                                 .Where(p => p.CategoryId == categoryId)
                                 .Include(p => p.Category)
                                 .ToListAsync();
        }
    }

}

