using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.DictionaryItems.Commands;

public static class DeleteMyDictionaryItem
{
    public class Command : IRequest<Unit>
    {
        public int Id { get; init; }
    }

    public class Validator : AbstractValidator<Command> { }
}