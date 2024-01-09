using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Services;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Helpers;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Fights.Commands
{
    public static class CreateFightFeature
    {
        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/fights", async (
                CreateFight.Command command,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int fightId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetFight", new { id = fightId });
            })
                .WithTags("Fights")
                .RequireAuthorization(Policy.Admin);

            return app;
        }

        public class Handler : IRequestHandler<CreateFight.Command, int>
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

            public async Task<int> Handle(CreateFight.Command command, CancellationToken cancellationToken)
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

            private async Task ValidateCommand(CreateFight.Command command)
            {
                var myEvent = await _eventRepository.Get(command.EventId) ?? throw new MyNotFoundException();

                if (myEvent.Fights.Count >= FightsConsts.MaxFightsInOneEvent)
                    throw new MyValidationException("EventId", $"You cannot add more than {FightsConsts.MaxFightsInOneEvent} fights in one event");

                if (command.Teams.Count < FightsConsts.MinTeamsNumber)
                    throw new MyValidationException("Teams", $"At least {FightsConsts.MinTeamsNumber} teams should be added for each fight");

                if (command.Teams.Count > FightsConsts.MaxTeamsNumber)
                    throw new MyValidationException("Teams", $"Each fight can contain only {FightsConsts.MaxTeamsNumber} teams");

                var allFightersIds = new List<int>();
                foreach (var createTeamModel in command.Teams)
                {
                    if (createTeamModel.Fighters.Count < FightsConsts.MinTeamFighters)
                        throw new MyValidationException("Teams", $"At least {FightsConsts.MinTeamFighters} fighter should be added for each team");

                    if (createTeamModel.Fighters.Count > FightsConsts.MaxTeamFighters)
                        throw new MyValidationException("Teams", $"Each team can contain only {FightsConsts.MaxTeamFighters} fighters");

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
    }
}
