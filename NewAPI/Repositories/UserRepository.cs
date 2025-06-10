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
    public Task<IdentityResult> CreateAsync(CreateUserDto dto)
    {
        throw new NotImplementedException();
    }
}