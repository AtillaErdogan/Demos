using E_Ticaret.Data;
using E_Ticaret.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq.Expressions;

namespace E_Ticaret.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        //Contex ve bir tablo lazım
        protected readonly AppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        public async Task<List<T>> GetAllAsync()
        => await _dbSet.ToListAsync();
        public async Task<T?> GetByIdAsync(int id)
        => await _dbSet.FindAsync(id);
        public async Task<List<T>> FindAsync(Expression<Func<T, bool>> data)
        => await _dbSet.Where(data).ToListAsync();
        public async Task AddAsync(T entity)
        => await _dbSet.AddAsync(entity);

        public void Delete(T entity)
        => _dbSet.Remove(entity);

        public void Update(T entity)
        => _dbSet.Update(entity);
        public async Task SaveChangesAsync()
        => await _context.SaveChangesAsync();
    }
}
