using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Commands
{
    public static class CreateFighterFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fighters", async (
                CreateFighter.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int fighterId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetFighter", new { id = fighterId });
            })
                .WithTags("Fighters")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<CreateFighter.Command, int>
        {
            private readonly IFighterRepository _fighterRepository;
            private readonly IClock _clock;
            private readonly IImageService _imageService;

            public Handler(IFighterRepository fighterRepository, IClock clock, IImageService imageService)
            {
                _fighterRepository = fighterRepository;
                _clock = clock;
                _imageService = imageService;
            }

            public async Task<int> Handle(CreateFighter.Command command, CancellationToken cancellationToken)
            {
                var fighter = new Fighter
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    Nickname = command.Nickname,
                    InstagramUrl = command.InstagramUrl,
                    Image = _imageService.CreateEntityImage(command.ImageBase64),
                };

                return await _fighterRepository.Create(fighter);
            }
        }
    }
}
