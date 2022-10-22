using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Business.Abstract;
using Business.Concrete;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService userService;

        public UsersController()
        {
            userService = new UserManager();
        }

        [HttpGet]
        public List<User> get()
        {
            return userService.GetUsers();
        }
        [HttpGet("{id}")]
        public User GetUser(int id)
        {
            return userService.GetUserById(id);
        }
    }
}
