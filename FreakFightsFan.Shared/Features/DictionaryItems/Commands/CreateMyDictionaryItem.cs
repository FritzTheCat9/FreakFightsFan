using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.DictionaryItems.Commands
{
    public class CreateMyDictionaryItem
    {
        public class Command : IRequest<int>
        {
            public string Name { get; set; }
            public string Code { get; set; }
            public int DictionaryId { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();

                RuleFor(x => x.Code)
                    .NotEmpty()
                    .MaximumLength(30)
                    .Matches("^[A-Z0-9_]+$")
                        .WithMessage("Code can contain only: A-Z, 0-9 and _ characters");
            }
        }
    }
}
