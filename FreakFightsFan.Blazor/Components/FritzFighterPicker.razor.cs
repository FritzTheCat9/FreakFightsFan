using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Queries;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using FreakFightsFan.Shared.Features.Fights.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Components
{
    public partial class FritzFighterPicker : MudAutocomplete<FighterDto>
    {
        private MudAutocomplete<FighterDto> _autocomplete;

        private readonly Func<FighterDto, string> _displayFighter = fighter
            => fighter is null ? null : $@"{fighter.FirstName} {fighter.LastName} - ""{fighter.Nickname}""";

        [Parameter] public List<CreateFight.TeamHelperModel> Teams { get; set; } = [];

        [Inject] public IExceptionHandler ExceptionHandler { get; set; }
        [Inject] public IFighterApiClient FighterApiClient { get; set; }

        [Inject] public IStringLocalizer<App> Localizer { get; set; }

        public async Task Focus()
            => await _autocomplete.FocusAsync();

        private async Task OnValueChanged(FighterDto value)
            => await SelectOption(value);

        private async Task<IEnumerable<FighterDto>> Search(string value, CancellationToken token)
        {
            var query = new GetAllFighters.Query
            {
                Page = 1,
                PageSize = 10,
                SortColumn = "name",
                SortOrder = SortOrder.Ascending,
                SearchTerm = value ?? "",
                HiddenFightersIds = GetHiddenFightersIds(),
            };

            PagedList<FighterDto> FightersPagedList;
            try
            {
                FightersPagedList = await FighterApiClient.GetAllFighters(query);
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExceptions(ex);
                return [];
            }

            return FightersPagedList.Items;
        }

        private List<int> GetHiddenFightersIds()
        {
            var fightersToHide = new List<int>();

            foreach (var team in Teams)
            {
                foreach (var fighter in team.Fighters)
                {
                    if (!fightersToHide.Contains(fighter.Fighter.Id))
                        fightersToHide.Add(fighter.Fighter.Id);
                }
            }

            return fightersToHide;
        }
    }
}