namespace FreakFightsFan.Shared.Features.Fighters.Requests
{
    public class UpdateFighterRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public string InstagramUrl { get; set; }
        public string ImageBase64 { get; set; }
    }
}
