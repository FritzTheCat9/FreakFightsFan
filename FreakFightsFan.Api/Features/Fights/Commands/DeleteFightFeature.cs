using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Commands
{
    public static class DeleteFightFeature
    {
        public static void Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/fights/{id:int}", async (
                    int id,
                    IMediator mediator,
                    CancellationToken cancellationToken) =>
                {
                    var command = new DeleteFight.Command() { Id = id };
                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags(Tags.Fights)
                .RequireAuthorization(Policy.Admin);
        }

        public class Handler : IRequestHandler<DeleteFight.Command, Unit>
        {
            private readonly IFightRepository _fightRepository;

            public Handler(IFightRepository fightRepository)
            {
                _fightRepository = fightRepository;
            }

            public async Task<Unit> Handle(
                DeleteFight.Command command,
                CancellationToken cancellationToken)
            {
                var fight = await _fightRepository.Get(command.Id) ?? throw new MyNotFoundException();

                await _fightRepository.OrderFights(fight.EventId, fight.OrderNumber);
                await _fightRepository.Delete(fight);

                return Unit.Value;
            }
        }
    }
}