using GameReview.Data.Entities.Models;
using GameReview.DataAccess.Data;
using GameReview.DataAccess.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace GameReview.DataAccess.Repository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(GameReviewContext context) : base(context)
        {
            
        }

        public async Task<List<Review>> GetAllAsync() 
        {
            return await dbSet
                .Include(r => r.User)
                .Include(r => r.Comments)
                .ToListAsync();
        }
        public async Task<Review?> GetByIdAsync(int id)
        {
            return await dbSet
                .Include(r => r.User)
                .Include(r => r.Comments)
                .FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task Update(Review review)
        {
            dbSet.Update(review);
        }
    }
}
