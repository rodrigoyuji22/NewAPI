using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;
using NewAPI.Entities;

namespace NewAPI.Repositories.Interfaces;

public interface IUserService
{
    Task<IdentityResult> CreateAsync(CreateUserDto dto);
    Task<string?> LoginAsync(LoginUserDto dto);
}