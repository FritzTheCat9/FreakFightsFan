using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Dictionaries.Commands
{
    public static class UpdateMyDictionary
    {
        public class Command : IRequest<Unit>
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public class Validator : AbstractValidator<Command>
        {
            public Validator()
            {
                RuleFor(x => x.Name)
                    .NotEmpty();
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

                var nameExists = await _myDictionaryRepository.DictionaryNameExistsInOtherDictionariesThan(command.Name, command.Id);
                if (nameExists)
                    throw new MyValidationException("Name", "'Name' must be unique");

                dictionary.Name = command.Name;
                dictionary.Modified = _clock.Current();

                await _myDictionaryRepository.Update(dictionary);
                return Unit.Value;
            }
        }
    }

    public class UpdateMyDictionaryEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPut("/api/myDictionaries/{id}", async (
                int id,
                UpdateMyDictionaryRequest updateMyDictionaryRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new UpdateMyDictionary.Command()
                {
                    Id = id,
                    Name = updateMyDictionaryRequest.Name,
                };

                return Results.Ok(await mediator.Send(command, cancellationToken));
            })
                .WithTags("MyDictionaries");
        }
    }
}
