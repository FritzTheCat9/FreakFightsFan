namespace FreakFightsFan.Shared.Features.Fights.Requests
{
    public class UpdateFightRequest
    {
        public int Id { get; set; }
        public List<CreateTeamModel> Teams { get; set; }
    }
}

