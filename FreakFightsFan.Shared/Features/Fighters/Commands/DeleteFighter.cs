using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Fighters.Commands
{
    public class DeleteFighter
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
