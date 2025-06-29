using JwtAuthDotNet.BusinessLogicLayer.Models;
using JwtAuthDotNet.BusinessLogicLayer.Services;
using JwtAuthDotNet.DataAccessLayer.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthDotNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserService userService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult> Register(UserDto request)
        {
            await userService.RegisterAsync(request);

            return Ok();
        }        
        
        [HttpPost("login")]
        public async Task<ActionResult<string>> Login(UserDto request)
        {
            var token = await userService.LoginAsync(request);

            return Ok(token);
        }
    }
}
