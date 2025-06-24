using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NewAPI.Entities;

namespace NewAPI.Data.Configurations;

public class TaskConfiguration : IEntityTypeConfiguration<TaskItem>
{
    public void Configure(EntityTypeBuilder<TaskItem> builder)
    {
        // props config
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();
        
        builder.Property(x => x.Title).IsRequired().HasMaxLength(50);
        
        builder.Property(x => x.Description).HasMaxLength(250);
        
        builder.Property(x => x.UserId).IsRequired();
        
        // entity relation
        builder.HasOne(x => x.User).WithMany(x => x.Tasks).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);
    }
}