using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Helpers;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Federations.Commands;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Commands;

public static class DeleteFederationFeature
{
    public static void Endpoint(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/api/federations/{id:int}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new DeleteFederation.Command() { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
            .WithTags(Tags.Federations)
            .RequireAuthorization(Policy.Admin);
    }

    public class Handler(
        IFederationRepository federationRepository,
        IImageService imageService)
        : IRequestHandler<DeleteFederation.Command, Unit>
    {
        public async Task<Unit> Handle(
            DeleteFederation.Command command,
            CancellationToken cancellationToken)
        {
            var federation = await federationRepository.Get(command.Id) ?? throw new MyNotFoundException();

            imageService.DeleteEntityImage(federation.Image);

            await federationRepository.Delete(federation);
            return Unit.Value;
        }
    }
}