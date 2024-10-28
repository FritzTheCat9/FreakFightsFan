using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Queries;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Queries;

public static class GetFightFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/fights/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetFight.Query { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithName("GetFight")
            .WithTags(Tags.Fights)
            .AllowAnonymous();
    }

    public class Handler(IFightRepository fightRepository) : IRequestHandler<GetFight.Query, FightDto>
    {
        public async Task<FightDto> Handle(
            GetFight.Query query,
            CancellationToken cancellationToken)
        {
            var fight = await fightRepository.Get(query.Id) ?? throw new MyNotFoundException();
            return fight.ToDto();
        }
    }
}