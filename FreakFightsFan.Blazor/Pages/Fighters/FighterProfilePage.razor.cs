using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using FreakFightsFan.Shared.Features.Fights.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Fighters;

public partial class FighterProfilePage(
    IExceptionHandler exceptionHandler,
    IFightApiClient fightApiClient,
    IFighterApiClient fighterApiClient,
    IStringLocalizer<App> localizer,
    IJSRuntime jsRuntime)
    : ComponentBase
{
    private readonly ChartOptions _chartOptions = new()
    {
        ChartPalette =
        [
            Colors.Green.Default,
            Colors.Red.Default,
            Colors.Gray.Default,
            Colors.Blue.Default
        ]
    };

    private double[] _data = [];
    private FighterDto _fighter;
    private string[] _labels;
    private FighterProfileDto _profile;

    [Parameter] public int FighterId { get; set; }

    protected override void OnInitialized()
    {
        _labels =
        [
            localizer[nameof(AppStrings.Wins)],
            localizer[nameof(AppStrings.Losses)],
            localizer[nameof(AppStrings.Draws)],
            localizer[nameof(AppStrings.NoContest)]
        ];
    }

    protected override async Task OnParametersSetAsync()
    {
        var getFighterFightsTask = GetFighterFights();
        var getFighterTask = GetFighter();
        await Task.WhenAll(getFighterFightsTask, getFighterTask);
    }

    private async Task GetFighterFights()
    {
        try
        {
            _profile = await fightApiClient.GetFighterProfile(FighterId);
            _data = [_profile.Stats.Win, _profile.Stats.Loss, _profile.Stats.Draw, _profile.Stats.NoContest];
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
            _profile = null;
        }
    }

    private async Task GetFighter()
    {
        try
        {
            _fighter = await fighterApiClient.GetFighter(FighterId);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
            _fighter = null;
        }
    }

    private async Task RedirectToVideo(FightDto fightDto)
    {
        if (!string.IsNullOrEmpty(fightDto.VideoUrl))
        {
            await jsRuntime.InvokeVoidAsync("open", fightDto.VideoUrl, "_blank");
        }
    }

    private static string InstagramUrlToNickname(string url)
    {
        return url.Replace("https://www.instagram.com/", "").Replace("/", "");
    }
}