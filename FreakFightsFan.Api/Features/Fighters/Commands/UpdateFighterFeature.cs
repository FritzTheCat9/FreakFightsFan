using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Commands;

public static class UpdateFighterFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPut("/api/fighters/{id:int}", async (
                int id,
                UpdateFighter.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Fighters)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IFighterRepository fighterRepository,
        IClock clock,
        IImageService imageService)
        : IRequestHandler<UpdateFighter.Command, Unit>
    {
        public async Task<Unit> Handle(
            UpdateFighter.Command command,
            CancellationToken cancellationToken)
        {
            var fighter = await fighterRepository.Get(command.Id) ?? throw new MyNotFoundException();
            fighter.FirstName = command.FirstName;
            fighter.LastName = command.LastName;
            fighter.Nickname = command.Nickname;
            fighter.InstagramUrl = command.InstagramUrl;
            fighter.Modified = clock.Current();
            fighter.Image = imageService.UpdateEntityImage(fighter.Image, command.ImageBase64);

            await fighterRepository.Update(fighter);
            return Unit.Value;
        }
    }
}