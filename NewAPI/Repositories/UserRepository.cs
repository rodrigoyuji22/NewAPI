using Microsoft.AspNetCore.Identity;
using NewAPI.Entities;
using NewAPI.Repositories.Interfaces;
using JetBrains.Annotations;

namespace NewAPI.Repositories;

// removing the "never instantiated" warning due to services DI
[UsedImplicitly]
public class UserRepository(UserManager<User> userManager) : IUserRepository
{
    public async Task<IdentityResult> CreateAsync(User user, string password)
    {
        return await userManager.CreateAsync(user, password);
    }

    public async Task<User?> GetByNameAsync(string userName)
    {
        return await userManager.FindByNameAsync(userName);
    }
    public async Task<bool> BeUniqueEmail(string email)
    {
        var result = await userManager.FindByEmailAsync(email);
        if (result is not null)
            return false;
        return true;
    }
}