using FluentValidation;
using FreakFightsFan.Shared.Features.Fights.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fights.Queries;

public static class GetFighterProfile
{
    public class Query : IRequest<FighterProfileDto>
    {
        public int Id { get; set; }
    }

    public class Validator : AbstractValidator<Query>
    {

    }
}