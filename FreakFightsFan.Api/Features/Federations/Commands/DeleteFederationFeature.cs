using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Federations.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Commands
{
    public static class DeleteFederationFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/federations/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DeleteFederation.Command() { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Federations")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<DeleteFederation.Command, Unit>
        {
            private readonly IFederationRepository _federationRepository;
            private readonly IImageService _imageService;

            public Handler(
                IFederationRepository federationRepository,
                IImageService imageService)
            {
                _federationRepository = federationRepository;
                _imageService = imageService;
            }

            public async Task<Unit> Handle(
                DeleteFederation.Command command,
                CancellationToken cancellationToken)
            {
                var federation = await _federationRepository.Get(command.Id) ?? throw new MyNotFoundException();

                _imageService.DeleteEntityImage(federation.Image);

                await _federationRepository.Delete(federation);
                return Unit.Value;
            }
        }
    }
}
