using GameReview.Data.Entities.DTOs;
using GameReview.Data.Entities.Models;

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
