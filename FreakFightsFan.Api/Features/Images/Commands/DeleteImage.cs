using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Images.Commands
{
    public static class DeleteImage
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {

        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IImageRepository _imageRepository;
            private readonly IImageService _imageService;

            public Handler(IImageRepository imageRepository, IImageService imageService)
            {
                _imageRepository = imageRepository;
                _imageService = imageService;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var image = await _imageRepository.Get(command.Id) ?? throw new MyNotFoundException();

                _imageService.DeleteImage(image.Name);

                await _imageRepository.Delete(image);
                return Unit.Value;
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/images/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new Command() { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Images")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
