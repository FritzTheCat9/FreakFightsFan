using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Dictionaries.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Dictionaries.Queries
{
    public static class GetAllMyDictionaries
    {
        public class Query : IRequest<PagedList<MyDictionaryDto>>, IPagedQuery, ISortedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
            public string SortColumn { get; set; }
            public SortOrder SortOrder { get; set; }
            public string SearchTerm { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }
    }
}
