using Carter;
using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
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

            public Handler(IImageRepository imageRepository)
            {
                _imageRepository = imageRepository;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var image = await _imageRepository.Get(command.Id) ?? throw new MyNotFoundException();
                await _imageRepository.Delete(image);
                return Unit.Value;
            }
        }
    }

    public class DeleteImageEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/images/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new DeleteImage.Command() { Id = id };
                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Images");
        }
    }
}
