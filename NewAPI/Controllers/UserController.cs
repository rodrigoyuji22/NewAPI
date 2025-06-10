using Microsoft.AspNetCore.Mvc;
using NewAPI.Dtos;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController(IUserService userService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> RegisterAsync(CreateUserDto dto)
        {
            var result =  await userService.CreateAsync(dto);
            return Ok(result);
        }
    }
}
