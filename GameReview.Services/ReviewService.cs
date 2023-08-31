using GameReview.Data.DTOs;
using GameReview.Data.Models.Entity;
using GameReview.DataAccess;
using GameReview.Services.IServices;

namespace GameReview.Services
{
    public class ReviewService : IReviewService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ReviewService(IUnitOfWork unitOfWork) 
        {  
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Review>> Get()
        {
            return await _unitOfWork.reviewRepository.GetAllAsync();
        }

        public async Task<Review?> GetById(int id)
        {
            return await _unitOfWork.reviewRepository.GetByIdAsync(id);
        }
       
        public async Task<Review> Create(ReviewDTO reviewDTO)
        {
            var review = new Review();

            review.Title = reviewDTO.Title;
            review.Description = reviewDTO.Description;
            review.Image = reviewDTO.Image;
            review.UserId = reviewDTO.UserId;

            await _unitOfWork.reviewRepository.CreateAsync(review);
            await _unitOfWork.Save();
            
            return review;
        }

        public async Task Update(ReviewDTO reviewDTO)
        {
            var existingReview = await _unitOfWork.reviewRepository.GetByIdAsync(reviewDTO.Id);

            if (existingReview is not null) 
            { 
                existingReview.Title = reviewDTO.Title;
                existingReview.Description = reviewDTO.Description;
                existingReview.Image = reviewDTO.Image;
                await _unitOfWork.Save();
            }
        }
       
        public async Task Delete(int id)
        {
            var reviewToDelete = await _unitOfWork.reviewRepository.GetByIdAsync(id);

            if (reviewToDelete is not null)
            {
                await _unitOfWork.reviewRepository.DeleteAsync(reviewToDelete);
                await _unitOfWork.Save();
            }
        }
    }
}
