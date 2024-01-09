using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Events.Commands
{
    public class DeleteEvent
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {

        }
    }
}
