using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Shared.Features.Images.Queries;
using FreakFightsFan.Shared.Features.Images.Responses;

namespace FreakFightsFan.Blazor.Clients;

public interface IImageApiClient
{
    Task<PagedList<ImageDto>> GetAllImages(GetAllImages.Query query);
    Task<ImageDto> GetImage(int id);
    Task CreateImage(CreateImage.Command command);
    Task UpdateImage(UpdateImage.Command command);
    Task DeleteImage(int id);
}

public class ImageApiClient(IApiClient apiClient) : IImageApiClient
{
    private const string _url = "api/images";

    public async Task<PagedList<ImageDto>> GetAllImages(GetAllImages.Query query)
    {
        return await apiClient.Post<GetAllImages.Query, PagedList<ImageDto>>($"{_url}/all", query);
    }

    public async Task<ImageDto> GetImage(int id)
    {
        return await apiClient.Get<ImageDto>($"{_url}/{id}");
    }

    public async Task CreateImage(CreateImage.Command command)
    {
        await apiClient.Post(_url, command);
    }

    public async Task UpdateImage(UpdateImage.Command command)
    {
        await apiClient.Put($"{_url}/{command.Id}", command);
    }

    public async Task DeleteImage(int id)
    {
        await apiClient.Delete($"{_url}/{id}");
    }
}