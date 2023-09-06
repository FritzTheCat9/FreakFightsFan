using Carter;
using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
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

            public Handler(IFighterRepository fighterRepository)
            {
                _fighterRepository = fighterRepository;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var fighter = await _fighterRepository.Get(command.Id) ?? throw new MyNotFoundException();
                await _fighterRepository.Delete(fighter);
                return Unit.Value;
            }
        }
    }

    public class DeleteFighterEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/fighters", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new DeleteFighter.Command() { Id = id };
                    return Results.Ok(await mediator.Send(command, cancellationToken));
                });
        }
    }
}
