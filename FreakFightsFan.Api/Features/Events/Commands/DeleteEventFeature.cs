using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Events.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Events.Commands;

public static class DeleteEventFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/api/events/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DeleteEvent.Command() { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Events)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(IEventRepository eventRepository) : IRequestHandler<DeleteEvent.Command, Unit>
    {
        public async Task<Unit> Handle(
            DeleteEvent.Command command,
            CancellationToken cancellationToken)
        {
            var myEvent = await eventRepository.Get(command.Id) ?? throw new MyNotFoundException();
            await eventRepository.Delete(myEvent);
            return Unit.Value;
        }
    }
}