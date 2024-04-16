using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class DeleteImageFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/images/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DeleteImage.Command() { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags(Tags.Images)
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<DeleteImage.Command, Unit>
        {
            private readonly IImageRepository _imageRepository;
            private readonly IImageService _imageService;

            public Handler(
                IImageRepository imageRepository,
                IImageService imageService)
            {
                _imageRepository = imageRepository;
                _imageService = imageService;
            }

            public async Task<Unit> Handle(
                DeleteImage.Command command,
                CancellationToken cancellationToken)
            {
                var image = await _imageRepository.Get(command.Id) ?? throw new MyNotFoundException();

                _imageService.DeleteImage(image.Name);

                await _imageRepository.Delete(image);
                return Unit.Value;
            }
        }
    }
}
