using FluentValidation;
using FreakFightsFan.Api.Abstractions;
using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Data.Repositories;
using FreakFightsFan.Shared.Exceptions;
using FreakFightsFan.Shared.Features.Dictionaries.Requests;
using FreakFightsFan.Api.Features.Dictionaries.Extensions;
using MediatR;

namespace FreakFightsFan.Api.Features.Dictionaries.Commands
{
    public static class CreateMyDictionary
    {
        public class Command : IRequest<int>
        {
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
                var codeExists = await _myDictionaryRepository.DictionaryCodeExists(command.Code);
                if (codeExists)
                    throw new MyValidationException("Code", "'Code' must be unique");

                var dictionary = new MyDictionary
                {
                    Id = 0,
                    Created = _clock.Current(),
                    Modified = _clock.Current(),
                    Name = command.Name,
                    Code = command.Code,
                };

                return await _myDictionaryRepository.Create(dictionary);
            }
        }

        public static IEndpointRouteBuilder Endpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost("/api/myDictionaries", async (
                CreateMyDictionaryRequest request,
                IMediator mediator,
                CancellationToken cancellationToken) =>
            {
                int dictionaryId = await mediator.Send(request.ToCreateMyDictionaryCommand(), cancellationToken);
                return Results.CreatedAtRoute("GetMyDictionary", new { id = dictionaryId });
            })
                .WithTags("MyDictionaries");

            return app;
        }
    }
}
