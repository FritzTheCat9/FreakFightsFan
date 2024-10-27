using FluentValidation;
using MediatR;

namespace FreakFightsFan.Shared.Features.Dictionaries.Commands;

public static class DeleteMyDictionary
{
    public class Command : IRequest<Unit>
    {
        public int Id { get; set; }
    }

    public class Validator : AbstractValidator<Command>
    {

    }
}