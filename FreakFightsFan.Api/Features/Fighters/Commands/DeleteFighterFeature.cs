using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Commands
{
    public static class DeleteFighterFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/fighters/{id}", async (
               int id,
               IMediator mediator,
               CancellationToken cancellationToken) =>
            {
                var command = new DeleteFighter.Command() { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
               .WithTags("Fighters")
               .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<DeleteFighter.Command, Unit>
        {
            private readonly IFighterRepository _fighterRepository;
            private readonly IImageService _imageService;

            public Handler(IFighterRepository fighterRepository, IImageService imageService)
            {
                _fighterRepository = fighterRepository;
                _imageService = imageService;
            }

            public async Task<Unit> Handle(DeleteFighter.Command command, CancellationToken cancellationToken)
            {
                var fighter = await _fighterRepository.Get(command.Id) ?? throw new MyNotFoundException();

                _imageService.DeleteEntityImage(fighter.Image);

                await _fighterRepository.Delete(fighter);
                return Unit.Value;
            }
        }
    }
}
