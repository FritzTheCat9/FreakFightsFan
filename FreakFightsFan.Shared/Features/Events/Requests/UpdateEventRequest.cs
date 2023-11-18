namespace FreakFightsFan.Shared.Features.Events.Requests
{
    public class UpdateEventRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }
    }
}

