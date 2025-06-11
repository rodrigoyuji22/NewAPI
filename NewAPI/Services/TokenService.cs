using NewAPI.Entities;
using NewAPI.Repositories;
using NewAPI.Repositories.Interfaces;

namespace NewAPI.Services;

public class TokenService(UserRepository repo) : ITokenService
{
    public string GenerateToken(User user)
    {
        // return repo.GetUserByEmailAsync(user.Email);
    }
}