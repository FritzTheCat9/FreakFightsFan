using FluentValidation;
using FreakFightsFan.Shared.Exceptions;
using MediatR;

namespace FreakFightsFan.Shared.Features.Events.Commands
{
    public class UpdateEvent
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public DateTime? Date { get; set; }
            public int? CityId { get; set; }
            public int? HallId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty()
                    .WithMessage(x => ValidationMessages.NotEmpty(nameof(x.Name)));

                RuleFor(x => x.Date)
                    .NotEmpty()
                    .WithMessage(x => ValidationMessages.NotEmpty(nameof(x.Date)));

                RuleFor(x => x.CityId)
                    .NotEmpty()
                    .WithMessage(x => ValidationMessages.NotEmpty("City"));

                RuleFor(x => x.HallId)
                    .NotEmpty()
                    .WithMessage(x => ValidationMessages.NotEmpty("Hall"));
            }
        }
    }
}
