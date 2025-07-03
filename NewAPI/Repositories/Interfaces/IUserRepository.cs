using Microsoft.AspNetCore.Identity;
using NewAPI.Entities;

namespace NewAPI.Repositories.Interfaces;

public interface IUserRepository
{
    Task<IdentityResult> CreateAsync(User user, string password);
    Task<User?> GetByNameAsync(string userName);
    Task <bool> BeUniqueEmail(string email);
}