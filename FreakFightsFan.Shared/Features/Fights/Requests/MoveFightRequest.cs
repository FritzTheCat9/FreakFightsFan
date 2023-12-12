using FreakFightsFan.Shared.Abstractions;

namespace FreakFightsFan.Shared.Features.Fights.Requests
{
    public class MoveFightRequest
    {
        public int Id { get; set; }
        public MoveDirection Direction { get; set; }
    }
}
