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
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = userService.GetUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var user = userService.GetUserById(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult PostUser(User user)
        {
            var createUser = userService.CreateUser(user);
            return CreatedAtAction("Get", new { id = user.Id }, createUser);
        }
        [HttpPut]
        public IActionResult PutUser(User user)
        {
            if (userService.GetUserById(user.Id) != null)
            {
                return Ok(userService.UpdateUser(user));
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            if (userService.GetUserById(id) != null)
            {
                userService.DeleteUser(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
