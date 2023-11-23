using FreakFightsFan.Shared.Abstractions;

namespace FreakFightsFan.Shared.Features.Images.Requests
{
    public class GetAllImagesRequest
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public SortOrder SortOrder { get; set; }
    }
}
