using DataAccess.Abstract;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public async Task<User> CreateUser(User user)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Users.Add(user);
                await dbContex.SaveChangesAsync();
                return user;
            }
        }

        public async Task DeleteUser(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                User user = await GetUserById(id);
                dbContex.Users.Remove(user);
                await dbContex.SaveChangesAsync();
            }
        }

        public async Task<User> GetUserById(int id)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Users.FindAsync(id);
            }
        }

        public async Task<User> GetUserByUserName(string userName)
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Users.FirstOrDefaultAsync(x => x.UserName.ToLower() == userName.ToLower());
            }
        }

        public async Task<List<User>> GetUsers()
        {
            using (DbContex dbContex = new DbContex())
            {
                return await dbContex.Users.ToListAsync();
            }
        }

        public async Task<User> UpdateUser(User user)
        {
            using (DbContex dbContex = new DbContex())
            {
                dbContex.Users.Update(user);
                await dbContex.SaveChangesAsync();
                return user;
            }
        }
    }
}
