using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Shared.Features.Images.Helpers;
using Microsoft.Extensions.Options;

namespace FreakFightsFan.Api.Services;

public interface IImageService
{
    string SaveImage(string imageBase64);
    void DeleteImage(string name);
    string GetImageUrl(string name);
    Image CreateEntityImage(string imageBase64);
    void DeleteEntityImage(Image image);
    Image UpdateEntityImage(Image image, string imageBase64);
}

public class ImageService : IImageService
{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IClock _clock;
    private readonly ImageOptions _options;
    private readonly string _folderPath;

    public ImageService(
        IWebHostEnvironment webHostEnvironment,
        IHttpContextAccessor httpContextAccessor,
        IOptions<ImageOptions> options,
        IClock clock)
    {
        _httpContextAccessor = httpContextAccessor;
        _clock = clock;
        _options = options.Value;
        _folderPath = Path.Combine(Path.GetFullPath(webHostEnvironment.WebRootPath), _options.FolderName);
    }

    public string SaveImage(string imageBase64)
    {
        var name = ImageHelpers.GenerateNameWithExtension(imageBase64);
        var imagePath = Path.Combine(_folderPath, name);

        Directory.CreateDirectory(_folderPath);

        var bytes = ImageHelpers.GetImageData(imageBase64);
        using var fs = File.OpenWrite(imagePath);
        fs.Write(bytes, 0, bytes.Length);

        return name;
    }

    public void DeleteImage(string name)
    {
        var imagePath = Path.Combine(_folderPath, name);

        File.Delete(imagePath);
    }

    public string GetImageUrl(string name)
    {
        var url = $"{_httpContextAccessor.HttpContext?.Request.Scheme}://{_httpContextAccessor.HttpContext?.Request.Host}";
        return $"{url}/{_options.FolderName}/{name}";
    }

    public Image CreateEntityImage(string imageBase64)
    {
        if (string.IsNullOrEmpty(imageBase64))
        {
            return null;
        }

        var name = SaveImage(imageBase64);

        var image = new Image
        {
            Id = 0,
            Created = _clock.Current(),
            Modified = _clock.Current(),
            Name = name,
            Url = GetImageUrl(name)
        };

        return image;
    }

    public void DeleteEntityImage(Image image)
    {
        if (image is not null)
        {
            DeleteImage(image.Name);
        }
    }

    public Image UpdateEntityImage(Image image, string imageBase64)
    {
        if (string.IsNullOrEmpty(imageBase64))
        {
            return image;
        }

        var imageName = SaveImage(imageBase64);

        if (image is not null)
        {
            DeleteImage(image.Name);

            image.Modified = _clock.Current();
            image.Name = imageName;
            image.Url = GetImageUrl(imageName);
        }
        else
        {
            image = new Image
            {
                Id = 0,
                Created = _clock.Current(),
                Modified = _clock.Current(),
                Name = imageName,
                Url = GetImageUrl(imageName)
            };
        }

        return image;
    }
}