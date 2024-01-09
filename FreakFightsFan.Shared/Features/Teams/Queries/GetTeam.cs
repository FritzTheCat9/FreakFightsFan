using FluentValidation;
using FreakFightsFan.Shared.Features.Teams.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Teams.Queries
{
    public class GetTeam
    {
        public class Query : IRequest<TeamDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }
    }
}
