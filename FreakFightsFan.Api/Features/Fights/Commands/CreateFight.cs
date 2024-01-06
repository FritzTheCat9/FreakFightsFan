using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Fights.Extensions;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Features.Fights.Requests;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Commands
{
    public static class CreateFight
    {
        public class Command : IRequest<int>
        {
            public int EventId { get; set; }
            public List<CreateTeamModel> Teams { get; set; }
            public string VideoUrl { get; set; }
            public int? TypeId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                When(x => !string.IsNullOrEmpty(x.VideoUrl), () =>
                {
                    RuleFor(x => x.VideoUrl)
                        .NotEmpty()
                        .Matches("^(?:https?:\\/\\/)?(?:www\\.)?(?:youtube\\.com\\/(?:[^\\/\\n\\s]+\\/\\S+\\/|(?:v|e(?:mbed)?)\\/|\\S*?[?&]v=)|youtu\\.be\\/)([a-zA-Z0-9_-]{11})")
                        .WithMessage("This is not a valid link to the YouTube video");
                });
            }
        }

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IFightRepository _fightRepository;
            private readonly IClock _clock;
            private readonly IEventRepository _eventRepository;
            private readonly ITeamService _teamService;
            private readonly IMyDictionaryService _dictionaryService;
            private readonly IMyDictionaryItemRepository _dictionaryItemRepository;

            public Handler(IFightRepository fightRepository, IClock clock, IEventRepository eventRepository, ITeamService teamService, 
                IMyDictionaryService dictionaryService, IMyDictionaryItemRepository dictionaryItemRepository)
            {
                _fightRepository = fightRepository;
                _clock = clock;
                _eventRepository = eventRepository;
                _teamService = teamService;
                _dictionaryService = dictionaryService;
                _dictionaryItemRepository = dictionaryItemRepository;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                await ValidateCommand(command);

                var myEvent = await _eventRepository.Get(command.EventId) ?? throw new MyNotFoundException();
                var teamsInFight = await _teamService.CreateFightTeams(command.Teams);

                var fight = new Fight
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    EventId = command.EventId,
                    OrderNumber = myEvent.Fights.Count + 1,
                    VideoUrl = command.VideoUrl,
                    Type = (command.TypeId is not null) ? await _dictionaryItemRepository.Get(command.TypeId.Value) : null,
                };

                fight.Teams.AddRange(teamsInFight);

                return await _fightRepository.Create(fight);
            }

            private async Task ValidateCommand(Command command)
            {
                var myEvent = await _eventRepository.Get(command.EventId) ?? throw new MyNotFoundException();

                if (myEvent.Fights.Count >= FightsOptions.MaxFightsInOneEvent)
                    throw new MyValidationException("EventId", $"You cannot add more than {FightsOptions.MaxFightsInOneEvent} fights in one event");

                if (command.Teams.Count < FightsOptions.MinTeamsNumber)
                    throw new MyValidationException("Teams", $"At least {FightsOptions.MinTeamsNumber} teams should be added for each fight");

                if (command.Teams.Count > FightsOptions.MaxTeamsNumber)
                    throw new MyValidationException("Teams", $"Each fight can contain only {FightsOptions.MaxTeamsNumber} teams");

                var allFightersIds = new List<int>();
                foreach (var createTeamModel in command.Teams)
                {
                    if (createTeamModel.Fighters.Count < FightsOptions.MinTeamFighters)
                        throw new MyValidationException("Teams", $"At least {FightsOptions.MinTeamFighters} fighter should be added for each team");

                    if (createTeamModel.Fighters.Count > FightsOptions.MaxTeamFighters)
                        throw new MyValidationException("Teams", $"Each team can contain only {FightsOptions.MaxTeamFighters} fighters");

                    foreach (var fighter in createTeamModel.Fighters)
                    {
                        if (!allFightersIds.Contains(fighter.FighterId))
                            allFightersIds.Add(fighter.FighterId);
                        else
                            throw new MyValidationException("Teams", $"Each fighter can only be selected to the team once");
                    }
                }

                if (command.TypeId is not null)
                {
                    var isTypeValid = await _dictionaryService.ItemIsFromDictionary(command.TypeId.Value, DictionaryCode.FightType);
                    if (!isTypeValid)
                        throw new MyValidationException("TypeId", $"Dictionary item should be chosen from dictionary with code: {DictionaryCode.FightType}");
                }
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fights", async (
                CreateFightRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int fightId = await mediator.Send(request.ToCreateFightCommand(), cancellationToken);
                return Results.CreatedAtRoute("GetFight", new { id = fightId });
            })
                .WithTags("Fights")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
