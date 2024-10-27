using FreakFightsFan.Blazor.Clients;
using FreakFightsFan.Blazor.Exceptions;
using FreakFightsFan.Blazor.Localization;
using FreakFightsFan.Blazor.Shared;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Images.Commands;
using FreakFightsFan.Shared.Features.Images.Queries;
using FreakFightsFan.Shared.Features.Images.Responses;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Localization;
using MudBlazor;

namespace FreakFightsFan.Blazor.Pages.Images;

public partial class ImagesPage : ComponentBase
{
    private List<BreadcrumbItem> _items;
    private MudTable<ImageDto> _table;

    private PagedList<ImageDto> _myImages;

    [Inject] public IExceptionHandler ExceptionHandler { get; set; }
    [Inject] public IImageApiClient ImageApiClient { get; set; }

    [Inject] public IStringLocalizer<App> Localizer { get; set; }

    [Inject] public IDialogService DialogService { get; set; }
    [Inject] public NavigationManager NavigationManager { get; set; }

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(Localizer[nameof(AppStrings.Images)], href: null, disabled: true),
        ];
    }

    private async Task<TableData<ImageDto>> ServerReload(TableState state, CancellationToken token)
    {
        var query = new GetAllImages.Query
        {
            Page = state.Page + 1,
            PageSize = state.PageSize,
            SortColumn = state.SortLabel,
            SortOrder = ((SortOrder)state.SortDirection),
        };

        try
        {
            _myImages = await ImageApiClient.GetAllImages(query);
        }
        catch (Exception ex)
        {
            ExceptionHandler.HandleExceptions(ex);
            return new TableData<ImageDto> { TotalItems = 0, Items = [] };
        }

        return new TableData<ImageDto>
        {
            TotalItems = _myImages.TotalCount,
            Items = _myImages.Items
        };
    }

    private async Task DeleteImage(int id)
    {
        var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
        var dialog = await DialogService.ShowAsync<DeleteDialog>(Localizer[nameof(AppStrings.Delete)], options);

        var result = await dialog.Result;
        if (!result.Canceled)
        {
            try
            {
                await ImageApiClient.DeleteImage(id);
                await _table.ReloadServerData();
            }
            catch (Exception ex)
            {
                ExceptionHandler.HandleExceptions(ex);
            }
        }
    }

    private async Task UpdateImage(ImageDto imageDto)
    {
        var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<UpdateImageDialog>
        {
            {
                x => x.FormModel,
                new UpdateImage.FormModel
                {
                    Id = imageDto.Id,
                    ImageBase64 = ""
                }
            },
            {
                x => x.Url,
                imageDto.Url
            }
        };

        var dialog = await DialogService.ShowAsync<UpdateImageDialog>(Localizer[nameof(AppStrings.UpdateImage)], parameters, options);
        var result = await dialog.Result;
        if (!result.Canceled)
        {
            await _table.ReloadServerData();
        }
    }

    private async Task CreateImage()
    {
        var options = new DialogOptions() { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<CreateImageDialog>
        {
            { 
                x => x.FormModel,
                new CreateImage.FormModel()
            }
        };

        var dialog = await DialogService.ShowAsync<CreateImageDialog>(Localizer[nameof(AppStrings.CreateImage)], parameters, options);
        var result = await dialog.Result;
        if (!result.Canceled)
        {
            await _table.ReloadServerData();
        }
    }
}