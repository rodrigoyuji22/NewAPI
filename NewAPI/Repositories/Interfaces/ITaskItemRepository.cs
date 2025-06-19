using NewAPI.Entities;

namespace NewAPI.Repositories.Interfaces;

public interface ITaskItemRepository
{
    Task<TaskItem> CreateAsync(TaskItem? taskIte);
    Task<IEnumerable<TaskItem>> GetAllAsync(User user);
    Task<TaskItem?> GetByIdAsync(Guid id);
    Task <int> UpdateAsync (TaskItem task);
    Task<int> DeleteAsync(TaskItem task);
}