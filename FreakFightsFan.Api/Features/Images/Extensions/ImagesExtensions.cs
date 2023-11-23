using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Images.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Images.Extensions
{
    public static class ImagesExtensions
    {
        public static ImageDto ToDto(this Image image)
        {
            return new ImageDto
            {
                Id = image.Id,
                Created = image.Created,
                Modified = image.Modified,
                ImageBase64 = image.GetImageBase64(),
            };
        }

        private static string GetImageBase64(this Image image)
        {
            return $"data:{image.ContentType};base64,{Convert.ToBase64String(image.Data)}";
        }

        public static IQueryable<Image> SortImages(this IQueryable<Image> images, GetAllImages.Query query)
        {
            return query.SortOrder switch
            {
                SortOrder.Ascending => images.OrderBy(GetImageSortProperty(query)),
                SortOrder.Descending => images.OrderByDescending(GetImageSortProperty(query)),
                SortOrder.None => images.OrderByDescending(image => image.Created),
                _ => images.OrderByDescending(image => image.Created),
            };
        }

        private static Expression<Func<Image, object>> GetImageSortProperty(GetAllImages.Query query)
        {
            return query.SortColumn.ToLowerInvariant() switch
            {
                "created" => image => image.Created,
                "modified" => image => image.Modified,
                _ => image => image.Created,
            };
        }
    }
}
