using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Commands
{
    public static class DeleteFederation
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {

        }

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IFederationRepository _federationRepository;
            private readonly IImageService _imageService;

            public Handler(IFederationRepository federationRepository, IImageService imageService)
            {
                _federationRepository = federationRepository;
                _imageService = imageService;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var federation = await _federationRepository.Get(command.Id) ?? throw new MyNotFoundException();

                _imageService.DeleteEntityImage(federation.Image);

                await _federationRepository.Delete(federation);
                return Unit.Value;
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapDelete("/api/federations/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new Command() { Id = id };
                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("Federations")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
