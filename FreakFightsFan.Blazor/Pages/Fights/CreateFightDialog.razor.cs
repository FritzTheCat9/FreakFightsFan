using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Pages.Error;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Fights.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Fights
{
    public partial class CreateFightDialog : ComponentBase
    {
        private CustomValidator _customValidator;

        private readonly List<int> _allowedTeamSizes = [2, 3, 4, 5];
        private int _selectedTeam;

        private List<CreateFight.TeamHelperModel> _teams = [];
        private MyDictionaryItemDto FightType { get; set; }

        [CascadingParameter] public MudDialogInstance MudDialog { get; set; }

        [Parameter] public CreateFight.Command Command { get; set; } = new();
        [Parameter] public int NumberOfTeams { get; set; }

        [Inject] public IExceptionHandler ExceptionHandler { get; set; }
        [Inject] public IFightApiClient FightApiClient { get; set; }
        [Inject] public IFighterApiClient FighterApiClient { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        protected override void OnInitialized()
        {
            ResetTeams(NumberOfTeams);
        }

        private void OnTeamsCountSelect(int teamsCount) 
            => ResetTeams(teamsCount);

        private void ResetTeams(int teamsCount)
        {
            _teams = [];

            for (int i = 0; i < teamsCount; i++)
            {
                _teams.Add(new()
                {
                    Number = i,
                    Fighters = [],
                });
            }

            _selectedTeam = 0;
        }

        private async Task HandleValidSubmit()
        {
            try
            {
                await FightApiClient.CreateFight(Command);
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
}