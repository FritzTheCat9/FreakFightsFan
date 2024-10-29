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

public partial class ImagesPage(
    IExceptionHandler exceptionHandler,
    IImageApiClient imageApiClient,
    IStringLocalizer<App> localizer,
    IDialogService dialogService)
    : ComponentBase
{
    private List<BreadcrumbItem> _items;
    private PagedList<ImageDto> _myImages;
    private MudTable<ImageDto> _table;

    protected override void OnInitialized()
    {
        _items =
        [
            new BreadcrumbItem(localizer[nameof(AppStrings.Images)], null, true)
        ];
    }

    private async Task<TableData<ImageDto>> ServerReload(TableState state, CancellationToken token)
    {
        var query = new GetAllImages.Query
        {
            Page = state.Page + 1,
            PageSize = state.PageSize,
            SortColumn = state.SortLabel,
            SortOrder = (SortOrder)state.SortDirection
        };

        try
        {
            _myImages = await imageApiClient.GetAllImages(query);
        }
        catch (Exception ex)
        {
            exceptionHandler.HandleExceptions(ex);
            return new TableData<ImageDto> { TotalItems = 0, Items = [] };
        }

        return new TableData<ImageDto> { TotalItems = _myImages.TotalCount, Items = _myImages.Items };
    }

    private async Task DeleteImage(int id)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var dialog =
            await dialogService.ShowAsync<DeleteDialog>(localizer[nameof(AppStrings.Delete)], options);

        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            try
            {
                await imageApiClient.DeleteImage(id);
                await _table.ReloadServerData();
            }
            catch (Exception ex)
            {
                exceptionHandler.HandleExceptions(ex);
            }
        }
    }

    private async Task UpdateImage(ImageDto imageDto)
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<UpdateImageDialog>
        {
            { x => x.FormModel, new UpdateImage.FormModel { Id = imageDto.Id, ImageBase64 = "" } },
            { x => x.Url, imageDto.Url }
        };

        var dialog =
            await dialogService.ShowAsync<UpdateImageDialog>(localizer[nameof(AppStrings.UpdateImage)], parameters,
                options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }

    private async Task CreateImage()
    {
        var options = new DialogOptions { CloseOnEscapeKey = true, CloseButton = true };
        var parameters = new DialogParameters<CreateImageDialog> { { x => x.FormModel, new CreateImage.FormModel() } };

        var dialog =
            await dialogService.ShowAsync<CreateImageDialog>(localizer[nameof(AppStrings.CreateImage)], parameters,
                options);
        var result = await dialog.Result;
        if (result is { Canceled: false })
        {
            await _table.ReloadServerData();
        }
    }
}