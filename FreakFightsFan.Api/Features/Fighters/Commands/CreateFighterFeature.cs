using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Commands;

public static class CreateFighterFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPost("/api/fighters", async (
                CreateFighter.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var fighterId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetFighter", new { id = fighterId });
            })
            .WithTags(Tags.Fighters)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IFighterRepository fighterRepository,
        IClock clock,
        IImageService imageService)
        : IRequestHandler<CreateFighter.Command, int>
    {
        public async Task<int> Handle(
            CreateFighter.Command command,
            CancellationToken cancellationToken)
        {
            var fighter = new Fighter
            {
                Id = 0,
                Created = clock.Current(),
                Modified = clock.Current(),
                FirstName = command.FirstName,
                LastName = command.LastName,
                Nickname = command.Nickname,
                InstagramUrl = command.InstagramUrl,
                Image = imageService.CreateEntityImage(command.ImageBase64)
            };

            return await fighterRepository.Create(fighter);
        }
    }
}