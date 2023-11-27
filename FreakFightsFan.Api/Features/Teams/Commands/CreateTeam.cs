using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Features.Teams.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Teams.Commands
{
    public static class CreateTeam
    {
        public class Command : IRequest<int>
        {
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

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly ITeamRepository _teamRepository;
            private readonly IClock _clock;

            public Handler(ITeamRepository teamRepository, IClock clock)
            {
                _teamRepository = teamRepository;
                _clock = clock;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var team = new Team
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                };

                return await _teamRepository.Create(team);
            }
        }
    }

    public class CreateTeamEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/teams", async (
                CreateTeamRequest createTeamRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new CreateTeam.Command()
                    {
                        Name = createTeamRequest.Name,
                    };

                    int teamId = await mediator.Send(command, cancellationToken);
                    return Results.CreatedAtRoute("GetTeam", new { id = teamId });
                })
                .WithTags("Teams");
        }
    }
}
