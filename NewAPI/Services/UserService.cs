using AutoMapper;
using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;
using NewAPI.Entities;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Services;

public class UserService(IUserRepository userRepository ,SignInManager<User> signInManager, IMapper mapper, ITokenService tokenService) : IUserService
{
   
    public async Task<IdentityResult> CreateAsync(CreateUserDto dto)
    {
        if(await userRepository.BeUniqueEmail(dto.Email) == false)
            throw new ApplicationException("Email already exists");
        
        var user = mapper.Map<User>(dto);
        return await userRepository.CreateAsync(user, dto.Password);
    }

    public async Task<string?> LoginAsync(LoginUserDto dto)
    {
        var result = await signInManager.PasswordSignInAsync(dto.UserName, dto.Password, false, false);
        if (!result.Succeeded)
        {
            throw new ApplicationException("Invalid username or password");
        }
        var validUser = await userRepository.GetByNameAsync(dto.UserName);
        return tokenService.GenerateToken(validUser!);
    }
}