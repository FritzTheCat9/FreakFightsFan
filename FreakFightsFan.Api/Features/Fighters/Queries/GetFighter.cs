using FluentValidation;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fighters.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Queries
{
    public static class GetFighter
    {
        public class Query : IRequest<FighterDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }

        public class Handler : IRequestHandler<Query, FighterDto>
        {
            private readonly IFighterRepository _fighterRepository;

            public Handler(IFighterRepository fighterRepository)
            {
                _fighterRepository = fighterRepository;
            }

            public async Task<FighterDto> Handle(Query query, CancellationToken cancellationToken)
            {
                var fighter = await _fighterRepository.Get(query.Id) ?? throw new MyNotFoundException();
                return fighter.ToDto();
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet("/api/fighters/{id}", async (
                int id,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var query = new Query() { Id = id };
                return Results.Ok(await mediator.Send(query, cancellationToken));
            })
                .WithName("GetFighter")
                .WithTags("Fighters");

            return app;
        }
    }
}
