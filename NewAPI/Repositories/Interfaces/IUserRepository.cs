using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;

namespace NewAPI.Repositories.Interfaces;

public interface IUserRepository
{
    Task<IdentityResult> CreateAsync(CreateUserDto dto);
}