using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Federations.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Commands
{
    public static class UpdateFederationFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/federations/{id}", async (
                int id,
                UpdateFederation.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                command.Id = id;
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags(Tags.Federations)
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<UpdateFederation.Command, Unit>
        {
            private readonly IFederationRepository _federationRepository;
            private readonly IClock _clock;
            private readonly IImageService _imageService;

            public Handler(
                IFederationRepository federationRepository,
                IClock clock,
                IImageService imageService)
            {
                _federationRepository = federationRepository;
                _clock = clock;
                _imageService = imageService;
            }

            public async Task<Unit> Handle(
                UpdateFederation.Command command,
                CancellationToken cancellationToken)
            {
                var federation = await _federationRepository.Get(command.Id) ?? throw new MyNotFoundException();

                federation.Modified = _clock.Current();
                federation.Name = command.Name;
                federation.Image = _imageService.UpdateEntityImage(federation.Image, command.ImageBase64);

                await _federationRepository.Update(federation);
                return Unit.Value;
            }
        }
    }
}
