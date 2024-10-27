using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.DictionaryItems.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.DictionaryItems.Queries;

public static class GetAllMyDictionaryItems
{
    public class Query : IRequest<PagedList<MyDictionaryItemDto>>, IPagedQuery, ISortedQuery
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public SortOrder SortOrder { get; set; }
        public string SearchTerm { get; set; }

        public int DictionaryId { get; set; }
    }

    public class Validator : AbstractValidator<Query>
    {

    }
}