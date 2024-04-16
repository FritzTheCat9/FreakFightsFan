using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Localization;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;
using Microsoft.Extensions.Localization;

namespace FreakFightsFan.Api.Features.Fights.Commands
{
    public static class MoveFightFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/fights/move/{id}", async (
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

            return app;
        }

        public class Handler : IRequestHandler<MoveFight.Command, Unit>
        {
            private readonly IFightRepository _fightRepository;
            private readonly IStringLocalizer<ApiValidationMessage> _localizer;

            public Handler(
                IFightRepository fightRepository,
                IStringLocalizer<ApiValidationMessage> localizer)
            {
                _fightRepository = fightRepository;
                _localizer = localizer;
            }

            public async Task<Unit> Handle(MoveFight.Command command, CancellationToken cancellationToken)
            {
                var fight = await _fightRepository.Get(command.Id) ?? throw new MyNotFoundException();
                var eventFights = _fightRepository.AsQueryable(fight.EventId);
                var orderNumberToMove = fight.OrderNumber;

                if (fight.OrderNumber >= eventFights.Count()
                    && command.Direction == MoveDirection.Upwards)
                {
                    throw new MyValidationException(nameof(MoveFight.Command.Direction),
                        _localizer[nameof(ApiValidationMessageString.DirectionFightIsOnTheTop)]);
                }
                else if (fight.OrderNumber <= 1
                    && command.Direction == MoveDirection.Downwards)
                {
                    throw new MyValidationException(nameof(MoveFight.Command.Direction),
                        _localizer[nameof(ApiValidationMessageString.DirectionFightIsOnTheBottom)]);
                }
                else if (fight.OrderNumber < eventFights.Count()
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

                await _fightRepository.Update(fight);
                await _fightRepository.Update(fightToMove);

                return Unit.Value;
            }
        }
    }
}
