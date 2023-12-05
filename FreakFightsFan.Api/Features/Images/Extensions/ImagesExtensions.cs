using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Images.Commands;
using FreakFightsFan.Api.Features.Images.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Requests;
using FreakFightsFan.Shared.Features.Images.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Images.Extensions
{
    public static class ImagesExtensions
    {
        public static IEndpointRouteBuilder AddImageEndpoints(this IEndpointRouteBuilder app)
        {
            CreateImage.Endpoint(app);
            DeleteImage.Endpoint(app);
            UpdateImage.Endpoint(app);
            GetAllImages.Endpoint(app);
            GetImage.Endpoint(app);

            return app;
        }

        public static ImageDto ToDto(this Image image)
        {
            return new ImageDto
            {
                Id = image.Id,
                Created = image.Created,
                Modified = image.Modified,
                Name = image.Name,
                Url = image.Url
            };
        }

        public static CreateImage.Command ToCreateImageCommand(this CreateImageRequest request)
        {
            return new CreateImage.Command
            {
                ImageBase64 = request.ImageBase64,
            };
        }

        public static UpdateImage.Command ToUpdateImageCommand(this UpdateImageRequest request, int id)
        {
            return new UpdateImage.Command
            {
                Id = id,
                ImageBase64 = request.ImageBase64
            };
        }

        public static GetAllImages.Query ToGetAllImagesQuery(this GetAllImagesRequest request)
        {
            return new GetAllImages.Query
            {
                Page = request.Page,
                PageSize = request.PageSize,
                SortOrder = request.SortOrder,
                SortColumn = request.SortColumn,
            };
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
                "name" => image => image.Name,
                "url" => image => image.Url,
                _ => image => image.Created,
            };
        }
    }
}
