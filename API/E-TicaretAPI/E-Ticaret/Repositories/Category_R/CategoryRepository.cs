using E_Ticaret.Data;
using E_Ticaret.Entities;
using Microsoft.EntityFrameworkCore;

namespace E_Ticaret.Repositories.Category_R
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        

        public async Task<bool> HasProducts(int categoryId)
        {
            return await _context.Products.AnyAsync(x => x.CategoryId == categoryId);
        }
        
    }
}
