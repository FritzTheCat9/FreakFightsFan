using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Queries;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Queries
{
    public static class GetFightFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/fights/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetFight.Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetFight")
                .WithTags("Fights")
                .AllowAnonymous();

            return app;
        }

        public class Handler : IRequestHandler<GetFight.Query, FightDto>
        {
            private readonly IFightRepository _fightRepository;

            public Handler(IFightRepository fightRepository)
            {
                _fightRepository = fightRepository;
            }

            public async Task<FightDto> Handle(
                GetFight.Query query,
                CancellationToken cancellationToken)
            {
                var fight = await _fightRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return fight.ToDto();
            }
        }
    }
}
