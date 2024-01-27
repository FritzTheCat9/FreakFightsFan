using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Commands
{
    public static class UpdateFighterFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/fighters/{id}", async (
                int id,
                UpdateFighter.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Fighters")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<UpdateFighter.Command, Unit>
        {
            private readonly IFighterRepository _fighterRepository;
            private readonly IClock _clock;
            private readonly IImageService _imageService;

            public Handler(
                IFighterRepository fighterRepository,
                IClock clock,
                IImageService imageService)
            {
                _fighterRepository = fighterRepository;
                _clock = clock;
                _imageService = imageService;
            }

            public async Task<Unit> Handle(
                UpdateFighter.Command command,
                CancellationToken cancellationToken)
            {
                var fighter = await _fighterRepository.Get(command.Id) ?? throw new MyNotFoundException();
                fighter.FirstName = command.FirstName;
                fighter.LastName = command.LastName;
                fighter.Nickname = command.Nickname;
                fighter.InstagramUrl = command.InstagramUrl;
                fighter.Modified = _clock.Current();
                fighter.Image = _imageService.UpdateEntityImage(fighter.Image, command.ImageBase64);

                await _fighterRepository.Update(fighter);
                return Unit.Value;
            }
        }
    }
}