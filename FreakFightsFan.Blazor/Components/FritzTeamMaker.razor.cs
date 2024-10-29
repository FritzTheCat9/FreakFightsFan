using FreakFightsFan.Shared.Features.Fighters.Responses;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using System.Linq.Expressions;
using static FreakFightsFan.Shared.Features.Fights.Commands.CreateFight;

namespace FreakFightsFan.Blazor.Components;

public partial class FritzTeamMaker : FritzFormInputBase<List<CreateTeamModel>>
{
    private FritzFighterPicker _addFighterField;
    private FighterDto _fighter;

    [Parameter] public List<CreateTeamModel> Teams { get; set; }
    [Parameter] public EventCallback<List<CreateTeamModel>> TeamsChanged { get; set; }
    [Parameter] public List<TeamHelperModel> TeamHelperModel { get; set; } = [];
    [Parameter] public int SelectedTeam { get; set; }
    [Parameter] public int NumberOfTeams { get; set; }
    [Parameter] public Expression<Func<int>> ForEventId { get; set; }

    [Parameter] public bool OnlyValidateIfDirty { get; set; } = true;

    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await UpdateTeams();
    }

    private async Task OnValueChanged(List<CreateTeamModel> teams)
    {
        Teams = teams;
        await TeamsChanged.InvokeAsync(teams);
        ValidateField();
    }

    private void SelectTeam(int number)
    {
        SelectedTeam = number;
    }

    private async Task DeleteFighterListItem(TeamHelperModel team, FighterHelperModel fighter)
    {
        var pickedTeam = TeamHelperModel.FirstOrDefault(x => x.Number == team.Number);
        
        var fighterToRemove =
            pickedTeam?.Fighters.FirstOrDefault(x => x.Fighter.Id == fighter.Fighter.Id);
        
        if (fighterToRemove is not null)
        {
            pickedTeam.Fighters.Remove(fighterToRemove);
        }

        await UpdateTeams();
    }

    private async Task AddFighterToSelectedTeam()
    {
        if (_fighter != null)
        {
            TeamHelperModel[SelectedTeam].Fighters.Add(new FighterHelperModel
            {
                Fighter = _fighter, FightResult = FightResult.Upcoming
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

        foreach (var teamFighters in TeamHelperModel
                     .Select(team => team.Fighters
                         .Select(fighter
                             => new TeamFighterModel
                             {
                                 FighterId = fighter.Fighter.Id, FightResult = fighter.FightResult
                             })
                         .ToList()))
        {
            Teams.Add(new CreateTeamModel { Fighters = teamFighters });
        }

        await OnValueChanged(Teams);
    }
}