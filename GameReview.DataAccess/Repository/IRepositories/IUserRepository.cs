using GameReview.Data.Entities.Models;

namespace GameReview.DataAccess.Repository.IRepositories
{
    public interface IUserRepository : IRepository<User>
    {
        public Task ChangeUsername(User user, string username);
        public Task ChangePassword(User user, string password);
    }
}
