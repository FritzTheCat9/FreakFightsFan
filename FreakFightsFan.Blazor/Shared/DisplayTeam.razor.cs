using FreakFightsFan.Shared.Features.Teams.Responses;
using Microsoft.AspNetCore.Components;

namespace FreakFightsFan.Blazor.Shared;

public partial class DisplayTeam : ComponentBase
{
    [Parameter] public TeamDto TeamDto { get; set; }
}