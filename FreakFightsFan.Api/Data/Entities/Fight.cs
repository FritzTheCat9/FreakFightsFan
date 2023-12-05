namespace FreakFightsFan.Api.Data.Entities
{
    public class Fight : Entity
    {
        public int EventId { get; set; }
        public Event Event { get; set; }
        public List<Team> Teams { get; } = [];
    }
}
