using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public List<User> GetUsers()
        {
            return userService.GetUsers();
        }

        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            return userService.GetUserById(id);
        }
        [HttpPost]
        public User PostUser(User user)
        {
            return userService.CreateUser(user);
        }
        [HttpPut]
        public User putUser(User user)
        {
            return userService.UpdateUser(user);
        }
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            userService.DeleteUser(id);
        }
    }
}
