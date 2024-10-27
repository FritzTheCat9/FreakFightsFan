using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Queries;
using FreakFightsFan.Shared.Features.Users.Responses;

namespace FreakFightsFan.Blazor.Clients;

public interface IUserApiClient
{
    Task<bool> ConfirmEmail(ConfirmEmail.Command command);
    Task DegradeUser(int id);
    Task<JwtDto> Login(Login.Command command);
    Task PromoteUser(int id);
    Task<JwtDto> RefreshToken(RefreshToken.Command command);
    Task Register(Register.Command command);
    Task UpdateUser(UpdateUser.Command command);
    Task UpdateUserTheme(UpdateUserTheme.Command command);
    Task<PagedList<UserDto>> GetAllUsers(GetAllUsers.Query query);
    Task<UserDto> GetUser(int id);
}

public class UserApiClient(IApiClient apiClient) : IUserApiClient
{
    private const string _url = "api/users";

    public async Task<bool> ConfirmEmail(ConfirmEmail.Command command)
    {
        return await apiClient.Post<ConfirmEmail.Command, bool>($"{_url}/confirmEmail", command);
    }

    public async Task DegradeUser(int id)
    {
        await apiClient.Put($"{_url}/degrade/{id}");
    }

    public async Task<JwtDto> Login(Login.Command command)
    {
        return await apiClient.Post<Login.Command, JwtDto>($"{_url}/login", command);
    }

    public async Task PromoteUser(int id)
    {
        await apiClient.Put($"{_url}/promote/{id}");
    }

    public async Task<JwtDto> RefreshToken(RefreshToken.Command command)
    {
        return await apiClient.Post<RefreshToken.Command, JwtDto>($"{_url}/refresh-token", command);
    }

    public async Task Register(Register.Command command)
    {
        await apiClient.Post($"{_url}/register", command);
    }

    public async Task UpdateUser(UpdateUser.Command command)
    {
        await apiClient.Put($"{_url}/{command.Id}", command);
    }

    public async Task UpdateUserTheme(UpdateUserTheme.Command command)
    {
        await apiClient.Put($"{_url}/{command.Id}/theme", command);
    }

    public async Task<PagedList<UserDto>> GetAllUsers(GetAllUsers.Query query)
    {
        return await apiClient.Post<GetAllUsers.Query, PagedList<UserDto>>($"{_url}/all", query);
    }

    public async Task<UserDto> GetUser(int id)
    {
        return await apiClient.Get<UserDto>($"{_url}/{id}");
    }
}