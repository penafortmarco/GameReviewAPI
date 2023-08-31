using GameReview.Data.Models.Entity;
using GameReview.DataAccess.Data;
using GameReview.DataAccess.Repository.IRepositories;

namespace GameReview.DataAccess.Repository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(GameReviewContext context) : base(context)
        {
            
        }

        public async Task Update(Review review)
        {
            dbSet.Update(review);
        }
    }
}
