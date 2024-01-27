using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class UpdateImageFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/images/{id}", async (
                int id,
                UpdateImage.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Images")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<UpdateImage.Command, Unit>
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

            public async Task<Unit> Handle(
                UpdateImage.Command command,
                CancellationToken cancellationToken)
            {
                var image = await _imageRepository.Get(command.Id) ?? throw new MyNotFoundException();

                string name = _imageService.SaveImage(command.ImageBase64);
                _imageService.DeleteImage(image.Name);

                image.Modified = _clock.Current();
                image.Name = name;
                image.Url = _imageService.GetImageUrl(name);

                await _imageRepository.Update(image);
                return Unit.Value;
            }
        }
    }
}
