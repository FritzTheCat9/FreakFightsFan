using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fighters.Extensions;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Queries;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Queries
{
    public static class GetFighterFeature
    {
        public static void Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/fighters/{id:int}", async (
                    int id,
                    IMediator mediator,
                    CancellationToken cancellationToken) =>
                {
                    var query = new GetFighter.Query() { Id = id };
                    return Results.Ok(await mediator.Send(query, cancellationToken));
                })
                .WithName("GetFighter")
                .WithTags(Tags.Fighters)
                .AllowAnonymous();
        }

        public class Handler : IRequestHandler<GetFighter.Query, FighterDto>
        {
            private readonly IFighterRepository _fighterRepository;

            public Handler(IFighterRepository fighterRepository)
            {
                _fighterRepository = fighterRepository;
            }

            public async Task<FighterDto> Handle(
                GetFighter.Query query,
                CancellationToken cancellationToken)
            {
                var fighter = await _fighterRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return fighter.ToDto();
            }
        }
    }
}