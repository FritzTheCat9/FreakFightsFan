using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fighters.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Queries;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Queries;

public static class GetFighterFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapGet("/api/fighters/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new GetFighter.Query { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
            .WithName("GetFighter")
            .WithTags(Tags.Fighters)
            .AllowAnonymous();
    }

    public class Handler(IFighterRepository fighterRepository) : IRequestHandler<GetFighter.Query, FighterDto>
    {
        public async Task<FighterDto> Handle(
            GetFighter.Query query,
            CancellationToken cancellationToken)
        {
            var fighter = await fighterRepository.Get(query.Id) ?? throw new MyNotFoundException();
            return fighter.ToDto();
        }
    }
}