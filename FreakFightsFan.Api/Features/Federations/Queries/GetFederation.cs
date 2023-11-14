using Carter;
using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Federations.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Federations.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Federations.Queries
{
    public static class GetFederation
    {
        public class Query : IRequest<FederationDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, FederationDto>
        {
            private readonly IFederationRepository _federationRepository;

            public Handler(IFederationRepository federationRepository)
            {
                _federationRepository = federationRepository;
            }

            public async Task<FederationDto> Handle(Query query, CancellationToken cancellationToken)
            {
                var federation = await _federationRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return federation.ToDto();
            }
        }
    }

    public class GetFederationEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapGet("/api/federations/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var query = new GetFederation.Query() { Id = id };
                    return Results.Ok(await mediator.Send(query, cancellationToken));
                })
                .WithName("GetFederation")
                .WithTags("Federations");
        }
    }
}
