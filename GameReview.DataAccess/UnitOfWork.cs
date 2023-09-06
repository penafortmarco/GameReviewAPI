using GameReview.DataAccess.Data;
using GameReview.DataAccess.Repository.IRepositories;

namespace GameReview.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Save();
        IReviewRepository reviewRepository { get; }
        IUserRepository userRepository { get; }
    }
    public class UnitOfWork : IUnitOfWork
    {
        public IReviewRepository reviewRepository { get; }
        public IUserRepository userRepository { get; }
        private readonly GameReviewContext _context;
        public UnitOfWork(GameReviewContext context, IReviewRepository reviewRepository, IUserRepository userRepository)
        {
            _context = context;
            this.reviewRepository = reviewRepository;
            this.userRepository = userRepository;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> Save()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
