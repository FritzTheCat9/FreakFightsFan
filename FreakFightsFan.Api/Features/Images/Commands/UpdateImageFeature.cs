using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Commands;

public static class UpdateImageFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPut("/api/images/{id:int}", async (
                int id,
                UpdateImage.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Images)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IImageRepository imageRepository,
        IClock clock,
        IImageService imageService)
        : IRequestHandler<UpdateImage.Command, Unit>
    {
        public async Task<Unit> Handle(
            UpdateImage.Command command,
            CancellationToken cancellationToken)
        {
            var image = await imageRepository.Get(command.Id) ?? throw new MyNotFoundException();

            var name = imageService.SaveImage(command.ImageBase64);
            imageService.DeleteImage(image.Name);

            image.Modified = clock.Current();
            image.Name = name;
            image.Url = imageService.GetImageUrl(name);

            await imageRepository.Update(image);
            return Unit.Value;
        }
    }
}