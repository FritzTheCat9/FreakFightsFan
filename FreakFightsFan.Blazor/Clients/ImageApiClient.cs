using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Requests;
using FreakFightsFan.Shared.Features.Images.Responses;

namespace FreakFightsFan.Blazor.Clients
{
    public interface IImageApiClient
    {
        Task<PagedList<ImageDto>> GetAllImages(GetAllImagesRequest getAllImagesRequest);
        Task<ImageDto> GetImage(int id);
        Task CreateImage(CreateImageRequest createImageRequest);
        Task UpdateImage(UpdateImageRequest updateImageRequest);
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

        public async Task<PagedList<ImageDto>> GetAllImages(GetAllImagesRequest getAllImagesRequest)
        {
            return await _apiClient.Post<GetAllImagesRequest, PagedList<ImageDto>>(_url + "/all", getAllImagesRequest);
        }

        public async Task<ImageDto> GetImage(int id)
        {
            return await _apiClient.Get<ImageDto>(_url + id);
        }

        public async Task CreateImage(CreateImageRequest createImageRequest)
        {
            await _apiClient.Post(_url, createImageRequest);
        }

        public async Task UpdateImage(UpdateImageRequest updateImageRequest)
        {
            await _apiClient.Put(_url + "/" + updateImageRequest.Id, updateImageRequest);
        }

        public async Task DeleteImage(int id)
        {
            await _apiClient.Delete(_url + "/" + id);
        }
    }
}
