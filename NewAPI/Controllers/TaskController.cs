using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NewAPI.Controllers;
[Authorize]
[Controller]
[Route("[controller]")]
public class TaskController : ControllerBase
{
    
}