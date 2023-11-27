using Carter;
using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Teams.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Teams.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Teams.Queries
{
    public static class GetTeam
    {
        public class Query : IRequest<TeamDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, TeamDto>
        {
            private readonly ITeamRepository _teamRepository;

            public Handler(ITeamRepository teamRepository)
            {
                _teamRepository = teamRepository;
            }

            public async Task<TeamDto> Handle(Query query, CancellationToken cancellationToken)
            {
                var team = await _teamRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return team.ToDto();
            }
        }
    }

    public class GetTeamEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/teams/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var query = new GetTeam.Query() { Id = id };
                    return Results.Ok(await mediator.Send(query, cancellationToken));
                })
                .WithName("GetTeam")
                .WithTags("Teams");
        }
    }
}
