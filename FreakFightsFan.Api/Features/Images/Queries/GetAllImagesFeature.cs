using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Extensions;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Queries;
using FreakFightsFan.Shared.Features.Images.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Queries
{
    public static class GetAllImagesFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/images/all", async (
                GetAllImages.Query query,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithTags("Images")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<GetAllImages.Query, PagedList<ImageDto>>
        {
            private readonly IImageRepository _imageRepository;

            public Handler(IImageRepository imageRepository)
            {
                _imageRepository = imageRepository;
            }

            public async Task<PagedList<ImageDto>> Handle(
                GetAllImages.Query query,
                CancellationToken cancellationToken)
            {
                var imagesQuery = _imageRepository.AsQueryable();

                imagesQuery = imagesQuery.SortImages(query);

                var imagesPagedList = PageListExtensions<ImageDto>.Create(imagesQuery.Select(x => x.ToDto()),
                                                                          query.Page,
                                                                          query.PageSize);

                return await Task.FromResult(imagesPagedList);
            }
        }
    }
}
