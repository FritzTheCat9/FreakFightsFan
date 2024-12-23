﻿using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Commands;
using FreakFightsFan.Shared.Features.Dictionaries.Queries;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;

namespace FreakFightsFan.Blazor.Clients;

public interface IMyDictionaryApiClient
{
    Task<PagedList<MyDictionaryDto>> GetAllMyDictionaries(GetAllMyDictionaries.Query query);
    Task<MyDictionaryDto> GetMyDictionary(int id);
    Task CreateMyDictionary(CreateMyDictionary.Command command);
    Task UpdateMyDictionary(UpdateMyDictionary.Command command);
    Task DeleteMyDictionary(int id);
}

public class MyDictionaryApiClient(IApiClient apiClient) : IMyDictionaryApiClient
{
    private const string _url = "api/myDictionaries";

    public async Task<PagedList<MyDictionaryDto>> GetAllMyDictionaries(GetAllMyDictionaries.Query query)
    {
        return await apiClient.Post<GetAllMyDictionaries.Query, PagedList<MyDictionaryDto>>($"{_url}/all", query);
    }

    public async Task<MyDictionaryDto> GetMyDictionary(int id)
    {
        return await apiClient.Get<MyDictionaryDto>($"{_url}/{id}");
    }

    public async Task CreateMyDictionary(CreateMyDictionary.Command command)
    {
        await apiClient.Post(_url, command);
    }

    public async Task UpdateMyDictionary(UpdateMyDictionary.Command command)
    {
        await apiClient.Put($"{_url}/{command.Id}", command);
    }

    public async Task DeleteMyDictionary(int id)
    {
        await apiClient.Delete($"{_url}/{id}");
    }
}