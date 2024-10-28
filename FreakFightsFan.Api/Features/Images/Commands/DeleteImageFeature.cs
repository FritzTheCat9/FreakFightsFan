using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Commands;

public static class DeleteImageFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/api/images/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DeleteImage.Command { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Images)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IImageRepository imageRepository,
        IImageService imageService)
        : IRequestHandler<DeleteImage.Command, Unit>
    {
        public async Task<Unit> Handle(
            DeleteImage.Command command,
            CancellationToken cancellationToken)
        {
            var image = await imageRepository.Get(command.Id) ?? throw new MyNotFoundException();

            imageService.DeleteImage(image.Name);

            await imageRepository.Delete(image);
            return Unit.Value;
        }
    }
}