namespace FreakFightsFan.Api.Data.Entities
{
    public class Federation : Entity
    {
        public string Name { get; set; }

        public List<Event> Events { get; set; }
    }
}
