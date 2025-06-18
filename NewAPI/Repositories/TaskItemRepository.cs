using Microsoft.EntityFrameworkCore;
using NewAPI.Data;
using NewAPI.Entities;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Repositories;

public class TaskItemRepository(AppDbContext context) : ITaskItemRepository
{
    public async Task<TaskItem> CreateAsync(TaskItem? taskItem)
    {
        context.TaskItems.Add(taskItem);
        await context.SaveChangesAsync();
        return taskItem!;
    }

    public async Task<TaskItem?> GetByIdAsync(Guid id)
    {
        return await context.TaskItems.FirstOrDefaultAsync(taskItem => taskItem != null && taskItem.Id == id);
    }

    public Task<IEnumerable<TaskItem>> GetAllAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<TaskItem> UpdateAsync(TaskItem task)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(TaskItem task)
    {
        throw new NotImplementedException();
    }
}