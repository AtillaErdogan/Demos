using System.Linq.Expressions;

namespace E_Ticaret.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(int id); // Sadece bu nullable olabilir
        Task<List<T>> FindAsync(Expression<Func<T, bool>> data);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
        
    }
}
