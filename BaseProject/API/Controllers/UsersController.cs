using Business.Abstract;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    //[Authorize(Roles ="admin")]
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

        [AllowAnonymous]
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateUser(User user)
        {
            var checkUser= await userService.GetUserByUserName(user.UserName != null ? user.UserName : "");
            if (checkUser != null)
            {
                return BadRequest();
            }
            var createUser = await userService.CreateUser(user);
            return CreatedAtAction("GetUserById", new { id = user.Id }, createUser);
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

        [AllowAnonymous]
        [HttpGet]
        [Route("[action]/{userName}/{password}")]
        public async Task<IActionResult> Authenticate(string userName, string password)
        {
            var user = await userService.GetUserByUserName(userName);
            if (user != null)
            {
                if (user.Password == password)
                {
                    var claim = new List<Claim>
                    {
                        new Claim(ClaimTypes.NameIdentifier,user.UserName!=null ? user.UserName:""),
                        new Claim(ClaimTypes.Role,user.Role.ToString()),

                    };

                    ClaimsIdentity claimsIdentity = new ClaimsIdentity(claim, CookieAuthenticationDefaults.AuthenticationScheme);
                    AuthenticationProperties authProperties = new AuthenticationProperties() { AllowRefresh = true };

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);
                    return Ok();

                    //return user;
                }
                return NotFound();
            }
            return NotFound();
        }
    }
}
