using GameReview.Data.Entities.Models;
using GameReview.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace GameReviewAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IEnumerable<User>> Get()
        {
            return await _userService.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetById(int id) 
        {
            var user = await _userService.GetById(id);

            if (user is null) 
            {
                return NotFound();
            }
            return user;
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            await _userService.Create(user);

            return Ok();

        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var userToDelete = await _userService.GetById(id);

            if (userToDelete is not null)
            {
                await _userService.Delete(id);
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }
    }

}

