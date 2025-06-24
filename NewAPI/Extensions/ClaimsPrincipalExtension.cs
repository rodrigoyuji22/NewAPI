using System.Security.Claims;

namespace NewAPI.Extensions;

public static class ClaimsPrincipalExtension
{
    public static string? GetUserById(this ClaimsPrincipal user)
    {
        return user.FindFirst(ClaimTypes.NameIdentifier)?.Value;
    }
}