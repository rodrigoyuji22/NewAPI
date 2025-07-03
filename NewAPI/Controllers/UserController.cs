using Microsoft.AspNetCore.Mvc;
using NewAPI.Dtos;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserService userService) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> RegisterAsync(CreateUserDto dto)
        {
            var result =  await userService.CreateAsync(dto);
            if (result.Succeeded)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPost("login")]
        public async Task<IActionResult> LoginAsync(LoginUserDto dto)
        {
            var token = await userService.LoginAsync(dto);
            return Ok(token);
        }
        
    }
}
