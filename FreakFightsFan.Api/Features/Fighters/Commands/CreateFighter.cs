using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Features.Fighters.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Commands
{
    public static class CreateFighter
    {
        public class Command : IRequest<int>
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Nickname { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.FirstName)
                    .NotEmpty();

                RuleFor(x => x.LastName)
                    .NotEmpty();

                RuleFor(x => x.Nickname)
                    .NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IFighterRepository _fighterRepository;
            private readonly IClock _clock;

            public Handler(IFighterRepository fighterRepository, IClock clock)
            {
                _fighterRepository = fighterRepository;
                _clock = clock;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var fighter = new Fighter
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    FirstName = command.FirstName,
                    LastName = command.LastName,
                    Nickname = command.Nickname,
                };

                return await _fighterRepository.Create(fighter);
            }
        }
    }

    public class CreateFighterEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fighters", async (
                CreateFighterRequest createFighterRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new CreateFighter.Command()
                    {
                        FirstName = createFighterRequest.FirstName,
                        LastName = createFighterRequest.LastName,
                        Nickname = createFighterRequest.Nickname,
                    };

                    int fighterId = await mediator.Send(command, cancellationToken);
                    return Results.CreatedAtRoute("GetFighter", new { id = fighterId });
                });
        }
    }
}
