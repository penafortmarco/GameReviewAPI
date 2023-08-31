using GameReview.Data.DTOs;
using GameReview.Data.Models.Entity;

namespace GameReview.Services.IServices
{
    public interface IReviewService
    {
        public Task<IEnumerable<Review>> Get();
        public Task<Review?> GetById(int id);
        public Task<Review> Create(ReviewDTO reviewDTO);
        public Task Update(ReviewDTO reviewDTO);
        public Task Delete(int id);
    }
}
