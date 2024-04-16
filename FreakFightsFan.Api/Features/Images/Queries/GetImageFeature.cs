using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Images.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Images.Queries;
using FreakFightsFan.Shared.Features.Images.Responses;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Queries
{
    public static class GetImageFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/images/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetImage.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetImage")
                .WithTags(Tags.Images)
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<GetImage.Query, ImageDto>
        {
            private readonly IImageRepository _imageRepository;

            public Handler(IImageRepository imageRepository)
            {
                _imageRepository = imageRepository;
            }

            public async Task<ImageDto> Handle(
                GetImage.Query query,
                CancellationToken cancellationToken)
            {
                var image = await _imageRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return image.ToDto();
            }
        }
    }
}
