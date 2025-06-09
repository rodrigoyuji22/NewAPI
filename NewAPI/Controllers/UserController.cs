using Microsoft.AspNetCore.Mvc;
using NewAPI.Dtos;

namespace NewAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult CadastrarUsuario(CreateUserDto dto) 
        {
            throw new NotImplementedException();
        }
    }
}
