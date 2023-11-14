using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fighters.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Fighters.Commands
{
    public static class UpdateFighter
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
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

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IFighterRepository _fighterRepository;
            private readonly IClock _clock;

            public Handler(IFighterRepository fighterRepository, IClock clock)
            {
                _fighterRepository = fighterRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var fighter = await _fighterRepository.Get(command.Id) ?? throw new MyNotFoundException();
                fighter.FirstName = command.FirstName;
                fighter.LastName = command.LastName;
                fighter.Nickname = command.Nickname;
                fighter.Modified = _clock.Current();

                await _fighterRepository.Update(fighter);
                return Unit.Value;
            }
        }
    }

    public class UpdateFighterEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/api/fighters/{id}", async (
                int id,
                UpdateFighterRequest updateFighterRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new UpdateFighter.Command()
                    {
                        Id = id,
                        FirstName = updateFighterRequest.FirstName,
                        LastName = updateFighterRequest.LastName,
                        Nickname = updateFighterRequest.Nickname,
                    };

                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Fighters");
        }
    }
}