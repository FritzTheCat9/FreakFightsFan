using Carter;
using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using MediatR;

namespace FreakFightsFan.Api.Features.Teams.Commands
{
    public static class DeleteTeam
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
            private readonly ITeamRepository _teamRepository;

            public Handler(ITeamRepository teamRepository)
            {
                _teamRepository = teamRepository;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var team = await _teamRepository.Get(command.Id) ?? throw new MyNotFoundException();
                await _teamRepository.Delete(team);
                return Unit.Value;
            }
        }
    }

    public class DeleteTeamEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/teams/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new DeleteTeam.Command() { Id = id };
                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Teams");
        }
    }
}
