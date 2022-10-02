using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    internal interface IUserService
    {
        List<User> GetUsers();

        User GetUserById(int id);

        User CreateUser(User user);

        User UpdateUser(User user);

        void DeleteUser(int id);
    }
}
