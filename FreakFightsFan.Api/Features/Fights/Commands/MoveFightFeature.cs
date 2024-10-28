using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Fights.Commands;

public static class MoveFightFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPut("/api/fights/move/{id:int}", async (
                int id,
                MoveFight.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Fights)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IFightRepository fightRepository,
        IStringLocalizer<ApiValidationMessage> localizer)
        : IRequestHandler<MoveFight.Command, Unit>
    {
        public async Task<Unit> Handle(MoveFight.Command command, CancellationToken cancellationToken)
        {
            var fight = await fightRepository.Get(command.Id) ?? throw new MyNotFoundException();
            var eventFights = fightRepository.AsQueryable(fight.EventId);
            var orderNumberToMove = fight.OrderNumber;

            if (fight.OrderNumber >= eventFights.Count()
                && command.Direction == MoveDirection.Upwards)
            {
                throw new MyValidationException(nameof(MoveFight.Command.Direction),
                    localizer[nameof(ApiValidationMessageString.DirectionFightIsOnTheTop)]);
            }

            if (fight.OrderNumber <= 1
                && command.Direction == MoveDirection.Downwards)
            {
                throw new MyValidationException(nameof(MoveFight.Command.Direction),
                    localizer[nameof(ApiValidationMessageString.DirectionFightIsOnTheBottom)]);
            }

            if (fight.OrderNumber < eventFights.Count()
                && command.Direction == MoveDirection.Upwards)
            {
                orderNumberToMove += 1;
            }
            else if (fight.OrderNumber > 1
                     && command.Direction == MoveDirection.Downwards)
            {
                orderNumberToMove -= 1;
            }

            var fightToMove = eventFights.FirstOrDefault(x => x.OrderNumber == orderNumberToMove);

            fightToMove.OrderNumber = fight.OrderNumber;
            fight.OrderNumber = orderNumberToMove;

            await fightRepository.Update(fight);
            await fightRepository.Update(fightToMove);

            return Unit.Value;
        }
    }
}