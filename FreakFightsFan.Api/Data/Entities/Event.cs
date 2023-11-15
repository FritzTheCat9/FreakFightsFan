namespace FreakFightsFan.Api.Data.Entities
{
    public class Event : Entity
    {
        public string Name { get; set; }

        public int FederationId { get; set; }
        public Federation Federation { get; set; }
    }
}
