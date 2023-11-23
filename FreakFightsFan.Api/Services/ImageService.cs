using FreakFightsFan.Api.Features.Images.Extensions;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Services
{
    public interface IImageService
    {
        string SaveImage(string imageBase64);
        void DeleteImage(string name);
        string GetImageUrl(string name);
    }

    public class ImageService : IImageService
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ImageOptions _options;
        private readonly string _folderPath;

        public ImageService(IWebHostEnvironment webHostEnvironment, IHttpContextAccessor httpContextAccessor, IOptions<ImageOptions> options)
        {
            _webHostEnvironment = webHostEnvironment;
            _httpContextAccessor = httpContextAccessor;
            _options = options.Value;
            _folderPath = $"{_webHostEnvironment.WebRootPath}\\{_options.FolderName}";
        }

        public string SaveImage(string imageBase64)
        {
            var name = ImageHelpers.GenerateNameWithExtension(imageBase64);
            var imagePath = $"{_folderPath}\\{name}";

            Directory.CreateDirectory(_folderPath);

            var bytes = ImageHelpers.GetImageData(imageBase64);
            using var fs = File.OpenWrite(imagePath);
            fs.Write(bytes, 0, bytes.Length);

            return name;
        }

        public void DeleteImage(string name)
        {
            var imagePath = $"{_folderPath}\\{name}";

            File.Delete(imagePath);
        }

        public string GetImageUrl(string name)
        {
            var url = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}";
            return $"{url}\\{_options.FolderName}\\{name}";
        }
    }
}
