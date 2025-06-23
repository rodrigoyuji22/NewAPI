using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NewAPI.Data.Configurations;
using NewAPI.Entities;


namespace NewAPI.Data;

public class AppDbContext(DbContextOptions<AppDbContext>options) : IdentityDbContext<User>(options)
{
    public DbSet<TaskItem> TaskItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new TaskConfiguration());
    }
}
