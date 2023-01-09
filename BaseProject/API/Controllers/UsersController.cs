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
        [Route("[action]")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await userService.GetUsers();
            return Ok(users);
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await userService.GetUserById(id);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }
        
        [HttpGet]
        [Route("[action]/{userName}")]
        public async Task<IActionResult> GetUserByUserName(string userName)
        {
            var user = await userService.GetUserByUserName(userName);
            if (user != null)
            {
                return Ok(user);
            }
            return NotFound();
        }
        
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateUser(User user)
        {
            var createUser = await userService.CreateUser(user);
            return CreatedAtAction("Get", new { id = user.Id }, createUser);
        }
        
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            if (userService.GetUserById(user.Id) != null)
            {
                return Ok(await userService.UpdateUser(user));
            }
            return NotFound();
        }
        
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            if (await userService.GetUserById(id) != null)
            {
                await userService.DeleteUser(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
