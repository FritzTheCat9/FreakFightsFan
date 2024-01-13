using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Events.Commands
{
    public class CreateEvent
    {
        public class Command : IRequest<int>
        {
            public string Name { get; set; }
            public DateTime? Date { get; set; }
            public int FederationId { get; set; }
            public int? CityId { get; set; }
            public int? HallId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();

                RuleFor(x => x.Date)
                    .NotEmpty();

                RuleFor(x => x.CityId)
                    .NotEmpty();

                RuleFor(x => x.HallId)
                    .NotEmpty();
            }
        }
    }
}
