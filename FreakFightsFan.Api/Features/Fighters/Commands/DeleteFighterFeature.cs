using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Commands;

public static class DeleteFighterFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/api/fighters/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DeleteFighter.Command { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Fighters)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IFighterRepository fighterRepository,
        IImageService imageService)
        : IRequestHandler<DeleteFighter.Command, Unit>
    {
        public async Task<Unit> Handle(
            DeleteFighter.Command command,
            CancellationToken cancellationToken)
        {
            var fighter = await fighterRepository.Get(command.Id) ?? throw new MyNotFoundException();

            imageService.DeleteEntityImage(fighter.Image);

            await fighterRepository.Delete(fighter);
            return Unit.Value;
        }
    }
}