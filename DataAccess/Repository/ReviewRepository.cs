using GameReview.Data.Models.Entity;
using GameReview.DataAccess.Data;
using GameReview.DataAccess.Repository.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview.DataAccess.Repository
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(GameReviewContext context) : base(context)
        {
            
        }

        public async Task Update(Review review)
        {
            dbSet.Update(review);
        }
    }
}
