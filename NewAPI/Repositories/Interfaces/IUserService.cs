using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;

namespace NewAPI.Repositories.Interfaces;

public interface IUserService
{
    Task<IdentityResult> CreateAsync(CreateUserDto dto);
    Task<string?> LoginAsync(LoginUserDto dto);
}