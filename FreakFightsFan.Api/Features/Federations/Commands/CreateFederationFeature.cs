using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Features.Federations.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Commands
{
    public static class CreateFederationFeature
    {
        public static void Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/federations", async (
                    CreateFederation.Command command,
                    IMediator mediator,
                    CancellationToken cancellationToken) =>
                {
                    int federationId = await mediator.Send(command, cancellationToken);
                    return Results.CreatedAtRoute("GetFederation", new { id = federationId });
                })
                .WithTags(Tags.Federations)
                .RequireAuthorization(Policy.Admin);
        }

        public class Handler : IRequestHandler<CreateFederation.Command, int>
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

            public async Task<int> Handle(
                CreateFederation.Command command,
                CancellationToken cancellationToken)
            {
                var federation = new Federation
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                    Image = _imageService.CreateEntityImage(command.ImageBase64),
                };

                return await _federationRepository.Create(federation);
            }
        }
    }
}