namespace FreakFightsFan.Shared.Features.Fights.Requests
{
    public class CreateFightRequest
    {
        public int EventId { get; set; }
        public List<CreateTeamModel> Teams { get; set; }
    }

    public class CreateTeamModel
    {
        public List<int> FightersIds { get; set; }
    }
}
