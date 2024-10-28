using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace FreakFightsFan.Blazor.Auth;

public interface IAuthService
{
    Task<int?> GetCurrentUserId();
    Task<bool> IsLoggedInUser(int userId);
    Task Login(JwtDto token, string redirectUrl = null);
    Task Logout(string redirectUrl = null);
    Task RefreshToken();
}

public class AuthService(
    AuthenticationStateProvider stateProvider,
    IJwtProvider jwtProvider,
    IUserApiClient userApiClient,
    NavigationManager navigationManager)
    : IAuthService
{
    public async Task<int?> GetCurrentUserId()
    {
        var authStateProvider = stateProvider as AuthStateProvider;
        var authState = await authStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity?.IsAuthenticated ?? false)
        {
            var userIdString = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

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

    public async Task<bool> IsLoggedInUser(int userId)
    {
        var authStateProvider = stateProvider as AuthStateProvider;
        var authState = await authStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity?.IsAuthenticated ?? false)
        {
            var userIdString = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

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

        return false;
    }

    public async Task Login(JwtDto token, string redirectUrl = null)
    {
        await jwtProvider.SetJwtDto(token);

        var authStateProvider = stateProvider as AuthStateProvider;
        authStateProvider.NotifyAuthStateChanged();

        if (!string.IsNullOrEmpty(redirectUrl))
        {
            navigationManager.NavigateTo(redirectUrl);
        }
    }

    public async Task Logout(string redirectUrl = null)
    {
        await jwtProvider.RemoveJwtDto();

        var authStateProvider = stateProvider as AuthStateProvider;
        authStateProvider.NotifyAuthStateChanged();

        if (!string.IsNullOrEmpty(redirectUrl))
        {
            navigationManager.NavigateTo(redirectUrl);
        }
    }

    public async Task RefreshToken()
    {
        try
        {
            var jwt = await jwtProvider.GetJwtDto();
            if (jwt == null || string.IsNullOrEmpty(jwt.RefreshToken))
            {
                await Logout();
            }

            var newJwt =
                await userApiClient.RefreshToken(new RefreshToken.Command { RefreshToken = jwt.RefreshToken });
            await Login(newJwt);
        }
        catch (Exception)
        {
            await Logout();
        }
    }
}