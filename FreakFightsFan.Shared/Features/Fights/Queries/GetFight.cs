using FluentValidation;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fights.Queries
{
    public class GetFight
    {
        public class Query : IRequest<FightDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }
    }
}
