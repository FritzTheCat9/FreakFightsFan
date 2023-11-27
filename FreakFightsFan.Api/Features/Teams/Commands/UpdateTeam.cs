using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Teams.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Teams.Commands
{
    public static class UpdateTeam
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly ITeamRepository _teamRepository;
            private readonly IClock _clock;

            public Handler(ITeamRepository teamRepository, IClock clock)
            {
                _teamRepository = teamRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var team = await _teamRepository.Get(command.Id) ?? throw new MyNotFoundException();
                team.Modified = _clock.Current();
                team.Name = command.Name;

                await _teamRepository.Update(team);
                return Unit.Value;
            }
        }
    }

    public class UpdateTeamEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/api/teams/{id}", async (
                int id,
                UpdateTeamRequest updateTeamRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new UpdateTeam.Command()
                    {
                        Id = id,
                        Name = updateTeamRequest.Name,
                    };

                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Teams");
        }
    }
}
