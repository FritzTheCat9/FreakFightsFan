using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using FreakFightsFan.Shared.Features.Events.Responses;
using FreakFightsFan.Shared.Features.Teams.Responses;

namespace FreakFightsFan.Shared.Features.Fights.Responses;

public class FightDto
{
    public int Id { get; init; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public int OrderNumber { get; set; }
    public string VideoUrl { get; set; }

    public int EventId { get; set; }
    public EventDto Event { get; set; }
    public List<TeamDto> Teams { get; set; }
    public MyDictionaryItemDto? Type { get; set; }
}