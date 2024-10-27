using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Federations.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Commands;

public static class UpdateFederationFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapPut("/api/federations/{id:int}", async (
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
    }

    public class Handler(
        IFederationRepository federationRepository,
        IClock clock,
        IImageService imageService)
        : IRequestHandler<UpdateFederation.Command, Unit>
    {
        public async Task<Unit> Handle(
            UpdateFederation.Command command,
            CancellationToken cancellationToken)
        {
            var federation = await federationRepository.Get(command.Id) ?? throw new MyNotFoundException();

            federation.Modified = clock.Current();
            federation.Name = command.Name;
            federation.Image = imageService.UpdateEntityImage(federation.Image, command.ImageBase64);

            await federationRepository.Update(federation);
            return Unit.Value;
        }
    }
}