using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Responses;
using FreakFightsFan.Shared.Features.Fights.Commands;
using FreakFightsFan.Shared.Features.Fights.Helpers;
using FreakFightsFan.Shared.Features.Fights.Queries;
using FreakFightsFan.Shared.Features.Fights.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using Microsoft.JSInterop;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Fights;

public partial class FightsPage(
    IExceptionHandler exceptionHandler,
    IFightApiClient fightApiClient,
    IEventApiClient eventApiClient,
    IStringLocalizer<App> localizer,
    IDialogService dialogService,
    IJSRuntime jsRuntime)
    : ComponentBase
{
    private EventDto _event;
    private List<BreadcrumbItem> _items = [];

    private List<FightDto> _myFights;

    [Parameter] public int FederationId { get; set; }
    [Parameter] public int EventId { get; set; }

    protected override void OnParametersSet()
    {
        _items =
        [
            new BreadcrumbItem(localizer[nameof(AppStrings.Federations)], "/federations"),
            new BreadcrumbItem(localizer[nameof(AppStrings.Events)], $"/events/{FederationId}"),
            new BreadcrumbItem(localizer[nameof(AppStrings.Fights)], null, true)
        ];
    }

    protected override async Task OnInitializedAsync()
    {
        var getEventTask = GetEvent();
        var getAllFightersTask = GetAllFights();
        await Task.WhenAll(getEventTask, getAllFightersTask);
    }

    private async Task GetEvent()
    {
        try
        {
            _event = await eventApiClient.GetEvent(EventId);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
            _event = null;
        }
    }

    private async Task GetAllFights()
    {
        var query = new GetAllFights.Query { Page = 1, PageSize = FightsConsts.MaxFightsInOneEvent, EventId = EventId };

        try
        {
            _myFights = (await fightApiClient.GetAllFights(query)).Items;
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
            _myFights = [];
        }
    }

    private async Task DeleteFight(int id)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var dialog =
            await dialogService.ShowAsync<DeleteDialog>(localizer[nameof(AppStrings.Delete)], options);

        var result = await dialog.Result;
        if (!result.Canceled)
        {
            try
            {
                await fightApiClient.DeleteFight(id);
                await GetAllFights();
            }
            catch (Exception ex)
            {
                exceptionHandler.HandleExceptions(ex);
            }
        }
    }

    private async Task MoveFight(int id, MoveDirection direction)
    {
        try
        {
            var command = new MoveFight.Command { Id = id, Direction = direction };
            await fightApiClient.MoveFight(command);
            await GetAllFights();
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
        }
    }

    private async Task RedirectToVideo(FightDto fightDto)
    {
        if (!string.IsNullOrEmpty(fightDto.VideoUrl))
        {
            await jsRuntime.InvokeVoidAsync("open", fightDto.VideoUrl, "_blank");
        }
    }

    private async Task UpdateFight(FightDto fightDto)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<UpdateFightDialog>
        {
            {
                x => x.Command,
                new UpdateFight.Command
                {
                    Id = fightDto.Id, Teams = [], VideoUrl = fightDto.VideoUrl, TypeId = fightDto.Type?.Id
                }
            },
            { x => x.Teams, fightDto.Teams },
            { x => x.NumberOfTeams, fightDto.Teams.Count },
            { x => x.FightType, fightDto.Type }
        };

        var dialog =
            await dialogService.ShowAsync<UpdateFightDialog>(localizer[nameof(AppStrings.UpdateFight)], parameters,
                options);
        var result = await dialog.Result;
        if (!result.Canceled)
        {
            await GetAllFights();
        }
    }

    private async Task CreateFight()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<CreateFightDialog>
        {
            {
                x => x.Command,
                new CreateFight.Command { EventId = EventId, Teams = [], VideoUrl = null, TypeId = null }
            },
            { x => x.NumberOfTeams, 2 }
        };

        var dialog =
            await dialogService.ShowAsync<CreateFightDialog>(localizer[nameof(AppStrings.CreateFight)], parameters,
                options);
        var result = await dialog.Result;
        if (!result.Canceled)
        {
            await GetAllFights();
        }
    }
}