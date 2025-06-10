using Microsoft.AspNetCore.Identity;
using NewAPI.Dtos;
using NewAPI.Entities;
using NewAPI.Repositories;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Services;

public class UserService : IUserService
{
    private UserRepository _userRepository;
    private UserManager<User> _userManager;
    private SignInManager<User> _signInManager;

    public UserService(UserRepository userRepository, UserManager<User> userManager, SignInManager<User> signInManager)
    {
        _userRepository = userRepository;
        _userManager = userManager;
        _signInManager = signInManager;
    }
    
    public async Task<IdentityResult> CreateAsync(CreateUserDto dto)
    {
        return await _userRepository.RegisterAsync(dto);
    }

    public async Task<string?> LoginAsync(LoginUserDto dto)
    {
        var result = await _signInManager.PasswordSignInAsync(dto.Email, dto.Password, false, false);
        throw new NotImplementedException();
    }
}