using AutoMapper;
using NewAPI.Dtos;
using NewAPI.Entities;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Services;

public class TaskItemService(ITaskItemRepository repository, IMapper mapper) : ITaskItemService
{
    public async Task<TaskItem> CreateTaskItemAsync(CreateTaskItemDto dto)
    {
        var task = mapper.Map<TaskItem>(dto);
        return await repository.CreateAsync(task);
    }

    public async Task<IEnumerable<ReadTaskItemDto>> GetAllAsync(User user)
    {
        var result = await repository.GetAllAsync(user);
        var finalResult = mapper.Map<IEnumerable<ReadTaskItemDto>>(result);
        return finalResult;
    }

    public async Task<ReadTaskItemDto> GetByIdAsync(Guid id)
    {
        var result = await repository.GetByIdAsync(id);
        return mapper.Map<ReadTaskItemDto>(result);
    }

    public async Task<int> UpdateAsync(TaskItem task)
    {
        throw new NotImplementedException();
        // return await repository.UpdateAsync(task);
    }

    public Task<int> DeleteAsync(TaskItem task) 
    {
        throw new NotImplementedException();
    }
}