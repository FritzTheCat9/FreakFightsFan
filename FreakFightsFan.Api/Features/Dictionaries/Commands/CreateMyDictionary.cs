using Carter;
using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Requests;
using MediatR;

namespace FreakFightsFan.Api.Features.Dictionaries.Commands
{
    public static class CreateMyDictionary
    {
        public class Command : IRequest<int>
        {
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

        public class Handler : IRequestHandler<Command, int>
        {
            private readonly IMyDictionaryRepository _myDictionaryRepository;
            private readonly IClock _clock;

            public Handler(IMyDictionaryRepository myDictionaryRepository, IClock clock)
            {
                _myDictionaryRepository = myDictionaryRepository;
                _clock = clock;
            }

            public async Task<int> Handle(Command command, CancellationToken cancellationToken)
            {
                var nameExists = await _myDictionaryRepository.DictionaryNameExists(command.Name);
                if (nameExists)
                    throw new MyValidationException("Name", "'Name' must be unique");

                var dictionary = new MyDictionary
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                };

                return await _myDictionaryRepository.Create(dictionary);
            }
        }
    }

    public class CreateMyDictionaryEndpoint : ICarterModule
    {
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaries", async (
                CreateMyDictionaryRequest createMyDictionaryRequest,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                var command = new CreateMyDictionary.Command()
                {
                    Name = createMyDictionaryRequest.Name,
                };

                int dictionaryId = await mediator.Send(command, cancellationToken);
                return Results.CreatedAtRoute("GetMyDictionary", new { id = dictionaryId });
            })
                .WithTags("MyDictionaries");
        }
    }
}
