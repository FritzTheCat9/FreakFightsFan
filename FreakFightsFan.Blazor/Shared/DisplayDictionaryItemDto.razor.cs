using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using Microsoft.AspNetCore.Components;

namespace FreakFightsFan.Blazor.Shared
{
    public partial class DisplayDictionaryItemDto : ComponentBase
    {
        [Parameter] public MyDictionaryItemDto DictionaryItemDto { get; set; }
    }
}