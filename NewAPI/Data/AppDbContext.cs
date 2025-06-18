using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewAPI.Entities;


namespace NewAPI.Data;

public class AppDbContext(DbContextOptions<AppDbContext>options) : IdentityDbContext<User>(options)
{
    public DbSet<TaskItem> TaskItems { get; set; }
}
