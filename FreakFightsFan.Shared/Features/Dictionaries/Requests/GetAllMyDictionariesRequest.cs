using FreakFightsFan.Shared.Abstractions;

namespace FreakFightsFan.Shared.Features.Dictionaries.Requests
{
    public class GetAllMyDictionariesRequest
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public SortOrder SortOrder { get; set; }
        public string SearchTerm { get; set; }
    }
}
