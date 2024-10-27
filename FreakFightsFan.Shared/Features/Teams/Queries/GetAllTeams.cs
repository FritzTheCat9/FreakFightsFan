using FluentValidation;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Teams.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Teams.Queries;

public static class GetAllTeams
{
    public class Query : IRequest<PagedList<TeamDto>>, IPagedQuery
    {
        public int Page { get; set; }
        public int PageSize { get; set; }
    }

    public class Validator : AbstractValidator<Query>
    {

    }
}