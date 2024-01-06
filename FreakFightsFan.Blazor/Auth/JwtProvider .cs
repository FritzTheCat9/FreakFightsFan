﻿using Blazored.LocalStorage;
using FreakFightsFan.Shared.Features.Users.Responses;

namespace FreakFightsFan.Blazor.Auth
{
    public interface IJwtProvider
    {
        Task<JwtDto> GetJwtDto();
        Task SetJwtDto(JwtDto token);
        Task RemoveJwtDto();
    }

    public class JwtProvider : IJwtProvider
    {
        private readonly ILocalStorageService _localStorageService;

        public JwtProvider(ILocalStorageService localStorageService)
        {
            _localStorageService = localStorageService;
        }

        public async Task<JwtDto> GetJwtDto()
        {
            var token = await _localStorageService.GetItemAsync<JwtDto>(Jwt.Dto);
            return token ?? null;
        }

        public async Task SetJwtDto(JwtDto token)
        {
            await _localStorageService.SetItemAsync(Jwt.Dto, token);
        }

        public async Task RemoveJwtDto()
        {
            await _localStorageService.RemoveItemAsync(Jwt.Dto);
        }
    }
}
