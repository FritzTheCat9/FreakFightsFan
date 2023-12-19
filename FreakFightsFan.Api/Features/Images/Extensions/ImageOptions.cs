namespace FreakFightsFan.Api.Features.Images.Extensions
{
    public class ImageOptions
    {
        public int MaxFileSize { get; set; }
        public List<string> AllowedFileTypes { get; set; }
        public string FolderName { get; set; }
        public string FederationImagesFolderName { get; set; }
        public string ImportWebsite { get; set; }
    }
}

