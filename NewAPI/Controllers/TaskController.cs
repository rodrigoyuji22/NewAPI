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

    [HttpGet]
    public async Task<IActionResult> GetTaskItemAsync()
    {
        var userId = User.GetUserId();
        if (userId is null)
            return Unauthorized();
        var result = await taskItemService.GetAllAsync(userId);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateTaskItemAsync([FromBody] UpdateTaskItemDto dto)
    {
        var userId = User.GetUserId();
        if (userId is null)
            return Unauthorized();
        await taskItemService.UpdateAsync(dto,userId);
        return NoContent();
    }
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTaskItemAsync(Guid id)
    {
        var userId = User.GetUserId();
        if (userId is null)
            return Unauthorized();
        await taskItemService.DeleteAsync(id,  userId);
        return NoContent();
    }
}