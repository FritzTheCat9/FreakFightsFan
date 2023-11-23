using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Requests;
using FreakFightsFan.Shared.Features.Images.Responses;

namespace FreakFightsFan.Blazor.Services
{
    public interface IImageHttpService
    {
        Task<PagedList<ImageDto>> GetAllImages(GetAllImagesRequest getAllImagesRequest);
        Task<ImageDto> GetImage(int id);
        Task CreateImage(CreateImageRequest createImageRequest);
        Task UpdateImage(UpdateImageRequest updateImageRequest);
        Task DeleteImage(int id);
    }

    public class ImageHttpService : IImageHttpService
    {
        private readonly IHttpService _httpService;
        private readonly string _url = "api/images";

        public ImageHttpService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<PagedList<ImageDto>> GetAllImages(GetAllImagesRequest getAllImagesRequest)
        {
            return await _httpService.Post<GetAllImagesRequest, PagedList<ImageDto>>(_url + "/all", getAllImagesRequest);
        }

        public async Task<ImageDto> GetImage(int id)
        {
            return await _httpService.Get<ImageDto>(_url + id);
        }

        public async Task CreateImage(CreateImageRequest createImageRequest)
        {
            await _httpService.Post(_url, createImageRequest);
        }

        public async Task UpdateImage(UpdateImageRequest updateImageRequest)
        {
            await _httpService.Put(_url + "/" + updateImageRequest.Id, updateImageRequest);
        }

        public async Task DeleteImage(int id)
        {
            await _httpService.Delete(_url + "/" + id);
        }
    }
}
