using FluentValidation;
using FreakFightsFan.Shared.Features.Teams.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Teams.Queries;

public static class GetTeam
{
    public class Query : IRequest<TeamDto>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Query> { }
}