using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Api.Features.Dictionaries.Extensions;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Requests;
using FreakFightsFan.Shared.Features.Users.Helpers;
using MediatR;

namespace FreakFightsFan.Api.Features.Dictionaries.Commands
{
    public static class UpdateMyDictionary
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Code { get; set; }
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

        public class Handler : IRequestHandler<Command, Unit>
        {
            private readonly IMyDictionaryRepository _myDictionaryRepository;
            private readonly IClock _clock;

            public Handler(IMyDictionaryRepository myDictionaryRepository, IClock clock)
            {
                _myDictionaryRepository = myDictionaryRepository;
                _clock = clock;
            }

            public async Task<Unit> Handle(Command command, CancellationToken cancellationToken)
            {
                var dictionary = await _myDictionaryRepository.Get(command.Id) ?? throw new MyNotFoundException();

                await ValidateCommand(command);

                dictionary.Name = command.Name;
                dictionary.Code = command.Code;
                dictionary.Modified = _clock.Current();

                await _myDictionaryRepository.Update(dictionary);
                return Unit.Value;
            }

            private async Task ValidateCommand(Command command)
            {
                var codeExists = await _myDictionaryRepository.DictionaryCodeExistsInOtherDictionariesThan(command.Code, command.Id);
                if (codeExists)
                    throw new MyValidationException("Code", "'Code' must be unique");
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut("/api/myDictionaries/{id}", async (
                int id,
                UpdateMyDictionaryRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                return Results.Ok(await mediator.Send(request.ToUpdateMyDictionaryCommand(id), cancellationToken));
            })
                .WithTags("MyDictionaries")
                .RequireAuthorization(Policy.Admin);

            return app;
        }
    }
}
