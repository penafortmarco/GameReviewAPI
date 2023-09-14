using Microsoft.AspNetCore.Mvc;
using GameReview.Services.IServices;
using GameReview.Data.Entities.DTOs;
using GameReview.Data.Entities.Models;

namespace GameReviewAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        public ReviewController(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        [HttpGet]
        public async Task<IEnumerable<Review>> Get()
        {
            return await _reviewService.Get();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Review>> GetById(int id)
        {
            var review = await _reviewService.GetById(id);

            if (review is null)
            {
                return NotFound() ;
            }
            return review;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ReviewDTO review)
        {
            if (!ModelState.IsValid) 
            { 
                return BadRequest(); 
            }
            var newReview = await _reviewService.Create(review);

            return CreatedAtAction(nameof(GetById), new { id = newReview.Id }, newReview);

        }

        [HttpPut]
        public async Task<IActionResult> Update(int id, ReviewDTO review)
        {
            if (id != review.Id)
            {
                return BadRequest();
            }

            await _reviewService.Update(review);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var reviewToDelete = await _reviewService.GetById(id);

            if (reviewToDelete is not null)
            {
                await _reviewService.Delete(id);
                return Ok();
            }
            else 
            {
                return NotFound();
            }
        }
    }
}

