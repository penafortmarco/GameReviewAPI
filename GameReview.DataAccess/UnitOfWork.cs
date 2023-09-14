using GameReview.DataAccess.Data;
using GameReview.DataAccess.Repository.IRepositories;

namespace GameReview.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Save();
        IReviewRepository reviewRepository { get; }
        IUserRepository userRepository { get; }
        ILikeRepository likeRepository { get; }
    }
    public class UnitOfWork : IUnitOfWork
    {
        public IReviewRepository reviewRepository { get; }
        public IUserRepository userRepository { get; }
        public ILikeRepository likeRepository { get; }
        private readonly GameReviewContext _context;
        public UnitOfWork(GameReviewContext context, 
            IReviewRepository reviewRepository, 
            IUserRepository userRepository, 
            ILikeRepository likeRepository)
        {
            _context = context;
            this.reviewRepository = reviewRepository;
            this.userRepository = userRepository;
            this.likeRepository = likeRepository;
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
