using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Users.Commands;
using FreakFightsFan.Shared.Features.Users.Queries;
using FreakFightsFan.Shared.Features.Users.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IUserApiClient
    {
        Task<bool> ConfirmEmail(ConfirmEmail.Command command);
        Task DegradeUser(int id);
        Task<JwtDto> Login(Login.Command command);
        Task PromoteUser(int id);
        Task Register(Register.Command command);
        Task UpdateUser(UpdateUser.Command command);
        Task<PagedList<UserDto>> GetAllUsers(GetAllUsers.Query query);
        Task<UserDto> GetUser(int id);
    }

    public class UserApiClient : IUserApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/users";

        public UserApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<bool> ConfirmEmail(ConfirmEmail.Command command)
        {
            return await _apiClient.Post<ConfirmEmail.Command, bool>($"{_url}/confirmEmail", command);
        }

        public async Task DegradeUser(int id)
        {
            await _apiClient.Put($"{_url}/degrade/{id}");
        }

        public async Task<JwtDto> Login(Login.Command command)
        {
            return await _apiClient.Post<Login.Command, JwtDto>($"{_url}/login", command);
        }

        public async Task PromoteUser(int id)
        {
            await _apiClient.Put($"{_url}/promote/{id}");
        }

        public async Task Register(Register.Command command)
        {
            await _apiClient.Post($"{_url}/register", command);
        }

        public async Task UpdateUser(UpdateUser.Command command)
        {
            await _apiClient.Put($"{_url}/{command.Id}", command);
        }

        public async Task<PagedList<UserDto>> GetAllUsers(GetAllUsers.Query query)
        {
            return await _apiClient.Post<GetAllUsers.Query, PagedList<UserDto>>($"{_url}/all", query);
        }

        public async Task<UserDto> GetUser(int id)
        {
            return await _apiClient.Get<UserDto>($"{_url}/{id}");
        }
    }
}
