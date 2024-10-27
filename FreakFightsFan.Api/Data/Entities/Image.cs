namespace FreakFightsFan.Api.Data.Entities;

public class Image : Entity
{
    public string Name { get; set; }
    public string Url { get; set; }

    public int? FederationId { get; set; }
    public Federation? Federation { get; set; }
    public int? FighterId { get; set; }
    public Fighter? Fighter { get; set; }
}