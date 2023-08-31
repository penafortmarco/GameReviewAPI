using GameReview.Data.Models.Entity;
namespace GameReview.DataAccess.Repository.IRepositories
{
    public interface IReviewRepository : IRepository<Review>
    {
        public Task Update(Review review);
    }
}
