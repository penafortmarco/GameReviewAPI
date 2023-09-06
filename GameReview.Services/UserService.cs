using GameReview.Data.DTOs;
using GameReview.Data.Models.Entity;
using GameReview.DataAccess;
using GameReview.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameReview.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<User>> Get()
        {
            return await _unitOfWork.userRepository.GetAllAsync();
        }

        public async Task<User?> GetById(int id)
        {
            return await _unitOfWork.userRepository.GetByIdAsync(id);
        }

        public async Task<User> Create(User user)
        {
            //Need to implement hash password and psw validation
            await _unitOfWork.userRepository.CreateAsync(user);
            await _unitOfWork.Save();

            return user;
        }

        public async Task Delete(int id)
        {
            var userToDelete = await _unitOfWork.userRepository.GetByIdAsync(id);

            if (userToDelete is not null)
            {
                await _unitOfWork.userRepository.DeleteAsync(userToDelete);
                await _unitOfWork.Save();
            }
        }
    }
}
