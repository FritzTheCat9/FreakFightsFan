using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Requests;
using FreakFightsFan.Shared.Features.Images.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IImageApiClient
    {
        Task<PagedList<ImageDto>> GetAllImages(GetAllImagesRequest request);
        Task<ImageDto> GetImage(int id);
        Task CreateImage(CreateImageRequest request);
        Task UpdateImage(UpdateImageRequest request);
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

        public async Task<PagedList<ImageDto>> GetAllImages(GetAllImagesRequest request)
        {
            return await _apiClient.Post<GetAllImagesRequest, PagedList<ImageDto>>($"{_url}/all", request);
        }

        public async Task<ImageDto> GetImage(int id)
        {
            return await _apiClient.Get<ImageDto>($"{_url}/{id}");
        }

        public async Task CreateImage(CreateImageRequest request)
        {
            await _apiClient.Post(_url, request);
        }

        public async Task UpdateImage(UpdateImageRequest request)
        {
            await _apiClient.Put($"{_url}/{request.Id}", request);
        }

        public async Task DeleteImage(int id)
        {
            await _apiClient.Delete($"{_url}/{id}");
        }
    }
}
