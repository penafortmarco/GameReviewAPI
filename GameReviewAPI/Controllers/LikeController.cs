using GameReview.Data.Entities.DTOs;
using GameReview.Data.Entities.Models;
using GameReview.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameReviewAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LikeController : ControllerBase
    {
        private readonly ILikeService _likeService;

        public LikeController(ILikeService likeService)
        {
            _likeService = likeService;
        }
        [HttpGet]
        public async Task<IEnumerable<Like>> Get()
        {
            return await _likeService.Get();
        }
        [HttpGet("{id}")]
        public async Task<Like?> GetById(int id)
        {
            return await _likeService.GetById(id);
        }
        [HttpGet("ByUser/{userId}")]
        public async Task<IEnumerable<Review?>> GetByUser(int userId)
        {
            return await _likeService.GetByUser(userId);
        }
        [HttpGet("ByReview/{reviewId}")]
        public async Task<IEnumerable<User?>> GetByReview(int reviewId)
        {
            return await _likeService.GetByReview(reviewId);
        }
        [HttpPost]
        public async Task<Like> Create(LikeDTO likeDTO)
        {
            return await _likeService.Create(likeDTO);
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var existingLike = await _likeService.GetById(id);
            if (existingLike is not null) 
            {
                await _likeService.Delete(id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
