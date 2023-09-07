using GameReview.Data.Entities.Models;

namespace GameReview.Services.IServices
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> Get();
        public Task<User?> GetById(int id);
        public Task<User> Create(User user);
        public Task Delete(int id);
    }
}
