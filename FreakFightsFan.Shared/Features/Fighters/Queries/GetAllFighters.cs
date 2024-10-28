using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fighters.Queries;

public static class GetAllFighters
{
    public class Query : IRequest<PagedList<FighterDto>>, IPagedQuery, ISortedQuery
    {
        public string SearchTerm { get; set; }

        public List<int> HiddenFightersIds { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public string SortColumn { get; set; }
        public SortOrder SortOrder { get; set; }
    }

    public class Validator : AbstractValidator<Query> { }
}