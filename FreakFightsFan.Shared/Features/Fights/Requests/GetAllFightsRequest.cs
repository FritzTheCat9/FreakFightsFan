using FreakFightsFan.Shared.Abstractions;

namespace FreakFightsFan.Shared.Features.Fights.Requests
{
    public class GetAllFightsRequest
    {
        public int Page { get; set; }
        public int PageSize { get; set; }

        public int EventId { get; set; }
    }
}
