using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fights.Queries
{
    public class GetAllFights
    {
        public class Query : IRequest<PagedList<FightDto>>, IPagedQuery
        {
            public int Page { get; set; }
            public int PageSize { get; set; }

            public int EventId { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }
    }
}
