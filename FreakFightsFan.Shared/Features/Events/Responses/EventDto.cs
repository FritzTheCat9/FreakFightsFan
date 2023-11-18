namespace FreakFightsFan.Shared.Features.Events.Responses
{
    public class EventDto
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int FederationId { get; set; }
    }
}

