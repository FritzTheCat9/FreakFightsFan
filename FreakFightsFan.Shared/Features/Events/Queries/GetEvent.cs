using FluentValidation;
using FreakFightsFan.Shared.Features.Events.Responses;
using MediatR;

namespace FreakFightsFan.Shared.Features.Events.Queries
{
    public class GetEvent
    {
        public class Query : IRequest<EventDto>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Query>
        {

        }
    }
}
