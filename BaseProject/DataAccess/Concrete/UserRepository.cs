using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public User CreateUser(User user)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Users.Add(user);
                dbContex.SaveChanges();
                return user;
            }
        }

        public void DeleteUser(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                User user = GetUserById(id);
                dbContex.Users.Remove(user);
                dbContex.SaveChanges();
            }
        }

        public User GetUserById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return dbContex.Users.Find(id);
            }
        }

        public List<User> GetUsers()
        {
            using (DbContex dbContex = new DbContex())
            {
                return dbContex.Users.ToList();
            }
        }

        public User UpdateUser(User user)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Users.Update(user);
                dbContex.SaveChanges();
                return user;
            }
        }
    }
}
