using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class CreateImageFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/images", async (
                CreateImage.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int imageId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetImage", new { id = imageId });
            })
                .WithTags("Images")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<CreateImage.Command, int>
        {
            private readonly IImageRepository _imageRepository;
            private readonly IClock _clock;
            private readonly IImageService _imageService;

            public Handler(
                IImageRepository imageRepository,
                IClock clock,
                IImageService imageService)
            {
                _imageRepository = imageRepository;
                _clock = clock;
                _imageService = imageService;
            }

            public async Task<int> Handle(
                CreateImage.Command command,
                CancellationToken cancellationToken)
            {
                string name = _imageService.SaveImage(command.ImageBase64);

                var image = new Image
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = name,
                    Url = _imageService.GetImageUrl(name)
                };

                return await _imageRepository.Create(image);
            }
        }
    }
}
