using GameReview.Data.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview.DataAccess.Repository.IRepositories
{
    public interface ILikeRepository : IRepository<Like>
    {
        public Task<List<Review>> GetByUser(int id);
        public Task<List<User>> GetByReview(int id);
    }
}
