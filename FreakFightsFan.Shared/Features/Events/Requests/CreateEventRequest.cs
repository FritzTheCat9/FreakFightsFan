namespace FreakFightsFan.Shared.Features.Events.Requests
{
    public class CreateEventRequest
    {
        public string Name { get; set; }
        public DateTime? Date { get; set; }
        public int FederationId { get; set; }
    }
}
