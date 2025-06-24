using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NewAPI.Dtos;
using NewAPI.Extensions;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Controllers;
[Authorize]
[Controller]
[Route("[controller]")]
public class TaskController(ITaskItemService taskItemService) : ControllerBase
{
    [HttpPost("create")]
    public async Task<IActionResult> CreateTaskItemAsync([FromBody]CreateTaskItemDto dto)
    {
        var userId = User.GetUserId();
        if (userId is null)
            return Unauthorized();
        var result = await taskItemService.CreateTaskItemAsync(dto, userId);
        return Ok(result);
    }
}