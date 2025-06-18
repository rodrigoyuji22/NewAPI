using Microsoft.AspNetCore.Identity;

namespace NewAPI.Entities;

public class User : IdentityUser
{
    public ICollection<TaskItem> Tasks { get; set; }
}
