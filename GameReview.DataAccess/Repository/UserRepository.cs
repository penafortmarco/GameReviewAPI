using GameReview.Data.Entities.Models;
using GameReview.DataAccess.Data;
using GameReview.DataAccess.Repository.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview.DataAccess.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(GameReviewContext context) : base(context)
        {

        }

        public Task ChangePassword(User user, string password)
        {
            throw new NotImplementedException();
        }

        public Task ChangeUsername(User user, string username)
        {
            throw new NotImplementedException();
        }
    }
}
