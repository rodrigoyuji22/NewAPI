using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;
using NewAPI.Entities;
using NewAPI.Repositories;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Services;

public class UserService(UserRepository userRepository, SignInManager<User> signInManager) : IUserService
{
   
    public async Task<IdentityResult> CreateAsync(CreateUserDto dto)
    {
        return await userRepository.CreateAsync(dto);
    }

    public async Task<string?> LoginAsync(LoginUserDto dto)
    {
        var result = await signInManager.PasswordSignInAsync(dto.Email, dto.Password, false, false);
        // result stores a signInResult
        throw new NotImplementedException();
    }
}