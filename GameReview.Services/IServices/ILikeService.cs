using GameReview.Data.Entities.DTOs;
using GameReview.Data.Entities.Models;


namespace GameReview.Services.IServices
{
    public interface ILikeService
    {
        public Task<IEnumerable<Like>> Get();
        public Task<Like?> GetById(int id);
        public Task<IEnumerable<Review>> GetByUser(int id);
        public Task<IEnumerable<User>> GetByReview(int id);
        public Task<Like> Create(LikeDTO likeDTO);
        public Task Delete(int id);
    }
}
