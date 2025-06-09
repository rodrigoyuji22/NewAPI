using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;

namespace NewAPI.Repositories.Interfaces;

public interface IUserRepository
{
    Task<IdentityResult> RegisterAsync(CreateUserDto dto);
}