using GameReview.Data.Entities.DTOs;
using GameReview.Data.Entities.Models;
using GameReview.DataAccess;
using GameReview.Services.IServices;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace GameReview.Services
{
    public class LikeService : ILikeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public LikeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Like>> Get()
        {
            return await _unitOfWork.likeRepository.GetAllAsync();
        }

        public async Task<Like?> GetById(int id)
        {
            return await _unitOfWork.likeRepository.GetByIdAsync(id);

        }

        public async Task<IEnumerable<User?>> GetByReview(int id)
        {
            return await _unitOfWork.likeRepository.GetByReview(id);
        }

        public async Task<IEnumerable<Review?>> GetByUser(int id)
        {
            return await _unitOfWork.likeRepository.GetByUser(id);
        }

        public async Task<Like> Create(LikeDTO likeDTO)
        {
            var like = new Like
            {
                UserId = likeDTO.UserId,
                ReviewId = likeDTO.ReviewId,
            };
            await _unitOfWork.likeRepository.CreateAsync(like);
            await _unitOfWork.Save();
            return like;
        }

        public async Task Delete(int id)
        {
            var existingLike = await _unitOfWork.likeRepository.GetByIdAsync(id);
            if (existingLike is not null)
            {
                await _unitOfWork.likeRepository.DeleteAsync(existingLike);
                await _unitOfWork.Save();
            }
        }
    }
}
