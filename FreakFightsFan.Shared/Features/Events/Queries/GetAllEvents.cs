using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Events.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Events.Queries;

public static class GetAllEvents
{
    public class Query : IRequest<PagedList<EventDto>>, IPagedQuery, ISortedQuery
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public SortOrder SortOrder { get; set; }
        public string SearchTerm { get; set; }

        public int FederationId { get; set; }
    }

    public class Validator : AbstractValidator<Query>
    {

    }
}