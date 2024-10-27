using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Commands;

public static class CreateImageFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/images", async (
                CreateImage.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var imageId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetImage", new { id = imageId });
            })
            .WithTags(Tags.Images)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IImageRepository imageRepository,
        IClock clock,
        IImageService imageService)
        : IRequestHandler<CreateImage.Command, int>
    {
        public async Task<int> Handle(
            CreateImage.Command command,
            CancellationToken cancellationToken)
        {
            var name = imageService.SaveImage(command.ImageBase64);

            var image = new Image
            {
                Id = 0,
                Created = clock.Current(),
                Modified = clock.Current(),
                Name = name,
                Url = imageService.GetImageUrl(name)
            };

            return await imageRepository.Create(image);
        }
    }
}