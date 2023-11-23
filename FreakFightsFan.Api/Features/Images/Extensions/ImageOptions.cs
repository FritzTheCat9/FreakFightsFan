namespace FreakFightsFan.Api.Features.Images.Extensions
{
    public class ImageOptions
    {
        public int MaxFileSize { get; set; } = 5242880;
        public List<string> AllowedFileTypes { get; set; } = ["image/jpg", "image/jpeg", "image/png"];
    }
}

