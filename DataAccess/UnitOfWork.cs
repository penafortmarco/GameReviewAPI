using GameReview.DataAccess.Data;
using GameReview.DataAccess.Repository.IRepositories;

namespace GameReview.DataAccess
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Save();
        IReviewRepository reviewRepository { get; }
    }
    public class UnitOfWork : IUnitOfWork
    {
        public IReviewRepository reviewRepository { get; }
        private readonly GameReviewContext _context;
        public UnitOfWork(GameReviewContext context, IReviewRepository reviewRepository)
        {
            _context = context;
            this.reviewRepository = reviewRepository;
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
