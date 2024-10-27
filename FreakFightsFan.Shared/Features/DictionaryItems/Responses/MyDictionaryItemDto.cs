namespace FreakFightsFan.Shared.Features.DictionaryItems.Responses;

public class MyDictionaryItemDto
{
    public int Id { get; set; }
    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }

    public string Name { get; set; }
    public string Code { get; set; }
    public int DictionaryId { get; set; }
}