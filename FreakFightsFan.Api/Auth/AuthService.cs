using FreakFightsFan.Shared.Exceptions;
using System.Security.Claims;

namespace FreakFightsFan.Api.Auth;

public interface IAuthService
{
    bool IsInRole(string roleName);
    bool IsInAnyRole(params string[] roleNames);
    bool IsLoggedInUser(int userId);
    int? GetCurrentUserId();
}

public class AuthService : IAuthService
{
    public AuthService(IHttpContextAccessor httpContextAccessor)
    {
        if (httpContextAccessor.HttpContext is null)
        {
            throw new MyServerException();
        }

        User = httpContextAccessor.HttpContext.User;
    }

    public ClaimsPrincipal User { get; }

    public bool IsInRole(string roleName)
    {
        return User.IsInRole(roleName);
    }

    public bool IsInAnyRole(params string[] roleNames)
    {
        foreach (var roleName in roleNames)
        {
            if (User.IsInRole(roleName))
            {
                return true;
            }
        }

        return false;
    }

    public bool IsLoggedInUser(int userId)
    {
        var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

        if (userIdString == null)
        {
            return false;
        }

        if (!int.TryParse(userIdString, out var userIdInt))
        {
            return false;
        }

        if (userId != userIdInt)
        {
            return false;
        }

        return true;
    }

    public int? GetCurrentUserId()
    {
        if (User.Identity?.IsAuthenticated ?? false)
        {
            var userIdString = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            if (userIdString == null)
            {
                return null;
            }

            if (!int.TryParse(userIdString, out var userIdInt))
            {
                return null;
            }

            return userIdInt;
        }

        return null;
    }
}