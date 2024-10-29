using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.DictionaryItems.Queries;

public static class GetAllMyDictionaryItemsByCode
{
    public class Query : IRequest<PagedList<MyDictionaryItemDto>>, IPagedQuery, ISortedQuery
    {
        public string SearchTerm { get; set; }
        public string DictionaryCode { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public SortOrder SortOrder { get; set; }
    }

    public class Validator : AbstractValidator<Query> { }
}