using NewAPI.Dtos;
using NewAPI.Entities;

namespace NewAPI.Repositories.Interfaces;

public interface ITaskItemService
{
    Task<TaskItem> CreateTaskItemAsync(CreateTaskItemDto dto);
    Task<IEnumerable<ReadTaskItemDto>> GetAllAsync(User user);
    Task<ReadTaskItemDto> GetByIdAsync(Guid id);
    Task <int> UpdateAsync (TaskItem task);
    Task<int> DeleteAsync(TaskItem task);
}