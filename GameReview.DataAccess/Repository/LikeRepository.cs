using GameReview.Data.Entities.Models;
using GameReview.DataAccess.Data;
using GameReview.DataAccess.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace GameReview.DataAccess.Repository
{
    public class LikeRepository : GenericRepository<Like>, ILikeRepository
    {
        public LikeRepository(GameReviewContext context) : base(context)
        {

        }

        public async Task<List<Review>> GetByUser(int id)
        {
            return await dbSet
                .Where(l => l.UserId == id)
                .Select(l => new Review
                {
                    Id = l.Review.Id,
                    Title = l.Review.Title,
                    Image = l.Review.Image
                })
                .ToListAsync();
        }

        public async Task<List<User>> GetByReview(int id)
        {
            return await dbSet
                .Where(l => l.ReviewId == id)
                .Select(l => new User
                {
                    Id = l.User.Id,
                    UserName = l.User.UserName,
                    ProfilePicture = l.User.ProfilePicture
                })
                .ToListAsync();
        }
    }
}

