using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;
using NewAPI.Entities;

namespace NewAPI.Repositories.Interfaces;

public interface IUserRepository
{
    Task<IdentityResult> CreateAsync(User user, string password);
    Task<User?> GetUserByEmailAsync(string email);
}