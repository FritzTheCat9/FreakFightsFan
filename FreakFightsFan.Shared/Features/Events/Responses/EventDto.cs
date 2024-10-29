using FreakFightsFan.Shared.Features.DictionaryItems.Responses;

namespace FreakFightsFan.Shared.Features.Events.Responses;

public class EventDto
{
    public int Id { get; init; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }

    public string Name { get; set; }
    public DateTime Date { get; set; }
    public int FederationId { get; set; }
    public MyDictionaryItemDto? City { get; set; }
    public MyDictionaryItemDto? Hall { get; set; }
}