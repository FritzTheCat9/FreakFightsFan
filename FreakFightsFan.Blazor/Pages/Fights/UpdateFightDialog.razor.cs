using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Teams.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Fights;

public partial class UpdateFightDialog : ComponentBase
{
    private readonly List<int> _allowedTeamSizes = [2, 3, 4, 5];
    private CustomValidator _customValidator;
    private int _selectedTeam;
    private List<CreateFight.TeamHelperModel> _teams = [];

    [CascadingParameter] public MudDialogInstance MudDialog { get; set; }

    [Parameter] public UpdateFight.Command Command { get; set; } = new();
    [Parameter] public List<TeamDto> Teams { get; set; } = [];
    [Parameter] public int NumberOfTeams { get; set; }
    [Parameter] public MyDictionaryItemDto FightType { get; set; }

    [Inject] public IExceptionHandler ExceptionHandler { get; set; }
    [Inject] public IFightApiClient FightApiClient { get; set; }
    [Inject] public IFighterApiClient FighterApiClient { get; set; }

    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    protected override void OnInitialized()
    {
        SetUpUpdate();
    }

    private void SetUpUpdate()
    {
        _teams = [];

        foreach (var team in Teams)
        {
            var fighters = new List<CreateFight.FighterHelperModel>();
            foreach (var teamFighters in team.FighterInTeams)
            {
                fighters.Add(new CreateFight.FighterHelperModel
                {
                    Fighter = teamFighters.Fighter, FightResult = teamFighters.FightResult
                });
            }

            var teamHelperModel = new CreateFight.TeamHelperModel { Number = team.Number, Fighters = fighters };

            _teams.Add(teamHelperModel);
        }
    }

    private void OnTeamsCountSelect(int teamsCount)
    {
        ResetTeams(teamsCount);
    }

    private void ResetTeams(int teamsCount)
    {
        _teams = [];

        for (var i = 0; i < teamsCount; i++)
        {
            _teams.Add(new CreateFight.TeamHelperModel { Number = i, Fighters = [] });
        }

        _selectedTeam = 0;
    }

    private async Task HandleValidSubmit()
    {
        try
        {
            await FightApiClient.UpdateFight(Command);
            MudDialog.Close(DialogResult.Ok(true));
        }
        catch (MyValidationException validationException)
        {
            _customValidator.DisplayErrors(validationException.Errors);
        }
        catch (Exception ex)
        {
            ExceptionHandler.HandleExceptions(ex);
        }
    }
}