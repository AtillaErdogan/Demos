using Demo2.Data;
using Demo2.Entities;

namespace Demo2.Repositories
{
    public class CategoryRepository:GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AppDbContext context): base (context)
        {
        }
    }
}
