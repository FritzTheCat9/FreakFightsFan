using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fighters.Queries
{
    public class GetAllFighters
    {
        public class Query : IRequest<PagedList<FighterDto>>, IPagedQuery, ISortedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }
            public string SortColumn { get; set; }
            public SortOrder SortOrder { get; set; }
            public string SearchTerm { get; set; }

            public List<int> HiddenFightersIds { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }
    }
}
