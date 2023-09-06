using GameReview.Data.DTOs;
using GameReview.Data.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview.Services.IServices
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> Get();
        public Task<User?> GetById(int id);
        public Task<User> Create(User user);
        public Task Delete(int id);
    }
}
