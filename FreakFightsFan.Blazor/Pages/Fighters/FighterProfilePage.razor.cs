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

public partial class FighterProfilePage : ComponentBase
{
    private FighterProfileDto _profile;
    private FighterDto _fighter;

    private string[] _labels;
    private double[] _data = [];
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

    [Parameter] public int FighterId { get; set; }

    [Inject] public IExceptionHandler ExceptionHandler { get; set; }
    [Inject] public IFightApiClient FightApiClient { get; set; }
    [Inject] public IFighterApiClient FighterApiClient { get; set; }

    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    [Inject] public IJSRuntime JsRuntime { get; set; }

    protected override void OnInitialized()
    {
        _labels =
        [
            Localizer[nameof(AppStrings.Wins)],
            Localizer[nameof(AppStrings.Losses)],
            Localizer[nameof(AppStrings.Draws)],
            Localizer[nameof(AppStrings.NoContest)],
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
            _profile = await FightApiClient.GetFighterProfile(FighterId);
            _data = [_profile.Stats.Win, _profile.Stats.Loss, _profile.Stats.Draw, _profile.Stats.NoContest];
        }
        catch (Exception ex)
        {
            ExceptionHandler.HandleExceptions(ex);
            _profile = null;
        }
    }

    private async Task GetFighter()
    {
        try
        {
            _fighter = await FighterApiClient.GetFighter(FighterId);
        }
        catch (Exception ex)
        {
            ExceptionHandler.HandleExceptions(ex);
            _fighter = null;
        }
    }

    private async Task RedirectToVideo(FightDto fightDto)
    {
        if (!string.IsNullOrEmpty(fightDto.VideoUrl))
        {
            await JsRuntime.InvokeVoidAsync("open", fightDto.VideoUrl, "_blank");
        }
    }

    private static string InstagramUrlToNickname(string url)
    {
        return url.Replace("https://www.instagram.com/", "").Replace("/", "");
    }
}