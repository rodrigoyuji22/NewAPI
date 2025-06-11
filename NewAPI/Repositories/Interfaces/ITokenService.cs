using NewAPI.Entities;

namespace NewAPI.Repositories.Interfaces;

public interface ITokenService
{
    string GenerateToken(User user);
}