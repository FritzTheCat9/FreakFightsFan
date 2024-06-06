using FreakFightsFan.Shared.Features.Fighters.Responses;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;
using System.Linq.Expressions;
using static FreakFightsFan.Shared.Features.Fights.Commands.CreateFight;

namespace FreakFightsFan.Blazor.Components
{
    public partial class FritzTeamMaker : MudTextField<List<CreateTeamModel>>
    {
        private FritzFighterPicker _addFighterField;
        private FighterDto _fighter;

        [Parameter] public List<CreateTeamModel> Teams { get; set; }
        [Parameter] public List<TeamHelperModel> TeamHelperModel { get; set; } = [];
        [Parameter] public int SelectedTeam { get; set; }
        [Parameter] public EventCallback<List<CreateTeamModel>> OnTeamsChanged { get; set; }
        [Parameter] public Expression<Func<List<CreateTeamModel>>> ForTeams { get; set; }
        [Parameter] public Expression<Func<int>> ForEventId { get; set; }
        [Parameter] public int NumberOfTeams { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        protected override async Task OnInitializedAsync()
        {
            await UpdateTeams();
        }

        private async Task OnValueChanged(List<CreateTeamModel> teams)
        {
            await SetValueAsync(teams);
            await OnTeamsChanged.InvokeAsync(teams);
        }

        private void SelectTeam(int number)
            => SelectedTeam = number;

        private async Task DeleteFighterListItem(CreateFight.TeamHelperModel team, CreateFight.FighterHelperModel fighter)
        {
            var pickedTeam = TeamHelperModel.FirstOrDefault(x => x.Number == team.Number);
            if (pickedTeam is not null)
            {
                var fighterToRemove = pickedTeam.Fighters.FirstOrDefault(x => x.Fighter.Id == fighter.Fighter.Id);
                if (fighterToRemove is not null)
                {
                    pickedTeam.Fighters.Remove(fighterToRemove);
                }
            }

            await UpdateTeams();
        }

        private async Task AddFighterToSelectedTeam()
        {
            if (_fighter != null)
            {
                TeamHelperModel[SelectedTeam].Fighters.Add(new()
                {
                    Fighter = _fighter,
                    FightResult = FightResult.UPCOMING
                });
                _fighter = null;
                SelectedTeam = (SelectedTeam + 1) % NumberOfTeams;
                await _addFighterField.Focus();
            }

            await UpdateTeams();
        }

        private async Task UpdateTeams()
        {
            Teams = [];

            foreach (var team in TeamHelperModel)
            {
                var teamFighters = new List<TeamFighterModel>();
                foreach (var fighter in team.Fighters)
                {
                    var teamFighterModel = new TeamFighterModel()
                    {
                        FighterId = fighter.Fighter.Id,
                        FightResult = fighter.FightResult,
                    };

                    teamFighters.Add(teamFighterModel);
                }

                Teams.Add(new() { Fighters = teamFighters });
            }

            await OnValueChanged(Teams);
        }
    }
}