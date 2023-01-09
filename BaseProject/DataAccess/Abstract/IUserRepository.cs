using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();

        Task<User> GetUserById(int id);

        Task<User> GetUserByUserName(string userName);

        Task<User> CreateUser(User user);

        Task<User> UpdateUser(User user);

        Task DeleteUser(int id);
    }
}
