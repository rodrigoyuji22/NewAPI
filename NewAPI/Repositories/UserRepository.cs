using AutoMapper;
using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;
using NewAPI.Entities;
using NewAPI.Repositories.Interfaces;
using JetBrains.Annotations;

namespace NewAPI.Repositories;

// removing the "never instantiated" warning due to services DI
[UsedImplicitly]
public class UserRepository(UserManager<User> userManager, IMapper mapper) : IUserRepository
{
    public async Task<IdentityResult> CreateAsync(User user, string password)
    {
        return await userManager.CreateAsync(user, password);
    }

    public async Task<User?> GetUserByEmailAsync(string email)
    {
        return await userManager.FindByEmailAsync(email);
    }
}