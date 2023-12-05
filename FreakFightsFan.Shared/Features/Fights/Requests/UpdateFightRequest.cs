namespace FreakFightsFan.Shared.Features.Fights.Requests
{
    public class UpdateFightRequest
    {
        public int Id { get; set; }
        public List<UpdateTeamModel> Teams { get; set; }
    }

    public class UpdateTeamModel
    {
        public List<int> FightersIds { get; set; }
    }
}

