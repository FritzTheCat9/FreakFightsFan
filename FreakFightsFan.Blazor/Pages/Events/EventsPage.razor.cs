using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Commands;
using FreakFightsFan.Shared.Features.Events.Queries;
using FreakFightsFan.Shared.Features.Events.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Events;

public partial class EventsPage : ComponentBase
{
    private List<BreadcrumbItem> _items;
    private PagedList<EventDto> _myEvents;
    private string _searchString = "";
    private MudTable<EventDto> _table;
    
    [Parameter] public int FederationId { get; set; }

    [Inject] public IExceptionHandler ExceptionHandler { get; set; }
    [Inject] public IEventApiClient EventApiClient { get; set; }
    [Inject] public IStringLocalizer<App> Localizer { get; set; }
    [Inject] public IDialogService DialogService { get; set; }
    [Inject] public NavigationManager NavigationManager { get; set; }

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(Localizer[nameof(AppStrings.Federations)], "/federations"),
            new BreadcrumbItem(Localizer[nameof(AppStrings.Events)], null, true)
        ];
    }

    private async Task<TableData<EventDto>> ServerReload(TableState state, CancellationToken token)
    {
        var query = new GetAllEvents.Query
        {
            Page = state.Page + 1,
            PageSize = state.PageSize,
            SortColumn = state.SortLabel,
            SortOrder = (SortOrder)state.SortDirection,
            SearchTerm = _searchString,
            FederationId = FederationId
        };

        try
        {
            _myEvents = await EventApiClient.GetAllEvents(query);
        }
        catch (Exception ex)
        {
            ExceptionHandler.HandleExceptions(ex);
            return new TableData<EventDto> { TotalItems = 0, Items = [] };
        }

        return new TableData<EventDto> { TotalItems = _myEvents.TotalCount, Items = _myEvents.Items };
    }

    private void RedirectToFightsPage(int eventId)
    {
        NavigationManager.NavigateTo($"/fights/{FederationId}/{eventId}");
    }

    private async Task DeleteEvent(int id)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var dialog =
            await DialogService.ShowAsync<DeleteDialog>(Localizer[nameof(AppStrings.Delete)], options);

        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            try
            {
                await EventApiClient.DeleteEvent(id);
                await _table.ReloadServerData();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExceptions(ex);
            }
        }
    }

    private async Task UpdateEvent(EventDto eventDto)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<UpdateEventDialog>
        {
            {
                x => x.Command,
                new UpdateEvent.Command
                {
                    Id = eventDto.Id,
                    Name = eventDto.Name,
                    Date = eventDto.Date,
                    CityId = eventDto.City?.Id,
                    HallId = eventDto.Hall?.Id
                }
            },
            { x => x.City, eventDto.City },
            { x => x.Hall, eventDto.Hall }
        };

        var dialog =
            await DialogService.ShowAsync<UpdateEventDialog>(Localizer[nameof(AppStrings.UpdateEvent)], parameters,
                options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }

    private async Task CreateEvent()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<CreateEventDialog>
        {
            {
                x => x.Command,
                new CreateEvent.Command
                {
                    Name = "",
                    Date = DateTime.UtcNow,
                    FederationId = FederationId,
                    CityId = null,
                    HallId = null
                }
            }
        };

        var dialog =
            await DialogService.ShowAsync<CreateEventDialog>(Localizer[nameof(AppStrings.CreateEvent)], parameters,
                options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }
}