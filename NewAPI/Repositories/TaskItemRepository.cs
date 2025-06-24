using Microsoft.EntityFrameworkCore;
using NewAPI.Data;
using NewAPI.Dtos;
using NewAPI.Entities;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Repositories;

public class TaskItemRepository(AppDbContext context) : ITaskItemRepository
{
    public async Task<TaskItem> CreateAsync(TaskItem? taskItem)
    {
        context.TaskItems.Add(taskItem!);
        await context.SaveChangesAsync();
        return taskItem!;
    }

    public async Task<TaskItem?> GetByIdAsync(Guid id)
    {
        return await context.TaskItems.FirstOrDefaultAsync(taskItem => taskItem.Id == id);
    }

    public async Task<IEnumerable<TaskItem>> GetAllAsync(string userId)
    {
        return await context.TaskItems.Where(x => x.UserId == userId).ToListAsync();
    }

    public async Task<int> UpdateAsync(TaskItem task)
    {
        context.TaskItems.Update(task);
        return await context.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(TaskItem task)
    {
        context.TaskItems.Remove(task);
        return await context.SaveChangesAsync();
    }
}