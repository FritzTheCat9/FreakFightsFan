﻿using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Users.Requests;
using FreakFightsFan.Shared.Features.Users.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IUserApiClient
    {
        Task<bool> ConfirmEmail(string email, string token);
        Task DegradeUser(int id);
        Task<JwtDto> Login(LoginRequest request);
        Task PromoteUser(int id);
        Task Register(RegisterRequest request);
        Task UpdateUser(UpdateUserRequest request);
        Task<PagedList<UserDto>> GetAllUsers(GetAllUsersRequest request);
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

        public async Task<bool> ConfirmEmail(string email, string token)
        {
            return await _apiClient.Get<bool>($"{_url}/confirmEmail?email={email}&token={token}");
        }

        public async Task DegradeUser(int id)
        {
            await _apiClient.Put($"{_url}/degrade/{id}");
        }

        public async Task<JwtDto> Login(LoginRequest request)
        {
            return await _apiClient.Post<LoginRequest, JwtDto>($"{_url}/login", request);
        }

        public async Task PromoteUser(int id)
        {
            await _apiClient.Put($"{_url}/promote/{id}");
        }

        public async Task Register(RegisterRequest request)
        {
            await _apiClient.Post($"{_url}/register", request);
        }

        public async Task UpdateUser(UpdateUserRequest request)
        {
            await _apiClient.Put($"{_url}/{request.Id}", request);
        }

        public async Task<PagedList<UserDto>> GetAllUsers(GetAllUsersRequest request)
        {
            return await _apiClient.Post<GetAllUsersRequest, PagedList<UserDto>>($"{_url}/all", request);
        }

        public async Task<UserDto> GetUser(int id)
        {
            return await _apiClient.Get<UserDto>($"{_url}/{id}");
        }
    }
}
