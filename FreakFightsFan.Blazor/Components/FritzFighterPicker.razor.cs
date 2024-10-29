using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Queries;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using FreakFightsFan.Shared.Features.Fights.Commands;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;
using System.Linq.Expressions;

namespace FreakFightsFan.Blazor.Components;

public partial class FritzFighterPicker(
    IExceptionHandler exceptionHandler,
    IFighterApiClient fighterApiClient,
    IStringLocalizer<App> localizer)
    : ComponentBase
{
    private readonly Func<FighterDto, string> _displayFighter = fighter
        => fighter is null
            ? null
            : $"""
               {fighter.FirstName} {fighter.LastName} - "{fighter.Nickname}"
               """;

    private MudAutocomplete<FighterDto> _autocomplete;

    [Parameter] public List<CreateFight.TeamHelperModel> Teams { get; set; } = [];
    [Parameter] public string Label { get; set; }
    [Parameter] public bool OnlyValidateIfDirty { get; set; } = true;
    [Parameter] public FighterDto Value { get; set; }
    [Parameter] public EventCallback<FighterDto> ValueChanged { get; set; }
    [Parameter] public Expression<Func<FighterDto>> For { get; set; }

    public async Task Focus()
    {
        await _autocomplete.FocusAsync();
    }

    private async Task OnValueChanged(FighterDto newValue)
    {
        Value = newValue;
        await ValueChanged.InvokeAsync(newValue);
    }

    private async Task<IEnumerable<FighterDto>> Search(string value, CancellationToken token)
    {
        var query = new GetAllFighters.Query
        {
            Page = 1,
            PageSize = 10,
            SortColumn = "name",
            SortOrder = SortOrder.Ascending,
            SearchTerm = value ?? "",
            HiddenFightersIds = GetHiddenFightersIds()
        };

        PagedList<FighterDto> fightersPagedList;
        try
        {
            fightersPagedList = await fighterApiClient.GetAllFighters(query);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
            return [];
        }

        return fightersPagedList.Items;
    }

    private List<int> GetHiddenFightersIds()
    {
        var fightersToHide = new List<int>();

        foreach (var fighter in Teams.SelectMany(team
                     => team.Fighters.Where(fighter => !fightersToHide.Contains(fighter.Fighter.Id))))
        {
            fightersToHide.Add(fighter.Fighter.Id);
        }

        return fightersToHide;
    }
}