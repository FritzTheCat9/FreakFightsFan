using FluentValidation;
using FreakFightsFan.Shared.Features.Events.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Events.Queries;

public static class GetEvent
{
    public class Query : IRequest<EventDto>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Query> { }
}