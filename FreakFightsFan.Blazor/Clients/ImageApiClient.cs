using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Shared.Features.Images.Queries;
using FreakFightsFan.Shared.Features.Images.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IImageApiClient
    {
        Task<PagedList<ImageDto>> GetAllImages(GetAllImages.Query query);
        Task<ImageDto> GetImage(int id);
        Task CreateImage(CreateImage.Command command);
        Task UpdateImage(UpdateImage.Command command);
        Task DeleteImage(int id);
    }

    public class ImageApiClient : IImageApiClient
    {
        private readonly IApiClient _apiClient;
        private readonly string _url = "api/images";

        public ImageApiClient(IApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<PagedList<ImageDto>> GetAllImages(GetAllImages.Query query)
            => await _apiClient.Post<GetAllImages.Query, PagedList<ImageDto>>($"{_url}/all", query);

        public async Task<ImageDto> GetImage(int id)
            => await _apiClient.Get<ImageDto>($"{_url}/{id}");

        public async Task CreateImage(CreateImage.Command command)
            => await _apiClient.Post(_url, command);

        public async Task UpdateImage(UpdateImage.Command command)
            => await _apiClient.Put($"{_url}/{command.Id}", command);

        public async Task DeleteImage(int id)
            => await _apiClient.Delete($"{_url}/{id}");
    }
}
