using AutoMapper;
using NewAPI.Dtos;
using NewAPI.Entities;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Services;

public class TaskItemService(ITaskItemRepository repository, IMapper mapper) : ITaskItemService
{
    public async Task<TaskItem> CreateTaskItemAsync(CreateTaskItemDto dto, string userId)
    {
        var task = mapper.Map<TaskItem>(dto);
        if(task is null)
            throw new NullReferenceException("Failed to create task");
        task.UserId = userId;
        task.Done = false;
        return await repository.CreateAsync(task);
    }

    public async Task<IEnumerable<ReadTaskItemDto>> GetAllAsync(User user)
    {
        var result = await repository.GetAllAsync(user);
        if (result is null)
            throw new NullReferenceException("No tasks found");
        var finalResult = mapper.Map<IEnumerable<ReadTaskItemDto>>(result);
        return finalResult;
    }

    public async Task<ReadTaskItemDto> GetByIdAsync(Guid id)
    {
        var result = await repository.GetByIdAsync(id);
        return mapper.Map<ReadTaskItemDto>(result);
    }

    public async Task<bool> UpdateAsync(UpdateTaskItemDto dto, string userId)
    {
        var task = await repository.GetByIdAsync(dto.Id);
        if (task == null || task.UserId != userId)
            return false;
        mapper.Map(dto, task);
        var result = await repository.UpdateAsync(task);
        return result > 0; // UpdateAsync returns int of how many lines were changed, result > 0 is a comparision
    }

    public async Task<bool> DeleteAsync(Guid id, string  userId)
    {  
        var task = await repository.GetByIdAsync(id);
        if (task == null || task.UserId != userId)
            return false;
        var result = await repository.DeleteAsync(task);
        return result > 0;
    }
}