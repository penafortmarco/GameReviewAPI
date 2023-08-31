using GameReview.DataAccess.Data;
using GameReview.DataAccess.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace GameReview.DataAccess.Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly GameReviewContext _context;
        internal DbSet<T> dbSet;

        public GenericRepository(GameReviewContext context) 
        {
            _context = context;
            dbSet = _context.Set<T>();
        }
        public async Task<List<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await dbSet.FindAsync(id);
        }

        public async Task CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
        }

        public async Task DeleteAsync(T entity)
        {
            dbSet.Remove(entity);
        }
    }
}
