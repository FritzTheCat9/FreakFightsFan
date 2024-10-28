using FluentValidation;
using FreakFightsFan.Shared.Features.Fighters.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fighters.Queries;

public static class GetFighter
{
    public class Query : IRequest<FighterDto>
    {
        public int Id { get; set; }
    }

    public class Validator : AbstractValidator<Query> { }
}