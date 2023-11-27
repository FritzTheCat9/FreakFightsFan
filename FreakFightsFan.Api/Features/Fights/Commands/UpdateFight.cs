using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Fights.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Commands
{
    public static class UpdateFight
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
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

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IFightRepository _fightRepository;
            private readonly IClock _clock;

            public Handler(IFightRepository fightRepository, IClock clock)
            {
                _fightRepository = fightRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var fight = await _fightRepository.Get(command.Id) ?? throw new MyNotFoundException();
                fight.Modified = _clock.Current();
                fight.Name = command.Name;

                await _fightRepository.Update(fight);
                return Unit.Value;
            }
        }
    }

    public class UpdateFightEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/api/fights/{id}", async (
                int id,
                UpdateFightRequest updateFightRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
                {
                    var command = new UpdateFight.Command()
                    {
                        Id = id,
                        Name = updateFightRequest.Name,
                    };

                    return Results.Ok(await mediator.Send(command, cancellationToken));
                })
                .WithTags("Fights");
        }
    }
}
