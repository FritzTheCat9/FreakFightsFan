using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Images.Commands;
using FreakFightsFan.Api.Features.Images.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Queries;
using FreakFightsFan.Shared.Features.Images.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Images.Extensions;

public static class ImagesExtensions
{
    public static IEndpointRouteBuilder AddImageEndpoints(this IEndpointRouteBuilder app)
    {
        CreateImageFeature.Endpoint(app);
        DeleteImageFeature.Endpoint(app);
        ImportFederationImagesFeature.Endpoint(app);
        ImportFighterImagesFeature.Endpoint(app);
        UpdateImageFeature.Endpoint(app);
        GetAllImagesFeature.Endpoint(app);
        GetImageFeature.Endpoint(app);

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

    public static IQueryable<Image> SortImages(
        this IQueryable<Image> images,
        GetAllImages.Query query)
    {
        return query.SortOrder switch
        {
            SortOrder.Ascending => images.OrderBy(GetImageSortProperty(query)),
            SortOrder.Descending => images.OrderByDescending(GetImageSortProperty(query)),
            SortOrder.None => images.OrderByDescending(image => image.Created),
            _ => images.OrderByDescending(image => image.Created)
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
            _ => image => image.Created
        };
    }
}