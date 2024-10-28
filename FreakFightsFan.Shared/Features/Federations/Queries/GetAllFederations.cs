using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Federations.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Federations.Queries;

public static class GetAllFederations
{
    public class Query : IRequest<PagedList<FederationDto>>, IPagedQuery, ISortedQuery
    {
        public string SearchTerm { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public SortOrder SortOrder { get; set; }
    }

    public class Validator : AbstractValidator<Query> { }
}