namespace FreakFightsFan.Api.Data.Entities;

public class Fight : Entity
{
    public int OrderNumber { get; set; }
    public string VideoUrl { get; set; }

    public int EventId { get; set; }
    public Event Event { get; set; }
    public int? TypeId { get; set; }
    public MyDictionaryItem? Type { get; set; }
    public List<Team> Teams { get; } = [];
}