using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.DictionaryItems.Commands
{
    public class DeleteMyDictionaryItem
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
