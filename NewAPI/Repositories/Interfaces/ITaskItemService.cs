using NewAPI.Dtos;
using NewAPI.Entities;

namespace NewAPI.Repositories.Interfaces;

public interface ITaskItemService
{
    Task<TaskItem> CreateTaskItemAsync(CreateTaskItemDto dto, string userId);
    Task<IEnumerable<ReadTaskItemDto>> GetAllAsync(User user);
    Task<ReadTaskItemDto> GetByIdAsync(Guid id);
    Task <bool> UpdateAsync (UpdateTaskItemDto dto, string userId);
    Task<bool> DeleteAsync(Guid id, string userId);
}