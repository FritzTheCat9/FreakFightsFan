using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Features.Fights.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Commands
{
    public static class CreateFight
    {
        public class Command : IRequest<int>
        {
            public string Name { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IFightRepository _fightRepository;
            private readonly IClock _clock;

            public Handler(IFightRepository fightRepository, IClock clock)
            {
                _fightRepository = fightRepository;
                _clock = clock;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var fight = new Fight
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                };

                return await _fightRepository.Create(fight);
            }
        }
    }

    public class CreateFightEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fights", async (
                CreateFightRequest createFightRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new CreateFight.Command()
                    {
                        Name = createFightRequest.Name,
                    };

                    int fightId = await mediator.Send(command, cancellationToken);
                    return Results.CreatedAtRoute("GetFight", new { id = fightId });
                })
                .WithTags("Fights");
        }
    }
}
