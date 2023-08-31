using GameReview.Data.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview.DataAccess.Repository.IRepositories
{
    public interface IReviewRepository : IRepository<Review>
    {
        public Task Update(Review review);
    }
}
