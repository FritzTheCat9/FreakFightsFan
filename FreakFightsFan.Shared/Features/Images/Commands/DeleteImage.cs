using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Images.Commands
{
    public class DeleteImage
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
