using NewAPI.Entities;

namespace NewAPI.Repositories.Interfaces;

public interface ITaskItemRepository
{
    Task<TaskItem> CreateAsync(TaskItem? taskIte);
    Task<TaskItem?> GetByIdAsync(Guid id);
    Task<IEnumerable<TaskItem>> GetAllAsync(User user);
    Task <TaskItem> UpdateAsync (TaskItem task);
    Task DeleteAsync(TaskItem task);
}