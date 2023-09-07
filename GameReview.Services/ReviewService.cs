using GameReview.Data.Entities.DTOs;
using GameReview.Data.Entities.Models;
using GameReview.DataAccess;
using GameReview.Services.IServices;
using Microsoft.IdentityModel.Tokens;

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
            var reviews = await _unitOfWork.reviewRepository.GetAllAsync();
            foreach (var review in reviews) 
            {
                review.LikeCount = (review.Likes is not null) ? review.Likes.Count() : 0;
            }
            return reviews;
        }

        public async Task<Review?> GetById(int id)
        {
            var review = await _unitOfWork.reviewRepository.GetByIdAsync(id);
            if (review is not null) 
            { 
                review.LikeCount = (review.Likes is not null) ? review.Likes.Count() : 0; 
            }
            
            return review;
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
