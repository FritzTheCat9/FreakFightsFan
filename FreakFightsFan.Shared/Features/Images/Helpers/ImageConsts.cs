namespace FreakFightsFan.Shared.Features.Images.Helpers;

public static class ImageConsts
{
    public const int MaxFileSize = 5242880; // 5MB = 5 242 880 bytes

    public static readonly List<string>
        AllowedFileTypes = ["image/jpg", "image/jpeg", "image/png"]; // "jpg", "jpeg", "png"
}