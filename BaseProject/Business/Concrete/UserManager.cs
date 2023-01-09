using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> CreateUser(User user)
        {
            return await _userRepository.CreateUser(user);
        }

        public async Task DeleteUser(int id)
        {
            await _userRepository.DeleteUser(id);
        }

        public async Task<User> GetUserById(int id)
        {
            return await _userRepository.GetUserById(id);
        }

        public async Task<User> GetUserByUserName(string userName)
        {
            return await _userRepository.GetUserByUserName(userName);
        }

        public async Task<List<User>> GetUsers()
        {
            return await _userRepository.GetUsers();
        }

        public async Task<User> UpdateUser(User user)
        {
            return await _userRepository.UpdateUser(user);
        }
    }
}
