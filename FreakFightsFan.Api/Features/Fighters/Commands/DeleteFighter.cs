using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Commands
{
    public static class DeleteFighter
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
            private readonly IFighterRepository _fighterRepository;
            private readonly IImageService _imageService;

            public Handler(IFighterRepository fighterRepository, IImageService imageService)
            {
                _fighterRepository = fighterRepository;
                _imageService = imageService;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var fighter = await _fighterRepository.Get(command.Id) ?? throw new MyNotFoundException();

                _imageService.DeleteEntityImage(fighter.Image);

                await _fighterRepository.Delete(fighter);
                return Unit.Value;
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/fighters/{id}", async (
               int id,
               IMediator mediator,
               CancellationToken cancellationToken) =>
            {
                var command = new Command() { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
               .WithTags("Fighters");

            return app;
        }
    }
}
